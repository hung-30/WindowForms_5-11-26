namespace Bai4._9_Quanlylichhenphongkham
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuExportCSV = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatusCount = new ToolStripStatusLabel();
            tableLayoutPanelMain = new TableLayoutPanel();
            grpInput = new GroupBox();
            tableLayoutPanelInput = new TableLayoutPanel();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblDate = new Label();
            dtpAppointmentDate = new DateTimePicker();
            lblDoctor = new Label();
            cboDoctor = new ComboBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblReason = new Label();
            txtReason = new TextBox();
            panelButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            grpFilter = new GroupBox();
            tableLayoutPanelFilter = new TableLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblFilterStatus = new Label();
            cboFilterStatus = new ComboBox();
            chkFilterDate = new CheckBox();
            dtpFilterDate = new DateTimePicker();
            dgvAppointments = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colPatientName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAppointmentDate = new DataGridViewTextBoxColumn();
            colDoctor = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            grpInput.SuspendLayout();
            tableLayoutPanelInput.SuspendLayout();
            panelButtons.SuspendLayout();
            grpFilter.SuspendLayout();
            tableLayoutPanelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1280, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuExportCSV });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(69, 24);
            mnuFile.Text = "Tập tin";
            // 
            // mnuExportCSV
            // 
            mnuExportCSV.Name = "mnuExportCSV";
            mnuExportCSV.Size = new Size(222, 26);
            mnuExportCSV.Text = "Xuất danh sách CSV";
            mnuExportCSV.Click += mnuExportCSV_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusCount });
            statusStrip1.Location = new Point(0, 914);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 19, 0);
            statusStrip1.Size = new Size(1280, 26);
            statusStrip1.TabIndex = 1;
            // 
            // lblStatusCount
            // 
            lblStatusCount.Name = "lblStatusCount";
            lblStatusCount.Size = new Size(132, 20);
            lblStatusCount.Text = "Tổng số lịch hẹn: 0";
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(grpInput, 0, 0);
            tableLayoutPanelMain.Controls.Add(grpFilter, 0, 1);
            tableLayoutPanelMain.Controls.Add(dgvAppointments, 0, 2);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 30);
            tableLayoutPanelMain.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 292F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(1280, 884);
            tableLayoutPanelMain.TabIndex = 2;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(tableLayoutPanelInput);
            grpInput.Dock = DockStyle.Fill;
            grpInput.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpInput.Location = new Point(13, 8);
            grpInput.Margin = new Padding(13, 8, 13, 8);
            grpInput.Name = "grpInput";
            grpInput.Padding = new Padding(4, 5, 4, 5);
            grpInput.Size = new Size(1254, 276);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông Tin Lịch Hẹn";
            // 
            // tableLayoutPanelInput
            // 
            tableLayoutPanelInput.ColumnCount = 6;
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelInput.Controls.Add(lblId, 0, 0);
            tableLayoutPanelInput.Controls.Add(txtId, 1, 0);
            tableLayoutPanelInput.Controls.Add(lblName, 2, 0);
            tableLayoutPanelInput.Controls.Add(txtName, 3, 0);
            tableLayoutPanelInput.Controls.Add(lblPhone, 4, 0);
            tableLayoutPanelInput.Controls.Add(txtPhone, 5, 0);
            tableLayoutPanelInput.Controls.Add(lblDate, 0, 1);
            tableLayoutPanelInput.Controls.Add(dtpAppointmentDate, 1, 1);
            tableLayoutPanelInput.Controls.Add(lblDoctor, 2, 1);
            tableLayoutPanelInput.Controls.Add(cboDoctor, 3, 1);
            tableLayoutPanelInput.Controls.Add(lblStatus, 4, 1);
            tableLayoutPanelInput.Controls.Add(cboStatus, 5, 1);
            tableLayoutPanelInput.Controls.Add(lblReason, 0, 2);
            tableLayoutPanelInput.Controls.Add(txtReason, 1, 2);
            tableLayoutPanelInput.Controls.Add(panelButtons, 0, 3);
            tableLayoutPanelInput.Dock = DockStyle.Fill;
            tableLayoutPanelInput.Location = new Point(4, 25);
            tableLayoutPanelInput.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanelInput.Name = "tableLayoutPanelInput";
            tableLayoutPanelInput.RowCount = 4;
            tableLayoutPanelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanelInput.Size = new Size(1246, 246);
            tableLayoutPanelInput.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left;
            lblId.AutoSize = true;
            lblId.Location = new Point(4, 17);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(88, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Mã lịch hẹn:";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtId.Location = new Point(131, 13);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(280, 27);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.Location = new Point(419, 17);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(81, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Họ tên BN:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(546, 13);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 27);
            txtName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Left;
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(834, 17);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(961, 13);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(281, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(4, 71);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(101, 20);
            lblDate.TabIndex = 6;
            lblDate.Text = "Ngày giờ hẹn:";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpAppointmentDate.Location = new Point(131, 67);
            dtpAppointmentDate.Margin = new Padding(4, 5, 4, 5);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(280, 27);
            dtpAppointmentDate.TabIndex = 7;
            // 
            // lblDoctor
            // 
            lblDoctor.Anchor = AnchorStyles.Left;
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new Point(419, 71);
            lblDoctor.Margin = new Padding(4, 0, 4, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(50, 20);
            lblDoctor.TabIndex = 8;
            lblDoctor.Text = "Bác sĩ:";
            // 
            // cboDoctor
            // 
            cboDoctor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(546, 67);
            cboDoctor.Margin = new Padding(4, 5, 4, 5);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(280, 28);
            cboDoctor.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(834, 71);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(78, 20);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Trạng thái:";
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(961, 67);
            cboStatus.Margin = new Padding(4, 5, 4, 5);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(281, 28);
            cboStatus.TabIndex = 11;
            // 
            // lblReason
            // 
            lblReason.Anchor = AnchorStyles.Left;
            lblReason.AutoSize = true;
            lblReason.Location = new Point(4, 125);
            lblReason.Margin = new Padding(4, 0, 4, 0);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(87, 20);
            lblReason.TabIndex = 12;
            lblReason.Text = "Lý do khám:";
            // 
            // txtReason
            // 
            tableLayoutPanelInput.SetColumnSpan(txtReason, 5);
            txtReason.Dock = DockStyle.Fill;
            txtReason.Location = new Point(131, 113);
            txtReason.Margin = new Padding(4, 5, 4, 5);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(1111, 27);
            txtReason.TabIndex = 13;
            // 
            // panelButtons
            // 
            tableLayoutPanelInput.SetColumnSpan(panelButtons, 6);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnClear);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(709, 167);
            panelButtons.Margin = new Padding(4, 5, 4, 5);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(533, 74);
            panelButtons.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(4, 5);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 49);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(132, 5);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 49);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(260, 5);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 49);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(388, 5);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 49);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(tableLayoutPanelFilter);
            grpFilter.Dock = DockStyle.Fill;
            grpFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpFilter.Location = new Point(13, 300);
            grpFilter.Margin = new Padding(13, 8, 13, 8);
            grpFilter.Name = "grpFilter";
            grpFilter.Padding = new Padding(4, 5, 4, 5);
            grpFilter.Size = new Size(1254, 84);
            grpFilter.TabIndex = 1;
            grpFilter.TabStop = false;
            grpFilter.Text = "Tìm Kiếm && Bộ Lọc";
            // 
            // tableLayoutPanelFilter
            // 
            tableLayoutPanelFilter.ColumnCount = 6;
            tableLayoutPanelFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153F));
            tableLayoutPanelFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            tableLayoutPanelFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanelFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelFilter.Controls.Add(lblSearch, 0, 0);
            tableLayoutPanelFilter.Controls.Add(txtSearch, 1, 0);
            tableLayoutPanelFilter.Controls.Add(lblFilterStatus, 2, 0);
            tableLayoutPanelFilter.Controls.Add(cboFilterStatus, 3, 0);
            tableLayoutPanelFilter.Controls.Add(chkFilterDate, 4, 0);
            tableLayoutPanelFilter.Controls.Add(dtpFilterDate, 5, 0);
            tableLayoutPanelFilter.Dock = DockStyle.Fill;
            tableLayoutPanelFilter.Location = new Point(4, 25);
            tableLayoutPanelFilter.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanelFilter.Name = "tableLayoutPanelFilter";
            tableLayoutPanelFilter.RowCount = 1;
            tableLayoutPanelFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelFilter.Size = new Size(1246, 54);
            tableLayoutPanelFilter.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Left;
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(4, 17);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(131, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm (Tên/SĐT BN):";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(157, 13);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(312, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.Anchor = AnchorStyles.Left;
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Location = new Point(477, 17);
            lblFilterStatus.Margin = new Padding(4, 0, 4, 0);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(103, 20);
            lblFilterStatus.TabIndex = 2;
            lblFilterStatus.Text = "Lọc trạng thái:";
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(610, 13);
            cboFilterStatus.Margin = new Padding(4, 5, 4, 5);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(232, 28);
            cboFilterStatus.TabIndex = 3;
            cboFilterStatus.SelectedIndexChanged += cboFilterStatus_SelectedIndexChanged;
            // 
            // chkFilterDate
            // 
            chkFilterDate.Anchor = AnchorStyles.Left;
            chkFilterDate.AutoSize = true;
            chkFilterDate.Location = new Point(850, 15);
            chkFilterDate.Margin = new Padding(4, 5, 4, 5);
            chkFilterDate.Name = "chkFilterDate";
            chkFilterDate.Size = new Size(127, 24);
            chkFilterDate.TabIndex = 4;
            chkFilterDate.Text = "Lọc theo ngày:";
            chkFilterDate.UseVisualStyleBackColor = true;
            chkFilterDate.CheckedChanged += chkFilterDate_CheckedChanged;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFilterDate.Location = new Point(1010, 13);
            dtpFilterDate.Margin = new Padding(4, 5, 4, 5);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(232, 27);
            dtpFilterDate.TabIndex = 5;
            dtpFilterDate.ValueChanged += dtpFilterDate_ValueChanged;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Columns.AddRange(new DataGridViewColumn[] { colId, colPatientName, colPhone, colAppointmentDate, colDoctor, colReason, colStatus });
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(13, 400);
            dgvAppointments.Margin = new Padding(13, 8, 13, 15);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(1254, 469);
            dgvAppointments.TabIndex = 2;
            dgvAppointments.SelectionChanged += dgvAppointments_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Mã Lịch Hẹn";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colPatientName
            // 
            colPatientName.DataPropertyName = "PatientName";
            colPatientName.HeaderText = "Họ Tên Bệnh Nhân";
            colPatientName.MinimumWidth = 6;
            colPatientName.Name = "colPatientName";
            colPatientName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Số Điện Thoại";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colAppointmentDate
            // 
            colAppointmentDate.DataPropertyName = "AppointmentDate";
            colAppointmentDate.HeaderText = "Ngày Giờ Hẹn";
            colAppointmentDate.MinimumWidth = 6;
            colAppointmentDate.Name = "colAppointmentDate";
            colAppointmentDate.ReadOnly = true;
            // 
            // colDoctor
            // 
            colDoctor.DataPropertyName = "Doctor";
            colDoctor.HeaderText = "Bác Sĩ Khám";
            colDoctor.MinimumWidth = 6;
            colDoctor.Name = "colDoctor";
            colDoctor.ReadOnly = true;
            // 
            // colReason
            // 
            colReason.DataPropertyName = "Reason";
            colReason.HeaderText = "Lý Do Khám";
            colReason.MinimumWidth = 6;
            colReason.Name = "colReason";
            colReason.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Trạng Thái";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 940);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Appointment Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            tableLayoutPanelInput.ResumeLayout(false);
            tableLayoutPanelInput.PerformLayout();
            panelButtons.ResumeLayout(false);
            grpFilter.ResumeLayout(false);
            tableLayoutPanelFilter.ResumeLayout(false);
            tableLayoutPanelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExportCSV;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cboDoctor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
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
        private System.Windows.Forms.CheckBox chkFilterDate;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}