namespace Bai4._11_Quanlydondangkydichvusuchua
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalUnfinishedCost = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelInput = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.cboDeviceType = new System.Windows.Forms.ComboBox();
            this.lblReceivedDate = new System.Windows.Forms.Label();
            this.dtpReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.lblEstimatedCost = new System.Windows.Forms.Label();
            this.txtEstimatedCost = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblErrorDescription = new System.Windows.Forms.Label();
            this.txtErrorDescription = new System.Windows.Forms.TextBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.picDeviceImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelFilter = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrorDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstimatedCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.tableLayoutPanelInput.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeviceImage)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.tableLayoutPanelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportCSV,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(55, 20);
            this.mnuFile.Text = "Tập tin";
            // 
            // mnuExportCSV
            // 
            this.mnuExportCSV.Name = "mnuExportCSV";
            this.mnuExportCSV.Size = new System.Drawing.Size(180, 22);
            this.mnuExportCSV.Text = "Xuất danh sách CSV";
            this.mnuExportCSV.Click += new System.EventHandler(this.mnuExportCSV_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Thoát ứng dụng";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusCount,
            this.lblTotalUnfinishedCost});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // lblStatusCount
            // 
            this.lblStatusCount.Name = "lblStatusCount";
            this.lblStatusCount.Size = new System.Drawing.Size(114, 17);
            this.lblStatusCount.Text = "Số đơn hiển thị: 0";
            // 
            // lblTotalUnfinishedCost
            // 
            this.lblTotalUnfinishedCost.Margin = new System.Windows.Forms.Padding(25, 3, 0, 2);
            this.lblTotalUnfinishedCost.Name = "lblTotalUnfinishedCost";
            this.lblTotalUnfinishedCost.Size = new System.Drawing.Size(250, 17);
            this.lblTotalUnfinishedCost.Text = "Tổng chi phí đơn chưa hoàn tất: 0 VNĐ";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.grpInput, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.grpFilter, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dgvOrders, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1008, 615);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.tableLayoutPanelInput);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(10, 5);
            this.grpInput.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(988, 250);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông Tin Đơn Đăng Ký Sửa Chữa";
            // 
            // tableLayoutPanelInput
            // 
            this.tableLayoutPanelInput.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanelInput.ColumnCount = 7;
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelInput.Controls.Add(this.lblOrderId, 0, 0);
            this.tableLayoutPanelInput.Controls.Add(this.txtOrderId, 1, 0);
            this.tableLayoutPanelInput.Controls.Add(this.lblCustomerName, 2, 0);
            this.tableLayoutPanelInput.Controls.Add(this.txtCustomerName, 3, 0);
            this.tableLayoutPanelInput.Controls.Add(this.lblPhone, 4, 0);
            this.tableLayoutPanelInput.Controls.Add(this.txtPhone, 5, 0);
            this.tableLayoutPanelInput.Controls.Add(this.lblDeviceType, 0, 1);
            this.tableLayoutPanelInput.Controls.Add(this.cboDeviceType, 1, 1);
            this.tableLayoutPanelInput.Controls.Add(this.lblReceivedDate, 2, 1);
            this.tableLayoutPanelInput.Controls.Add(this.dtpReceivedDate, 3, 1);
            this.tableLayoutPanelInput.Controls.Add(this.lblEstimatedCost, 4, 1);
            this.tableLayoutPanelInput.Controls.Add(this.txtEstimatedCost, 5, 1);
            this.tableLayoutPanelInput.Controls.Add(this.lblStatus, 0, 2);
            this.tableLayoutPanelInput.Controls.Add(this.cboStatus, 1, 2);
            this.tableLayoutPanelInput.Controls.Add(this.lblErrorDescription, 0, 3);
            this.tableLayoutPanelInput.Controls.Add(this.txtErrorDescription, 1, 3);
            this.tableLayoutPanelInput.Controls.Add(this.panelImage, 6, 0);
            this.tableLayoutPanelInput.Controls.Add(this.panelButtons, 0, 4);
            this.tableLayoutPanelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInput.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelInput.Name = "tableLayoutPanelInput";
            this.tableLayoutPanelInput.RowCount = 5;
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelInput.Size = new System.Drawing.Size(982, 228);
            this.tableLayoutPanelInput.TabIndex = 0;
            // 
            // lblOrderId
            // 
            this.lblOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(3, 9);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(51, 15);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Mã đơn:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderId.Location = new System.Drawing.Point(103, 5);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(158, 23);
            this.txtOrderId.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(267, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(93, 15);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Tên khách hàng:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Location = new System.Drawing.Point(367, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(158, 23);
            this.txtCustomerName.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(531, 9);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(79, 15);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(641, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(158, 23);
            this.txtPhone.TabIndex = 5;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Location = new System.Drawing.Point(3, 43);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(71, 15);
            this.lblDeviceType.TabIndex = 6;
            this.lblDeviceType.Text = "Loại thiết bị:";
            // 
            // cboDeviceType
            // 
            this.cboDeviceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeviceType.FormattingEnabled = true;
            this.cboDeviceType.Location = new System.Drawing.Point(103, 39);
            this.cboDeviceType.Name = "cboDeviceType";
            this.cboDeviceType.Size = new System.Drawing.Size(158, 23);
            this.cboDeviceType.TabIndex = 7;
            // 
            // lblReceivedDate
            // 
            this.lblReceivedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReceivedDate.AutoSize = true;
            this.lblReceivedDate.Location = new System.Drawing.Point(267, 43);
            this.lblReceivedDate.Name = "lblReceivedDate";
            this.lblReceivedDate.Size = new System.Drawing.Size(88, 15);
            this.lblReceivedDate.TabIndex = 8;
            this.lblReceivedDate.Text = "Ngày tiếp nhận:";
            // 
            // dtpReceivedDate
            // 
            this.dtpReceivedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReceivedDate.Location = new System.Drawing.Point(367, 39);
            this.dtpReceivedDate.Name = "dtpReceivedDate";
            this.dtpReceivedDate.Size = new System.Drawing.Size(158, 23);
            this.dtpReceivedDate.TabIndex = 9;
            // 
            // lblEstimatedCost
            // 
            this.lblEstimatedCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstimatedCost.AutoSize = true;
            this.lblEstimatedCost.Location = new System.Drawing.Point(531, 43);
            this.lblEstimatedCost.Name = "lblEstimatedCost";
            this.lblEstimatedCost.Size = new System.Drawing.Size(95, 15);
            this.lblEstimatedCost.TabIndex = 10;
            this.lblEstimatedCost.Text = "Chi phí dự kiến:";
            // 
            // txtEstimatedCost
            // 
            this.txtEstimatedCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstimatedCost.Location = new System.Drawing.Point(641, 39);
            this.txtEstimatedCost.Name = "txtEstimatedCost";
            this.txtEstimatedCost.Size = new System.Drawing.Size(158, 23);
            this.txtEstimatedCost.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 15);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Trạng thái:";
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(103, 73);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(158, 23);
            this.cboStatus.TabIndex = 13;
            // 
            // lblErrorDescription
            // 
            this.lblErrorDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorDescription.AutoSize = true;
            this.lblErrorDescription.Location = new System.Drawing.Point(3, 129);
            this.lblErrorDescription.Name = "lblErrorDescription";
            this.lblErrorDescription.Size = new System.Drawing.Size(67, 15);
            this.lblErrorDescription.TabIndex = 14;
            this.lblErrorDescription.Text = "Mô tả lỗi:";
            // 
            // txtErrorDescription
            // 
            this.tableLayoutPanelInput.SetColumnSpan(this.txtErrorDescription, 5);
            this.txtErrorDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtErrorDescription.Location = new System.Drawing.Point(103, 105);
            this.txtErrorDescription.Multiline = true;
            this.txtErrorDescription.Name = "txtErrorDescription";
            this.txtErrorDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErrorDescription.Size = new System.Drawing.Size(696, 64);
            this.txtErrorDescription.TabIndex = 15;
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.picDeviceImage);
            this.panelImage.Controls.Add(this.btnBrowseImage);
            this.panelImage.Controls.Add(this.btnRemoveImage);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(805, 3);
            this.panelImage.Name = "panelImage";
            this.tableLayoutPanelInput.SetRowSpan(this.panelImage, 4);
            this.panelImage.Size = new System.Drawing.Size(174, 166);
            this.panelImage.TabIndex = 16;
            // 
            // picDeviceImage
            // 
            this.picDeviceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDeviceImage.Location = new System.Drawing.Point(3, 3);
            this.picDeviceImage.Name = "picDeviceImage";
            this.picDeviceImage.Size = new System.Drawing.Size(168, 125);
            this.picDeviceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDeviceImage.TabIndex = 0;
            this.picDeviceImage.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(3, 134);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(80, 26);
            this.btnBrowseImage.TabIndex = 1;
            this.btnBrowseImage.Text = "Chọn ảnh";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Location = new System.Drawing.Point(91, 134);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(80, 26);
            this.btnRemoveImage.TabIndex = 2;
            this.btnRemoveImage.Text = "Xóa ảnh";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // panelButtons
            // 
            this.tableLayoutPanelInput.SetColumnSpan(this.panelButtons, 7);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnUpdate);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(579, 175);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(400, 50);
            this.panelButtons.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm đơn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(99, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 32);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(195, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa đơn";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(291, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.tableLayoutPanelFilter);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilter.Location = new System.Drawing.Point(10, 265);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(988, 50);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Tìm Kiếm && Bộ Lọc";
            // 
            // tableLayoutPanelFilter
            // 
            this.tableLayoutPanelFilter.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanelFilter.ColumnCount = 4;
            this.tableLayoutPanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelFilter.Controls.Add(this.lblSearch, 0, 0);
            this.tableLayoutPanelFilter.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanelFilter.Controls.Add(this.lblFilterStatus, 2, 0);
            this.tableLayoutPanelFilter.Controls.Add(this.cboFilterStatus, 3, 0);
            this.tableLayoutPanelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFilter.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelFilter.Name = "tableLayoutPanelFilter";
            this.tableLayoutPanelFilter.RowCount = 1;
            this.tableLayoutPanelFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFilter.Size = new System.Drawing.Size(982, 28);
            this.tableLayoutPanelFilter.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 6);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(142, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm (Mã đơn/Tên KH/SĐT):";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(153, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(427, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Location = new System.Drawing.Point(586, 6);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(84, 15);
            this.lblFilterStatus.TabIndex = 2;
            this.lblFilterStatus.Text = "Lọc trạng thái:";
            // 
            // cboFilterStatus
            // 
            this.cboFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Location = new System.Drawing.Point(696, 3);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(283, 23);
            this.cboFilterStatus.TabIndex = 3;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cboFilterStatus_SelectedIndexChanged);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderId,
            this.colCustomerName,
            this.colPhone,
            this.colDeviceType,
            this.colErrorDescription,
            this.colReceivedDate,
            this.colEstimatedCost,
            this.colStatus});
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(10, 325);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(988, 280);
            this.dgvOrders.TabIndex = 2;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // colOrderId
            // 
            this.colOrderId.DataPropertyName = "OrderId";
            this.colOrderId.HeaderText = "Mã Đơn";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.ReadOnly = true;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "CustomerName";
            this.colCustomerName.HeaderText = "Tên Khách Hàng";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Số Điện Thoại";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colDeviceType
            // 
            this.colDeviceType.DataPropertyName = "DeviceType";
            this.colDeviceType.HeaderText = "Loại Thiết Bị";
            this.colDeviceType.Name = "colDeviceType";
            this.colDeviceType.ReadOnly = true;
            // 
            // colErrorDescription
            // 
            this.colErrorDescription.DataPropertyName = "ErrorDescription";
            this.colErrorDescription.HeaderText = "Mô Tả Lỗi";
            this.colErrorDescription.Name = "colErrorDescription";
            this.colErrorDescription.ReadOnly = true;
            // 
            // colReceivedDate
            // 
            this.colReceivedDate.DataPropertyName = "ReceivedDate";
            this.colReceivedDate.HeaderText = "Ngày Tiếp Nhận";
            this.colReceivedDate.Name = "colReceivedDate";
            this.colReceivedDate.ReadOnly = true;
            // 
            // colEstimatedCost
            // 
            this.colEstimatedCost.DataPropertyName = "EstimatedCost";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.colEstimatedCost.DefaultCellStyle = dataGridViewCellStyle1;
            this.colEstimatedCost.HeaderText = "Chi Phí Dự Kiến (VNĐ)";
            this.colEstimatedCost.Name = "colEstimatedCost";
            this.colEstimatedCost.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Trạng Thái";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repair Service Tracker - Quản Lý Đơn Dịch Vụ Sửa Chữa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.tableLayoutPanelInput.ResumeLayout(false);
            this.tableLayoutPanelInput.PerformLayout();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDeviceImage)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.tableLayoutPanelFilter.ResumeLayout(false);
            this.tableLayoutPanelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExportCSV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCount;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalUnfinishedCost;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.ComboBox cboDeviceType;
        private System.Windows.Forms.Label lblReceivedDate;
        private System.Windows.Forms.DateTimePicker dtpReceivedDate;
        private System.Windows.Forms.Label lblEstimatedCost;
        private System.Windows.Forms.TextBox txtEstimatedCost;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblErrorDescription;
        private System.Windows.Forms.TextBox txtErrorDescription;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox picDeviceImage;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrorDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstimatedCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}