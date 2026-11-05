using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai4._11_Quanlydondangkydichvusuchua
{
    public partial class Form1 : Form
    {
        private BindingList<RepairOrder> originalList = new BindingList<RepairOrder>();
        private BindingList<RepairOrder> filteredList = new BindingList<RepairOrder>();
        private BindingSource bindingSource = new BindingSource();
        private string selectedImagePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            SetupControlsAndData();
        }

        private void SetupControlsAndData()
        {
            // 1. Cấu hình DataGridView
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;

            // 2. Khởi tạo danh sách Loại thiết bị
            cboDeviceType.Items.AddRange(new object[] {
                "Điện thoại thông minh",
                "Máy tính xách tay (Laptop)",
                "Máy tính bảng",
                "Màn hình / TV",
                "Thiết bị âm thanh",
                "Thiết bị khác"
            });
            if (cboDeviceType.Items.Count > 0) cboDeviceType.SelectedIndex = 0;

            // 3. Khởi tạo ComboBox Trạng thái đơn nhập
            cboStatus.Items.AddRange(new object[] {
                "Mới tiếp nhận",
                "Đang sửa",
                "Chờ linh kiện",
                "Hoàn tất",
                "Đã hủy"
            });
            cboStatus.SelectedIndex = 0;

            // 4. Khởi tạo ComboBox Bộ lọc trạng thái
            cboFilterStatus.Items.AddRange(new object[] {
                "Tất cả",
                "Mới tiếp nhận",
                "Đang sửa",
                "Chờ linh kiện",
                "Hoàn tất",
                "Đã hủy"
            });
            cboFilterStatus.SelectedIndex = 0;

            // 5. Định dạng DateTimePicker
            dtpReceivedDate.Format = DateTimePickerFormat.Custom;
            dtpReceivedDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpReceivedDate.Value = DateTime.Now;

            // 6. Cấu hình PictureBox
            picDeviceImage.SizeMode = PictureBoxSizeMode.Zoom;

            // 7. Gán DataBinding
            bindingSource.DataSource = filteredList;
            dgvOrders.DataSource = bindingSource;

            // 8. Tạo dữ liệu mẫu và nạp bảng
            SeedSampleData();
            ApplyFilter();
        }

        private void SeedSampleData()
        {
            originalList.Add(new RepairOrder
            {
                OrderId = "HD001",
                CustomerName = "Lê Văn Cường",
                Phone = "0934567890",
                DeviceType = "Điện thoại thông minh",
                ErrorDescription = "Vỡ màn hình cảm ứng, pin vồng nhẹ",
                ReceivedDate = DateTime.Now.AddDays(-2),
                EstimatedCost = 1500000,
                Status = "Mới tiếp nhận",
                ImagePath = string.Empty
            });

            originalList.Add(new RepairOrder
            {
                OrderId = "HD002",
                CustomerName = "Phạm Thi Mai",
                Phone = "0978123456",
                DeviceType = "Máy tính xách tay (Laptop)",
                ErrorDescription = "Không lên nguồn, quạt kêu to",
                ReceivedDate = DateTime.Now.AddDays(-5),
                EstimatedCost = 850000,
                Status = "Đang sửa",
                ImagePath = string.Empty
            });
        }

        #region Validation (Kiểm tra dữ liệu)
        private bool ValidateInputs(bool isAddingNew)
        {
            errorProvider1.Clear();
            bool isValid = true;

            // 1. Kiểm tra Mã đơn
            string orderId = txtOrderId.Text.Trim();
            if (string.IsNullOrEmpty(orderId))
            {
                errorProvider1.SetError(txtOrderId, "Mã đơn không được để trống.");
                isValid = false;
            }
            else if (isAddingNew && originalList.Any(o => o.OrderId.Equals(orderId, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtOrderId, "Mã đơn đã tồn tại.");
                isValid = false;
            }

            // 2. Kiểm tra Tên khách hàng
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                errorProvider1.SetError(txtCustomerName, "Tên khách hàng không được để trống.");
                isValid = false;
            }

            // 3. Kiểm tra Số điện thoại
            string phonePattern = @"^0\d{9}$";
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại không được để trống.");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtPhone.Text.Trim(), phonePattern))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại không hợp lệ (10 chữ số, bắt đầu bằng 0).");
                isValid = false;
            }

            // 4. Kiểm tra Mô tả lỗi bắt buộc
            if (string.IsNullOrWhiteSpace(txtErrorDescription.Text))
            {
                errorProvider1.SetError(txtErrorDescription, "Mô tả lỗi bắt buộc phải nhập.");
                isValid = false;
            }

            // 5. Kiểm tra Chi phí dự kiến là số không âm
            if (string.IsNullOrWhiteSpace(txtEstimatedCost.Text))
            {
                errorProvider1.SetError(txtEstimatedCost, "Chi phí dự kiến không được để trống.");
                isValid = false;
            }
            else if (!decimal.TryParse(txtEstimatedCost.Text.Trim(), out decimal cost) || cost < 0)
            {
                errorProvider1.SetError(txtEstimatedCost, "Chi phí dự kiến phải là số không âm (>= 0).");
                isValid = false;
            }

            return isValid;
        }
        #endregion

        #region CRUD & Xử lý Ảnh
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Tệp hình ảnh (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Chọn ảnh thiết bị sửa chữa";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    LoadImageToPictureBox(selectedImagePath);
                }
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            selectedImagePath = string.Empty;
            if (picDeviceImage.Image != null)
            {
                picDeviceImage.Image.Dispose();
                picDeviceImage.Image = null;
            }
        }

        private void LoadImageToPictureBox(string path)
        {
            if (picDeviceImage.Image != null)
            {
                picDeviceImage.Image.Dispose();
                picDeviceImage.Image = null;
            }

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    picDeviceImage.Image = Image.FromStream(stream);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(isAddingNew: true)) return;

            var newOrder = new RepairOrder
            {
                OrderId = txtOrderId.Text.Trim(),
                CustomerName = txtCustomerName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                DeviceType = cboDeviceType.SelectedItem.ToString(),
                ErrorDescription = txtErrorDescription.Text.Trim(),
                ReceivedDate = dtpReceivedDate.Value,
                EstimatedCost = decimal.Parse(txtEstimatedCost.Text.Trim()),
                Status = cboStatus.SelectedItem.ToString(),
                ImagePath = selectedImagePath
            };

            originalList.Add(newOrder);
            ApplyFilter();
            ClearFormInputs();
            MessageBox.Show("Thêm đơn sửa chữa mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn sửa chữa cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs(isAddingNew: false)) return;

            var selectedOrder = dgvOrders.CurrentRow.DataBoundItem as RepairOrder;
            if (selectedOrder != null)
            {
                selectedOrder.CustomerName = txtCustomerName.Text.Trim();
                selectedOrder.Phone = txtPhone.Text.Trim();
                selectedOrder.DeviceType = cboDeviceType.SelectedItem.ToString();
                selectedOrder.ErrorDescription = txtErrorDescription.Text.Trim();
                selectedOrder.ReceivedDate = dtpReceivedDate.Value;
                selectedOrder.EstimatedCost = decimal.Parse(txtEstimatedCost.Text.Trim());
                selectedOrder.Status = cboStatus.SelectedItem.ToString();
                selectedOrder.ImagePath = selectedImagePath;

                bindingSource.ResetBindings(false);
                ApplyFilter();
                MessageBox.Show("Cập nhật đơn sửa chữa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn sửa chữa cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedOrder = dgvOrders.CurrentRow.DataBoundItem as RepairOrder;
            if (selectedOrder != null)
            {
                var confirmResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa đơn sửa chữa mã '{selectedOrder.OrderId}' của KH '{selectedOrder.CustomerName}'?",
                    "Xác nhận xóa đơn",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    originalList.Remove(selectedOrder);
                    ApplyFilter();
                    ClearFormInputs();
                    MessageBox.Show("Xóa đơn sửa chữa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Lọc, Tìm kiếm & Thống kê StatusStrip
        private void ApplyFilter()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cboFilterStatus.SelectedItem?.ToString() ?? "Tất cả";

            var query = originalList.AsEnumerable();

            // Tìm kiếm tức thời theo mã đơn, tên KH hoặc SĐT
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(o => o.OrderId.ToLower().Contains(keyword) ||
                                         o.CustomerName.ToLower().Contains(keyword) ||
                                         o.Phone.Contains(keyword));
            }

            // Lọc theo trạng thái
            if (selectedStatus != "Tất cả")
            {
                query = query.Where(o => o.Status == selectedStatus);
            }

            filteredList.Clear();
            foreach (var item in query)
            {
                filteredList.Add(item);
            }

            // Tính tổng chi phí dự kiến các đơn CHƯA hoàn tất (trạng thái != "Hoàn tất")
            decimal unfinishedTotalCost = filteredList.Where(o => o.Status != "Hoàn tất").Sum(o => o.EstimatedCost);

            lblStatusCount.Text = $"Số đơn hiển thị: {filteredList.Count}";
            lblTotalUnfinishedCost.Text = $"Tổng chi phí đơn chưa hoàn tất: {unfinishedTotalCost:N0} VNĐ";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();
        #endregion

        #region Chọn dòng & Làm mới
        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null && dgvOrders.CurrentRow.DataBoundItem is RepairOrder order)
            {
                txtOrderId.Text = order.OrderId;
                txtOrderId.ReadOnly = true;
                txtCustomerName.Text = order.CustomerName;
                txtPhone.Text = order.Phone;
                cboDeviceType.SelectedItem = order.DeviceType;
                txtErrorDescription.Text = order.ErrorDescription;
                dtpReceivedDate.Value = order.ReceivedDate;
                txtEstimatedCost.Text = order.EstimatedCost.ToString("G0");
                cboStatus.SelectedItem = order.Status;

                selectedImagePath = order.ImagePath;
                LoadImageToPictureBox(selectedImagePath);

                errorProvider1.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormInputs();
        }

        private void ClearFormInputs()
        {
            txtOrderId.ReadOnly = false;
            txtOrderId.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
            if (cboDeviceType.Items.Count > 0) cboDeviceType.SelectedIndex = 0;
            txtErrorDescription.Clear();
            dtpReceivedDate.Value = DateTime.Now;
            txtEstimatedCost.Clear();
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;

            btnRemoveImage_Click(null, null);
            dgvOrders.ClearSelection();
            errorProvider1.Clear();
        }
        #endregion

        #region MenuStrip: Xuất CSV & Thoát
        private void mnuExportCSV_Click(object sender, EventArgs e)
        {
            if (filteredList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu đơn sửa chữa để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv";
                sfd.FileName = $"DanhSachDonSuaChua_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Mã đơn,Tên khách hàng,Số điện thoại,Loại thiết bị,Mô tả lỗi,Ngày tiếp nhận,Chi phí dự kiến,Trạng thái");

                        foreach (var item in filteredList)
                        {
                            sb.AppendLine($"\"{item.OrderId}\",\"{item.CustomerName}\",\"{item.Phone}\",\"{item.DeviceType}\",\"{item.ErrorDescription.Replace("\r\n", " ")}\",\"{item.ReceivedDate:dd/MM/yyyy HH:mm}\",\"{item.EstimatedCost}\",\"{item.Status}\"");
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
                        MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }

    public class RepairOrder
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string DeviceType { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime ReceivedDate { get; set; }
        public decimal EstimatedCost { get; set; }
        public string Status { get; set; }
        public string ImagePath { get; set; }
    }
}