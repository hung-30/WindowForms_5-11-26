using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai4._9_Quanlylichhenphongkham
{
    public partial class Form1 : Form
    {
        // Danh sách gốc chứa toàn bộ dữ liệu lịch hẹn
        private BindingList<Appointment> originalList = new BindingList<Appointment>();

        // Danh sách hiển thị trên DataGridView (đã qua lọc / tìm kiếm)
        private BindingList<Appointment> filteredList = new BindingList<Appointment>();

        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            SetupControlsAndData();
        }

        private void SetupControlsAndData()
        {
            // 1. Cấu hình DataGridView
            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.MultiSelect = false;

            // 2. Khởi tạo danh sách Bác sĩ
            cboDoctor.Items.AddRange(new object[] {
                "BS. Nguyễn Văn A",
                "BS. Trần Thị B",
                "BS. Lê Hoàng C",
                "BS. Phạm Minh D"
            });
            if (cboDoctor.Items.Count > 0) cboDoctor.SelectedIndex = 0;

            // 3. Khởi tạo ComboBox Trạng thái nhập liệu
            cboStatus.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboStatus.SelectedIndex = 0;

            // 4. Khởi tạo ComboBox Trạng thái lọc
            cboFilterStatus.Items.AddRange(new object[] { "Tất cả", "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboFilterStatus.SelectedIndex = 0;

            // 5. Định dạng DateTimePicker (Ngày & Giờ)
            dtpAppointmentDate.Format = DateTimePickerFormat.Custom;
            dtpAppointmentDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpAppointmentDate.Value = DateTime.Now.AddHours(1);

            dtpFilterDate.Format = DateTimePickerFormat.Custom;
            dtpFilterDate.CustomFormat = "dd/MM/yyyy";

            // 6. Liên kết BindingSource với DataGridView
            bindingSource.DataSource = filteredList;
            dgvAppointments.DataSource = bindingSource;

            // 7. Tạo dữ liệu mẫu và nạp bảng
            SeedSampleData();
            ApplyFilter();
        }

        private void SeedSampleData()
        {
            originalList.Add(new Appointment
            {
                Id = "LH001",
                PatientName = "Nguyễn Văn Nam",
                Phone = "0912345678",
                AppointmentDate = DateTime.Now.AddDays(1),
                Doctor = "BS. Nguyễn Văn A",
                Reason = "Khám sức khỏe tổng quát",
                Status = "Chờ khám"
            });
            originalList.Add(new Appointment
            {
                Id = "LH002",
                PatientName = "Trần Thị Hoa",
                Phone = "0987654321",
                AppointmentDate = DateTime.Now.AddDays(2),
                Doctor = "BS. Trần Thị B",
                Reason = "Đau đầu kéo dài",
                Status = "Đang khám"
            });
        }

        #region Kiểm tra dữ liệu (Validation bằng ErrorProvider)
        private bool ValidateInputs(bool isAddingNew)
        {
            errorProvider1.Clear();
            bool isValid = true;

            // 1. Kiểm tra Mã lịch hẹn (Bắt buộc & Duy nhất khi thêm mới)
            string id = txtId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                errorProvider1.SetError(txtId, "Mã lịch hẹn không được để trống.");
                isValid = false;
            }
            else if (isAddingNew && originalList.Any(a => a.Id.Equals(id, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtId, "Mã lịch hẹn đã tồn tại trong hệ thống.");
                isValid = false;
            }

            // 2. Kiểm tra Họ tên bệnh nhân
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Họ tên bệnh nhân không được để trống.");
                isValid = false;
            }

            // 3. Kiểm tra Số điện thoại (Hợp lệ: 10 chữ số, bắt đầu bằng 0)
            string phonePattern = @"^0\d{9}$";
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại không được để trống.");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtPhone.Text.Trim(), phonePattern))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại không hợp lệ (cần đúng 10 chữ số, bắt đầu bằng 0).");
                isValid = false;
            }

            // 4. Kiểm tra Ngày hẹn (Không được nằm trong quá khứ)
            if (dtpAppointmentDate.Value < DateTime.Now.AddMinutes(-1))
            {
                errorProvider1.SetError(dtpAppointmentDate, "Ngày giờ hẹn không được nằm trong quá khứ.");
                isValid = false;
            }

            // 5. Kiểm tra Lý do khám
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                errorProvider1.SetError(txtReason, "Lý do khám không được để trống.");
                isValid = false;
            }

            return isValid;
        }
        #endregion

        #region Chức năng CRUD (Thêm, Cập nhật, Xóa)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(isAddingNew: true)) return;

            var newApp = new Appointment
            {
                Id = txtId.Text.Trim(),
                PatientName = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                AppointmentDate = dtpAppointmentDate.Value,
                Doctor = cboDoctor.SelectedItem.ToString(),
                Reason = txtReason.Text.Trim(),
                Status = cboStatus.SelectedItem.ToString()
            };

            originalList.Add(newApp);
            ApplyFilter();
            ClearFormInputs();
            MessageBox.Show("Thêm lịch hẹn mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần cập nhật từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs(isAddingNew: false)) return;

            var selectedApp = dgvAppointments.CurrentRow.DataBoundItem as Appointment;
            if (selectedApp != null)
            {
                selectedApp.PatientName = txtName.Text.Trim();
                selectedApp.Phone = txtPhone.Text.Trim();
                selectedApp.AppointmentDate = dtpAppointmentDate.Value;
                selectedApp.Doctor = cboDoctor.SelectedItem.ToString();
                selectedApp.Reason = txtReason.Text.Trim();
                selectedApp.Status = cboStatus.SelectedItem.ToString();

                bindingSource.ResetBindings(false);
                ApplyFilter();
                MessageBox.Show("Cập nhật thông tin lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedApp = dgvAppointments.CurrentRow.DataBoundItem as Appointment;
            if (selectedApp != null)
            {
                var confirmResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa lịch hẹn mã '{selectedApp.Id}' của bệnh nhân '{selectedApp.PatientName}'?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    originalList.Remove(selectedApp);
                    ApplyFilter();
                    ClearFormInputs();
                    MessageBox.Show("Xóa lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Tìm kiếm tức thời & Bộ lọc
        private void ApplyFilter()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cboFilterStatus.SelectedItem?.ToString() ?? "Tất cả";
            bool filterByDate = chkFilterDate.Checked;
            DateTime targetDate = dtpFilterDate.Value.Date;

            var query = originalList.AsEnumerable();

            // Lọc theo từ khóa (Tên hoặc Số điện thoại)
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(a => a.PatientName.ToLower().Contains(keyword) || a.Phone.Contains(keyword));
            }

            // Lọc theo Trạng thái
            if (selectedStatus != "Tất cả")
            {
                query = query.Where(a => a.Status == selectedStatus);
            }

            // Lọc theo Ngày hẹn
            if (filterByDate)
            {
                query = query.Where(a => a.AppointmentDate.Date == targetDate);
            }

            filteredList.Clear();
            foreach (var item in query)
            {
                filteredList.Add(item);
            }

            // Cập nhật số lượng trên StatusStrip
            lblStatusCount.Text = $"Tổng số lịch hẹn hiển thị: {filteredList.Count}";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();
        private void dtpFilterDate_ValueChanged(object sender, EventArgs e) => ApplyFilter();
        private void chkFilterDate_CheckedChanged(object sender, EventArgs e) => ApplyFilter();
        #endregion

        #region Xử lý Chọn dòng & Làm mới
        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow != null && dgvAppointments.CurrentRow.DataBoundItem is Appointment app)
            {
                txtId.Text = app.Id;
                txtId.ReadOnly = true; // Khóa Mã lịch hẹn khi chọn sửa
                txtName.Text = app.PatientName;
                txtPhone.Text = app.Phone;
                dtpAppointmentDate.Value = app.AppointmentDate > DateTime.Now ? app.AppointmentDate : DateTime.Now;
                cboDoctor.SelectedItem = app.Doctor;
                txtReason.Text = app.Reason;
                cboStatus.SelectedItem = app.Status;

                errorProvider1.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormInputs();
        }

        private void ClearFormInputs()
        {
            txtId.ReadOnly = false;
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            dtpAppointmentDate.Value = DateTime.Now.AddHours(1);
            txtReason.Clear();
            if (cboDoctor.Items.Count > 0) cboDoctor.SelectedIndex = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            dgvAppointments.ClearSelection();
            errorProvider1.Clear();
        }
        #endregion

        #region MenuStrip: Xuất CSV
        private void mnuExportCSV_Click(object sender, EventArgs e)
        {
            if (filteredList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong danh sách hiện tại để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv";
                sfd.FileName = $"DanhSachLichHen_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Mã lịch hẹn,Họ tên bệnh nhân,Số điện thoại,Ngày giờ hẹn,Bác sĩ,Lý do khám,Trạng thái");

                        foreach (var item in filteredList)
                        {
                            sb.AppendLine($"\"{item.Id}\",\"{item.PatientName}\",\"{item.Phone}\",\"{item.AppointmentDate:dd/MM/yyyy HH:mm}\",\"{item.Doctor}\",\"{item.Reason}\",\"{item.Status}\"");
                        }

                        // Ghi file với Encoding UTF8 có BOM để Excel mở tiếng Việt không lỗi font
                        File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
                        MessageBox.Show("Xuất danh sách ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
    }

    // Class Model dữ liệu đặt ở cuối file Form1.cs
    public class Appointment
    {
        public string Id { get; set; }
        public string PatientName { get; set; }
        public string Phone { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Doctor { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
    }
}