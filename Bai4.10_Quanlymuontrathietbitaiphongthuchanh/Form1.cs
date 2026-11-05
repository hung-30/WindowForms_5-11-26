using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai4._10_Quanlymuontrathietbitaiphongthuchanh
{
    public partial class Form1 : Form
    {
        private BindingList<LoanTicket> originalList = new BindingList<LoanTicket>();
        private BindingList<LoanTicket> filteredList = new BindingList<LoanTicket>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            SetupControlsAndData();
        }

        private void SetupControlsAndData()
        {
            // 1. Cấu hình DataGridView
            dgvTickets.AutoGenerateColumns = false;
            dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTickets.MultiSelect = false;

            // 2. Danh sách Thiết bị mẫu
            cboEquipment.Items.AddRange(new object[] {
                "Máy tính bảng iPad Pro",
                "Bộ vi điều khiển Arduino Uno",
                "Kính hiển vi quang học",
                "Máy đo xung Oscilloscope",
                "Bộ Kit Raspberry Pi 4",
                "Cảm biến nhiệt độ DHT11"
            });
            if (cboEquipment.Items.Count > 0) cboEquipment.SelectedIndex = 0;

            // 3. ComboBox Lọc trạng thái
            cboFilterStatus.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Quá hạn", "Đã trả" });
            cboFilterStatus.SelectedIndex = 0;

            // 4. Định dạng DateTimePicker
            dtpBorrowDate.Format = DateTimePickerFormat.Custom;
            dtpBorrowDate.CustomFormat = "dd/MM/yyyy";
            dtpBorrowDate.Value = DateTime.Now;

            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.CustomFormat = "dd/MM/yyyy";
            dtpDueDate.Value = DateTime.Now.AddDays(7); // Mặc định thời hạn 7 ngày

            dtpActualReturnDate.Format = DateTimePickerFormat.Custom;
            dtpActualReturnDate.CustomFormat = "dd/MM/yyyy";
            dtpActualReturnDate.Value = DateTime.Now;

            // 5. Gán DataBinding
            bindingSource.DataSource = filteredList;
            dgvTickets.DataSource = bindingSource;

            // 6. Nạp dữ liệu mẫu
            SeedSampleData();
            ApplyFilter();
        }

        private void SeedSampleData()
        {
            originalList.Add(new LoanTicket
            {
                TicketId = "PM001",
                StudentId = "SV202401",
                StudentName = "Nguyễn Văn Anh",
                Equipment = "Bộ Kit Raspberry Pi 4",
                Quantity = 2,
                BorrowDate = DateTime.Now.AddDays(-10),
                DueDate = DateTime.Now.AddDays(-3), // Đã quá hạn
                ActualReturnDate = null,
                Status = "Quá hạn"
            });

            originalList.Add(new LoanTicket
            {
                TicketId = "PM002",
                StudentId = "SV202402",
                StudentName = "Trần Thị Bình",
                Equipment = "Máy đo xung Oscilloscope",
                Quantity = 1,
                BorrowDate = DateTime.Now.AddDays(-2),
                DueDate = DateTime.Now.AddDays(5),
                ActualReturnDate = null,
                Status = "Đang mượn"
            });
        }

        #region Tự động tính toán & Cập nhật Trạng thái phiếu
        private void UpdateTicketStatuses()
        {
            foreach (var ticket in originalList)
            {
                if (ticket.Status != "Đã trả")
                {
                    if (ticket.DueDate.Date < DateTime.Now.Date)
                    {
                        ticket.Status = "Quá hạn";
                    }
                    else
                    {
                        ticket.Status = "Đang mượn";
                    }
                }
            }
        }
        #endregion

        #region Validation (Kiểm tra dữ liệu)
        private bool ValidateInputs(bool isAddingNew)
        {
            errorProvider1.Clear();
            bool isValid = true;

            // 1. Kiểm tra Mã phiếu
            string ticketId = txtTicketId.Text.Trim();
            if (string.IsNullOrEmpty(ticketId))
            {
                errorProvider1.SetError(txtTicketId, "Mã phiếu không được để trống.");
                isValid = false;
            }
            else if (isAddingNew && originalList.Any(t => t.TicketId.Equals(ticketId, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtTicketId, "Mã phiếu đã tồn tại.");
                isValid = false;
            }

            // 2. Kiểm tra Mã sinh viên
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                errorProvider1.SetError(txtStudentId, "Mã sinh viên không được để trống.");
                isValid = false;
            }

            // 3. Kiểm tra Họ tên sinh viên
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                errorProvider1.SetError(txtStudentName, "Họ tên sinh viên không được để trống.");
                isValid = false;
            }

            // 4. Kiểm tra Thiết bị
            if (cboEquipment.SelectedItem == null || string.IsNullOrWhiteSpace(cboEquipment.Text))
            {
                errorProvider1.SetError(cboEquipment, "Vui lòng chọn hoặc nhập tên thiết bị.");
                isValid = false;
            }

            // 5. Kiểm tra Số lượng > 0
            if (numQuantity.Value <= 0)
            {
                errorProvider1.SetError(numQuantity, "Số lượng mượn phải lớn hơn 0.");
                isValid = false;
            }

            // 6. Kiểm tra Hạn trả không trước ngày mượn
            if (dtpDueDate.Value.Date < dtpBorrowDate.Value.Date)
            {
                errorProvider1.SetError(dtpDueDate, "Hạn trả không được trước ngày mượn.");
                isValid = false;
            }

            // 7. Kiểm tra Ngày trả thực tế (nếu có chọn trả) không trước ngày mượn
            if (chkHasReturned.Checked && dtpActualReturnDate.Value.Date < dtpBorrowDate.Value.Date)
            {
                errorProvider1.SetError(dtpActualReturnDate, "Ngày trả thực tế không được trước ngày mượn.");
                isValid = false;
            }

            return isValid;
        }
        #endregion

        #region Chức năng CRUD & Đánh dấu đã trả
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(isAddingNew: true)) return;

            string status = "Đang mượn";
            DateTime? returnDate = null;

            if (chkHasReturned.Checked)
            {
                status = "Đã trả";
                returnDate = dtpActualReturnDate.Value.Date;
            }
            else if (dtpDueDate.Value.Date < DateTime.Now.Date)
            {
                status = "Quá hạn";
            }

            var ticket = new LoanTicket
            {
                TicketId = txtTicketId.Text.Trim(),
                StudentId = txtStudentId.Text.Trim(),
                StudentName = txtStudentName.Text.Trim(),
                Equipment = cboEquipment.SelectedItem.ToString(),
                Quantity = (int)numQuantity.Value,
                BorrowDate = dtpBorrowDate.Value.Date,
                DueDate = dtpDueDate.Value.Date,
                ActualReturnDate = returnDate,
                Status = status
            };

            originalList.Add(ticket);
            ApplyFilter();
            ClearFormInputs();
            MessageBox.Show("Thêm phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs(isAddingNew: false)) return;

            var ticket = dgvTickets.CurrentRow.DataBoundItem as LoanTicket;
            if (ticket != null)
            {
                ticket.StudentId = txtStudentId.Text.Trim();
                ticket.StudentName = txtStudentName.Text.Trim();
                ticket.Equipment = cboEquipment.SelectedItem.ToString();
                ticket.Quantity = (int)numQuantity.Value;
                ticket.BorrowDate = dtpBorrowDate.Value.Date;
                ticket.DueDate = dtpDueDate.Value.Date;

                if (chkHasReturned.Checked)
                {
                    ticket.Status = "Đã trả";
                    ticket.ActualReturnDate = dtpActualReturnDate.Value.Date;
                }
                else
                {
                    ticket.ActualReturnDate = null;
                    ticket.Status = (ticket.DueDate.Date < DateTime.Now.Date) ? "Quá hạn" : "Đang mượn";
                }

                bindingSource.ResetBindings(false);
                ApplyFilter();
                MessageBox.Show("Cập nhật phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần đánh dấu trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ticket = dgvTickets.CurrentRow.DataBoundItem as LoanTicket;
            if (ticket != null)
            {
                if (ticket.Status == "Đã trả")
                {
                    MessageBox.Show("Phiếu này đã được hoàn trả trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ticket.Status = "Đã trả";
                ticket.ActualReturnDate = DateTime.Now.Date;

                bindingSource.ResetBindings(false);
                ApplyFilter();
                chkHasReturned.Checked = true;
                dtpActualReturnDate.Value = DateTime.Now;

                MessageBox.Show($"Đã xác nhận sinh viên '{ticket.StudentName}' trả thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ticket = dgvTickets.CurrentRow.DataBoundItem as LoanTicket;
            if (ticket != null)
            {
                var result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa phiếu mượn '{ticket.TicketId}' của SV '{ticket.StudentName}'?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    originalList.Remove(ticket);
                    ApplyFilter();
                    ClearFormInputs();
                    MessageBox.Show("Xóa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Lọc & Tìm kiếm & StatusStrip
        private void ApplyFilter()
        {
            UpdateTicketStatuses();

            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cboFilterStatus.SelectedItem?.ToString() ?? "Tất cả";

            var query = originalList.AsEnumerable();

            // Tìm theo Mã sinh viên hoặc Tên thiết bị
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(t => t.StudentId.ToLower().Contains(keyword) ||
                                         t.Equipment.ToLower().Contains(keyword) ||
                                         t.StudentName.ToLower().Contains(keyword));
            }

            // Lọc theo trạng thái
            if (selectedStatus != "Tất cả")
            {
                query = query.Where(t => t.Status == selectedStatus);
            }

            filteredList.Clear();
            foreach (var item in query)
            {
                filteredList.Add(item);
            }

            // Đếm thống kê trên StatusStrip
            int totalCount = originalList.Count;
            int overdueCount = originalList.Count(t => t.Status == "Quá hạn");
            lblStatusTotal.Text = $"Tổng số phiếu: {totalCount}";
            lblStatusOverdue.Text = $"Số phiếu quá hạn: {overdueCount}";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();
        #endregion

        #region Selection Changed & Clear Form
        private void dgvTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow != null && dgvTickets.CurrentRow.DataBoundItem is LoanTicket ticket)
            {
                txtTicketId.Text = ticket.TicketId;
                txtTicketId.ReadOnly = true;
                txtStudentId.Text = ticket.StudentId;
                txtStudentName.Text = ticket.StudentName;
                cboEquipment.SelectedItem = ticket.Equipment;
                numQuantity.Value = ticket.Quantity;
                dtpBorrowDate.Value = ticket.BorrowDate;
                dtpDueDate.Value = ticket.DueDate;

                if (ticket.ActualReturnDate.HasValue)
                {
                    chkHasReturned.Checked = true;
                    dtpActualReturnDate.Value = ticket.ActualReturnDate.Value;
                }
                else
                {
                    chkHasReturned.Checked = false;
                    dtpActualReturnDate.Value = DateTime.Now;
                }

                errorProvider1.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormInputs();
        }

        private void ClearFormInputs()
        {
            txtTicketId.ReadOnly = false;
            txtTicketId.Clear();
            txtStudentId.Clear();
            txtStudentName.Clear();
            if (cboEquipment.Items.Count > 0) cboEquipment.SelectedIndex = 0;
            numQuantity.Value = 1;
            dtpBorrowDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(7);
            chkHasReturned.Checked = false;
            dtpActualReturnDate.Value = DateTime.Now;
            dgvTickets.ClearSelection();
            errorProvider1.Clear();
        }

        private void chkHasReturned_CheckedChanged(object sender, EventArgs e)
        {
            dtpActualReturnDate.Enabled = chkHasReturned.Checked;
        }
        #endregion

        #region MenuStrip: Xuất CSV
        private void mnuExportCSV_Click(object sender, EventArgs e)
        {
            if (filteredList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu phiếu mượn để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv";
                sfd.FileName = $"PhieuMuonThietBi_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Mã phiếu,Mã SV,Họ tên SV,Thiết bị,Số lượng,Ngày mượn,Hạn trả,Ngày trả thực tế,Trạng thái");

                        foreach (var item in filteredList)
                        {
                            string returnDateStr = item.ActualReturnDate.HasValue ? item.ActualReturnDate.Value.ToString("dd/MM/yyyy") : "";
                            sb.AppendLine($"\"{item.TicketId}\",\"{item.StudentId}\",\"{item.StudentName}\",\"{item.Equipment}\",\"{item.Quantity}\",\"{item.BorrowDate:dd/MM/yyyy}\",\"{item.DueDate:dd/MM/yyyy}\",\"{returnDateStr}\",\"{item.Status}\"");
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
                        MessageBox.Show("Xuất danh sách ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
    }

    // Class model dữ liệu đặt ở cuối file
    public class LoanTicket
    {
        public string TicketId { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Equipment { get; set; }
        public int Quantity { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public string Status { get; set; }

        public string ActualReturnDateDisplay => ActualReturnDate.HasValue ? ActualReturnDate.Value.ToString("dd/MM/yyyy") : "";
    }
}