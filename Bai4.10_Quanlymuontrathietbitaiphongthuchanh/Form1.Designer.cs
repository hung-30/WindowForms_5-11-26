namespace Bai4._10_Quanlymuontrathietbitaiphongthuchanh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusOverdue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelInput = new System.Windows.Forms.TableLayoutPanel();
            this.lblTicketId = new System.Windows.Forms.Label();
            this.txtTicketId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.cboEquipment = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.chkHasReturned = new System.Windows.Forms.CheckBox();
            this.dtpActualReturnDate = new System.Windows.Forms.DateTimePicker();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelFilter = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.colTicketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActualReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.tableLayoutPanelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.tableLayoutPanelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportCSV});
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusTotal,
            this.lblStatusOverdue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 609);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // lblStatusTotal
            // 
            this.lblStatusTotal.Name = "lblStatusTotal";
            this.lblStatusTotal.Size = new System.Drawing.Size(124, 17);
            this.lblStatusTotal.Text = "Tổng số phiếu: 0";
            // 
            // lblStatusOverdue
            // 
            this.lblStatusOverdue.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.lblStatusOverdue.Name = "lblStatusOverdue";
            this.lblStatusOverdue.Size = new System.Drawing.Size(126, 17);
            this.lblStatusOverdue.Text = "Số phiếu quá hạn: 0";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.grpInput, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.grpFilter, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dgvTickets, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(984, 585);
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
            this.grpInput.Size = new System.Drawing.Size(964, 210);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông Tin Phiếu Mượn Thiết Bị";
            // 
            // tableLayoutPanelInput
            // 
            this.tableLayoutPanelInput.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanelInput.ColumnCount = 6;
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInput.Controls.Add(this.lblTicketId, 0, 0);
            this.tableLayoutPanelInput.Controls.Add(this.txtTicketId, 1, 0);
            this.tableLayoutPanelInput.Controls.Add(this.lblStudentId, 2, 0);
            this.tableLayoutPanelInput.Controls.Add(this.txtStudentId, 3, 0);
            this.tableLayoutPanelInput.Controls.Add(this.lblStudentName, 4, 0);
            this.tableLayoutPanelInput.Controls.Add(this.txtStudentName, 5, 0);
            this.tableLayoutPanelInput.Controls.Add(this.lblEquipment, 0, 1);
            this.tableLayoutPanelInput.Controls.Add(this.cboEquipment, 1, 1);
            this.tableLayoutPanelInput.Controls.Add(this.lblQuantity, 4, 1);
            this.tableLayoutPanelInput.Controls.Add(this.numQuantity, 5, 1);
            this.tableLayoutPanelInput.Controls.Add(this.lblBorrowDate, 0, 2);
            this.tableLayoutPanelInput.Controls.Add(this.dtpBorrowDate, 1, 2);
            this.tableLayoutPanelInput.Controls.Add(this.lblDueDate, 2, 2);
            this.tableLayoutPanelInput.Controls.Add(this.dtpDueDate, 3, 2);
            this.tableLayoutPanelInput.Controls.Add(this.chkHasReturned, 4, 2);
            this.tableLayoutPanelInput.Controls.Add(this.dtpActualReturnDate, 5, 2);
            this.tableLayoutPanelInput.Controls.Add(this.panelButtons, 0, 3);
            this.tableLayoutPanelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInput.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelInput.Name = "tableLayoutPanelInput";
            this.tableLayoutPanelInput.RowCount = 4;
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelInput.Size = new System.Drawing.Size(958, 188);
            this.tableLayoutPanelInput.TabIndex = 0;
            // 
            // lblTicketId
            // 
            this.lblTicketId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Location = new System.Drawing.Point(3, 10);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(60, 15);
            this.lblTicketId.TabIndex = 0;
            this.lblTicketId.Text = "Mã phiếu:";
            // 
            // txtTicketId
            // 
            this.txtTicketId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTicketId.Location = new System.Drawing.Point(108, 6);
            this.txtTicketId.Name = "txtTicketId";
            this.txtTicketId.Size = new System.Drawing.Size(205, 23);
            this.txtTicketId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            this.lblStudentId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(319, 10);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(77, 15);
            this.lblStudentId.TabIndex = 2;
            this.lblStudentId.Text = "Mã sinh viên:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentId.Location = new System.Drawing.Point(424, 6);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(205, 23);
            this.txtStudentId.TabIndex = 3;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(635, 10);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(96, 15);
            this.lblStudentName.TabIndex = 4;
            this.lblStudentName.Text = "Họ tên sinh viên:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentName.Location = new System.Drawing.Point(750, 6);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(205, 23);
            this.txtStudentName.TabIndex = 5;
            // 
            // lblEquipment
            // 
            this.lblEquipment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(3, 46);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(49, 15);
            this.lblEquipment.TabIndex = 6;
            this.lblEquipment.Text = "Thiết bị:";
            // 
            // cboEquipment
            // 
            this.cboEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelInput.SetColumnSpan(this.cboEquipment, 3);
            this.cboEquipment.FormattingEnabled = true;
            this.cboEquipment.Location = new System.Drawing.Point(108, 42);
            this.cboEquipment.Name = "cboEquipment";
            this.cboEquipment.Size = new System.Drawing.Size(521, 23);
            this.cboEquipment.TabIndex = 7;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(635, 46);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(57, 15);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Số lượng:";
            // 
            // numQuantity
            // 
            this.numQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numQuantity.Location = new System.Drawing.Point(750, 42);
            this.numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(205, 23);
            this.numQuantity.TabIndex = 9;
            this.numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(3, 82);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(73, 15);
            this.lblBorrowDate.TabIndex = 10;
            this.lblBorrowDate.Text = "Ngày mượn:";
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBorrowDate.Location = new System.Drawing.Point(108, 78);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(205, 23);
            this.dtpBorrowDate.TabIndex = 11;
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(319, 82);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(49, 15);
            this.lblDueDate.TabIndex = 12;
            this.lblDueDate.Text = "Hạn trả:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDueDate.Location = new System.Drawing.Point(424, 78);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(205, 23);
            this.dtpDueDate.TabIndex = 13;
            // 
            // chkHasReturned
            // 
            this.chkHasReturned.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkHasReturned.AutoSize = true;
            this.chkHasReturned.Location = new System.Drawing.Point(635, 80);
            this.chkHasReturned.Name = "chkHasReturned";
            this.chkHasReturned.Size = new System.Drawing.Size(109, 19);
            this.chkHasReturned.TabIndex = 14;
            this.chkHasReturned.Text = "Ngày trả thực tế:";
            this.chkHasReturned.UseVisualStyleBackColor = true;
            this.chkHasReturned.CheckedChanged += new System.EventHandler(this.chkHasReturned_CheckedChanged);
            // 
            // dtpActualReturnDate
            // 
            this.dtpActualReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpActualReturnDate.Enabled = false;
            this.dtpActualReturnDate.Location = new System.Drawing.Point(750, 78);
            this.dtpActualReturnDate.Name = "dtpActualReturnDate";
            this.dtpActualReturnDate.Size = new System.Drawing.Size(205, 23);
            this.dtpActualReturnDate.TabIndex = 15;
            // 
            // panelButtons
            // 
            this.tableLayoutPanelInput.SetColumnSpan(this.panelButtons, 6);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnUpdate);
            this.panelButtons.Controls.Add(this.btnReturn);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(435, 111);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(520, 74);
            this.panelButtons.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm phiếu";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(104, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 32);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(205, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(105, 32);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Đánh dấu Đã trả";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(316, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa phiếu";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(417, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.tableLayoutPanelFilter);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilter.Location = new System.Drawing.Point(10, 225);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(964, 55);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Tìm Kiếm && Lọc Phiếu";
            // 
            // tableLayoutPanelFilter
            // 
            this.tableLayoutPanelFilter.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanelFilter.ColumnCount = 4;
            this.tableLayoutPanelFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
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
            this.tableLayoutPanelFilter.Size = new System.Drawing.Size(958, 33);
            this.tableLayoutPanelFilter.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(126, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm (Mã SV/Thiết bị):";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(143, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(418, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Location = new System.Drawing.Point(567, 9);
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
            this.cboFilterStatus.Location = new System.Drawing.Point(677, 5);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(278, 23);
            this.cboFilterStatus.TabIndex = 3;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cboFilterStatus_SelectedIndexChanged);
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTicketId,
            this.colStudentId,
            this.colStudentName,
            this.colEquipment,
            this.colQuantity,
            this.colBorrowDate,
            this.colDueDate,
            this.colActualReturnDate,
            this.colStatus});
            this.dgvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTickets.Location = new System.Drawing.Point(10, 290);
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.dgvTickets.MultiSelect = false;
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new System.Drawing.Size(964, 285);
            this.dgvTickets.TabIndex = 2;
            this.dgvTickets.SelectionChanged += new System.EventHandler(this.dgvTickets_SelectionChanged);
            // 
            // colTicketId
            // 
            this.colTicketId.DataPropertyName = "TicketId";
            this.colTicketId.HeaderText = "Mã Phiếu";
            this.colTicketId.Name = "colTicketId";
            this.colTicketId.ReadOnly = true;
            // 
            // colStudentId
            // 
            this.colStudentId.DataPropertyName = "StudentId";
            this.colStudentId.HeaderText = "Mã SV";
            this.colStudentId.Name = "colStudentId";
            this.colStudentId.ReadOnly = true;
            // 
            // colStudentName
            // 
            this.colStudentName.DataPropertyName = "StudentName";
            this.colStudentName.HeaderText = "Họ Tên SV";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            // 
            // colEquipment
            // 
            this.colEquipment.DataPropertyName = "Equipment";
            this.colEquipment.HeaderText = "Thiết Bị";
            this.colEquipment.Name = "colEquipment";
            this.colEquipment.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Số Lượng";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colBorrowDate
            // 
            this.colBorrowDate.DataPropertyName = "BorrowDate";
            this.colBorrowDate.HeaderText = "Ngày Mượn";
            this.colBorrowDate.Name = "colBorrowDate";
            this.colBorrowDate.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            this.colDueDate.HeaderText = "Hạn Trả";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colActualReturnDate
            // 
            this.colActualReturnDate.DataPropertyName = "ActualReturnDateDisplay";
            this.colActualReturnDate.HeaderText = "Ngày Trả Thực Tế";
            this.colActualReturnDate.Name = "colActualReturnDate";
            this.colActualReturnDate.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(984, 631);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Equipment Checkout - Quản Lý Mượn Trả Thiết Bị";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.tableLayoutPanelInput.ResumeLayout(false);
            this.tableLayoutPanelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.tableLayoutPanelFilter.ResumeLayout(false);
            this.tableLayoutPanelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExportCSV;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTotal;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusOverdue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput;
        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.ComboBox cboEquipment;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.CheckBox chkHasReturned;
        private System.Windows.Forms.DateTimePicker dtpActualReturnDate;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActualReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}