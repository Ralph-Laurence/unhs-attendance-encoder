namespace UNHS_Attendance_Encoder_Net48
{
    partial class MainEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.WindowTitleBar = new System.Windows.Forms.Panel();
            this.WindowBtnClose = new UNHS_Attendance_Encoder_Net48.CustomControls.IconButton();
            this.WindowBtnMinimize = new UNHS_Attendance_Encoder_Net48.CustomControls.IconButton();
            this.LblProjectTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EditorWindowContent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundedPanel2 = new UNHS_Attendance_Encoder_Net48.CustomControls.RoundedPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EntryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LunchStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LunchEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Undertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Overtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Late = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolbarBtnClearRows = new UNHS_Attendance_Encoder_Net48.CustomControls.ToolbarImageButton();
            this.toolbarBtnRemoveRow = new UNHS_Attendance_Encoder_Net48.CustomControls.ToolbarImageButton();
            this.toolbarBtnEditRow = new UNHS_Attendance_Encoder_Net48.CustomControls.ToolbarImageButton();
            this.toolbarBtnInsert = new UNHS_Attendance_Encoder_Net48.CustomControls.ToolbarImageButton();
            this.toolbarBtnHelp = new UNHS_Attendance_Encoder_Net48.CustomControls.ToolbarImageButton();
            this.toolbarBtnSave = new UNHS_Attendance_Encoder_Net48.CustomControls.ToolbarImageButton();
            this.toolbarBtnExport = new UNHS_Attendance_Encoder_Net48.CustomControls.ToolbarImageButton();
            this.toolbarBtnLoad = new UNHS_Attendance_Encoder_Net48.CustomControls.ToolbarImageButton();
            this.toolbarBtnNew = new UNHS_Attendance_Encoder_Net48.CustomControls.ToolbarImageButton();
            this.LblLoggedUser = new System.Windows.Forms.Label();
            this.BtnLogin = new UNHS_Attendance_Encoder_Net48.CustomControls.ImageButton();
            this.WindowTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowBtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.EditorWindowContent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowTitleBar
            // 
            this.WindowTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.WindowTitleBar.Controls.Add(this.WindowBtnClose);
            this.WindowTitleBar.Controls.Add(this.WindowBtnMinimize);
            this.WindowTitleBar.Controls.Add(this.LblProjectTitle);
            this.WindowTitleBar.Controls.Add(this.label1);
            this.WindowTitleBar.Controls.Add(this.pictureBox1);
            this.WindowTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowTitleBar.Location = new System.Drawing.Point(2, 2);
            this.WindowTitleBar.Name = "WindowTitleBar";
            this.WindowTitleBar.Size = new System.Drawing.Size(996, 32);
            this.WindowTitleBar.TabIndex = 0;
            this.WindowTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowTitleBar_MouseDown);
            // 
            // WindowBtnClose
            // 
            this.WindowBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowBtnClose.ClickedImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close_active;
            this.WindowBtnClose.HoverImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close_hover;
            this.WindowBtnClose.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close;
            this.WindowBtnClose.Location = new System.Drawing.Point(971, 4);
            this.WindowBtnClose.Name = "WindowBtnClose";
            this.WindowBtnClose.NormalImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close;
            this.WindowBtnClose.Size = new System.Drawing.Size(22, 22);
            this.WindowBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WindowBtnClose.TabIndex = 8;
            this.WindowBtnClose.TabStop = false;
            this.WindowBtnClose.Click += new System.EventHandler(this.WindowBtnClose_Click);
            // 
            // WindowBtnMinimize
            // 
            this.WindowBtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowBtnMinimize.ClickedImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_minimize_active;
            this.WindowBtnMinimize.HoverImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_minimize_hover;
            this.WindowBtnMinimize.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_minimize;
            this.WindowBtnMinimize.Location = new System.Drawing.Point(943, 4);
            this.WindowBtnMinimize.Name = "WindowBtnMinimize";
            this.WindowBtnMinimize.NormalImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_minimize;
            this.WindowBtnMinimize.Size = new System.Drawing.Size(22, 22);
            this.WindowBtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WindowBtnMinimize.TabIndex = 7;
            this.WindowBtnMinimize.TabStop = false;
            this.WindowBtnMinimize.Click += new System.EventHandler(this.WindowBtnMinimize_Click);
            // 
            // LblProjectTitle
            // 
            this.LblProjectTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblProjectTitle.AutoSize = true;
            this.LblProjectTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.LblProjectTitle.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.LblProjectTitle.ForeColor = System.Drawing.Color.White;
            this.LblProjectTitle.Location = new System.Drawing.Point(510, 4);
            this.LblProjectTitle.Name = "LblProjectTitle";
            this.LblProjectTitle.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LblProjectTitle.Size = new System.Drawing.Size(55, 23);
            this.LblProjectTitle.TabIndex = 6;
            this.LblProjectTitle.Text = "Untitled";
            this.LblProjectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "UNHS Attendance Encoder";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.icn_app_icon;
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // EditorWindowContent
            // 
            this.EditorWindowContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorWindowContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.EditorWindowContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditorWindowContent.Controls.Add(this.panel2);
            this.EditorWindowContent.Controls.Add(this.panel1);
            this.EditorWindowContent.Location = new System.Drawing.Point(2, 34);
            this.EditorWindowContent.Name = "EditorWindowContent";
            this.EditorWindowContent.Size = new System.Drawing.Size(996, 644);
            this.EditorWindowContent.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.roundedPanel2);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.panel2.Size = new System.Drawing.Size(996, 580);
            this.panel2.TabIndex = 4;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedPanel2.Controls.Add(this.dataGridView1);
            this.roundedPanel2.Location = new System.Drawing.Point(24, 16);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanel2.Size = new System.Drawing.Size(948, 548);
            this.roundedPanel2.SliceMargins = new System.Windows.Forms.Padding(10);
            this.roundedPanel2.SourceImage = ((System.Drawing.Image)(resources.GetObject("roundedPanel2.SourceImage")));
            this.roundedPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EntryNo,
            this.RowKey,
            this.EmployeeID,
            this.CreatedAt,
            this.TimeIn,
            this.LunchStart,
            this.LunchEnd,
            this.TimeOut,
            this.Duration,
            this.Status,
            this.Undertime,
            this.Overtime,
            this.Late,
            this.WeekNo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(916, 516);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // EntryNo
            // 
            this.EntryNo.FillWeight = 45.68528F;
            this.EntryNo.HeaderText = "#";
            this.EntryNo.Name = "EntryNo";
            this.EntryNo.ReadOnly = true;
            this.EntryNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RowKey
            // 
            this.RowKey.HeaderText = "RowKey";
            this.RowKey.Name = "RowKey";
            this.RowKey.ReadOnly = true;
            this.RowKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RowKey.Visible = false;
            // 
            // EmployeeID
            // 
            this.EmployeeID.FillWeight = 106.7893F;
            this.EmployeeID.HeaderText = "ID No.";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreatedAt
            // 
            this.CreatedAt.FillWeight = 106.7893F;
            this.CreatedAt.HeaderText = "Date";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TimeIn
            // 
            this.TimeIn.FillWeight = 106.7893F;
            this.TimeIn.HeaderText = "Time In";
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.ReadOnly = true;
            this.TimeIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LunchStart
            // 
            this.LunchStart.FillWeight = 106.7893F;
            this.LunchStart.HeaderText = "Lunch Start";
            this.LunchStart.Name = "LunchStart";
            this.LunchStart.ReadOnly = true;
            this.LunchStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LunchEnd
            // 
            this.LunchEnd.FillWeight = 106.7893F;
            this.LunchEnd.HeaderText = "Lunch End";
            this.LunchEnd.Name = "LunchEnd";
            this.LunchEnd.ReadOnly = true;
            this.LunchEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TimeOut
            // 
            this.TimeOut.FillWeight = 106.7893F;
            this.TimeOut.HeaderText = "Time Out";
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.ReadOnly = true;
            this.TimeOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Duration
            // 
            this.Duration.FillWeight = 106.7893F;
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.FillWeight = 106.7893F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Undertime
            // 
            this.Undertime.HeaderText = "Undertime";
            this.Undertime.Name = "Undertime";
            this.Undertime.ReadOnly = true;
            this.Undertime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Undertime.Visible = false;
            // 
            // Overtime
            // 
            this.Overtime.HeaderText = "Overtime";
            this.Overtime.Name = "Overtime";
            this.Overtime.ReadOnly = true;
            this.Overtime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Overtime.Visible = false;
            // 
            // Late
            // 
            this.Late.HeaderText = "Late";
            this.Late.Name = "Late";
            this.Late.ReadOnly = true;
            this.Late.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Late.Visible = false;
            // 
            // WeekNo
            // 
            this.WeekNo.HeaderText = "WeekNo";
            this.WeekNo.Name = "WeekNo";
            this.WeekNo.ReadOnly = true;
            this.WeekNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WeekNo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.toolbarBtnClearRows);
            this.panel1.Controls.Add(this.toolbarBtnRemoveRow);
            this.panel1.Controls.Add(this.toolbarBtnEditRow);
            this.panel1.Controls.Add(this.toolbarBtnInsert);
            this.panel1.Controls.Add(this.toolbarBtnHelp);
            this.panel1.Controls.Add(this.toolbarBtnSave);
            this.panel1.Controls.Add(this.toolbarBtnExport);
            this.panel1.Controls.Add(this.toolbarBtnLoad);
            this.panel1.Controls.Add(this.toolbarBtnNew);
            this.panel1.Controls.Add(this.LblLoggedUser);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 64);
            this.panel1.TabIndex = 0;
            // 
            // toolbarBtnClearRows
            // 
            this.toolbarBtnClearRows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbarBtnClearRows.ButtonText = "Clear";
            this.toolbarBtnClearRows.IconImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_clear;
            this.toolbarBtnClearRows.Location = new System.Drawing.Point(495, 6);
            this.toolbarBtnClearRows.Name = "toolbarBtnClearRows";
            this.toolbarBtnClearRows.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarBtnClearRows.Size = new System.Drawing.Size(52, 52);
            this.toolbarBtnClearRows.SliceMargins = new System.Windows.Forms.Padding(10);
            this.toolbarBtnClearRows.SourceImage = ((System.Drawing.Image)(resources.GetObject("toolbarBtnClearRows.SourceImage")));
            this.toolbarBtnClearRows.TabIndex = 8;
            this.toolbarBtnClearRows.Click += new System.EventHandler(this.toolbarBtnClearRows_Click);
            // 
            // toolbarBtnRemoveRow
            // 
            this.toolbarBtnRemoveRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbarBtnRemoveRow.ButtonText = "Delete";
            this.toolbarBtnRemoveRow.IconImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_remove_row;
            this.toolbarBtnRemoveRow.Location = new System.Drawing.Point(437, 6);
            this.toolbarBtnRemoveRow.Name = "toolbarBtnRemoveRow";
            this.toolbarBtnRemoveRow.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarBtnRemoveRow.Size = new System.Drawing.Size(52, 52);
            this.toolbarBtnRemoveRow.SliceMargins = new System.Windows.Forms.Padding(10);
            this.toolbarBtnRemoveRow.SourceImage = ((System.Drawing.Image)(resources.GetObject("toolbarBtnRemoveRow.SourceImage")));
            this.toolbarBtnRemoveRow.TabIndex = 7;
            this.toolbarBtnRemoveRow.Click += new System.EventHandler(this.toolbarBtnRemoveRow_Click);
            // 
            // toolbarBtnEditRow
            // 
            this.toolbarBtnEditRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbarBtnEditRow.ButtonText = "Edit";
            this.toolbarBtnEditRow.IconImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_edit_row;
            this.toolbarBtnEditRow.Location = new System.Drawing.Point(379, 6);
            this.toolbarBtnEditRow.Name = "toolbarBtnEditRow";
            this.toolbarBtnEditRow.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarBtnEditRow.Size = new System.Drawing.Size(52, 52);
            this.toolbarBtnEditRow.SliceMargins = new System.Windows.Forms.Padding(10);
            this.toolbarBtnEditRow.SourceImage = ((System.Drawing.Image)(resources.GetObject("toolbarBtnEditRow.SourceImage")));
            this.toolbarBtnEditRow.TabIndex = 6;
            this.toolbarBtnEditRow.Click += new System.EventHandler(this.toolbarBtnEditRow_Click);
            // 
            // toolbarBtnInsert
            // 
            this.toolbarBtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbarBtnInsert.ButtonText = "Insert";
            this.toolbarBtnInsert.IconImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_insert_row;
            this.toolbarBtnInsert.Location = new System.Drawing.Point(321, 6);
            this.toolbarBtnInsert.Name = "toolbarBtnInsert";
            this.toolbarBtnInsert.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarBtnInsert.Size = new System.Drawing.Size(52, 52);
            this.toolbarBtnInsert.SliceMargins = new System.Windows.Forms.Padding(10);
            this.toolbarBtnInsert.SourceImage = ((System.Drawing.Image)(resources.GetObject("toolbarBtnInsert.SourceImage")));
            this.toolbarBtnInsert.TabIndex = 5;
            this.toolbarBtnInsert.Click += new System.EventHandler(this.toolbarBtnInsert_Click);
            // 
            // toolbarBtnHelp
            // 
            this.toolbarBtnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbarBtnHelp.ButtonText = "Help";
            this.toolbarBtnHelp.IconImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_help;
            this.toolbarBtnHelp.Location = new System.Drawing.Point(240, 6);
            this.toolbarBtnHelp.Name = "toolbarBtnHelp";
            this.toolbarBtnHelp.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarBtnHelp.Size = new System.Drawing.Size(52, 52);
            this.toolbarBtnHelp.SliceMargins = new System.Windows.Forms.Padding(10);
            this.toolbarBtnHelp.SourceImage = ((System.Drawing.Image)(resources.GetObject("toolbarBtnHelp.SourceImage")));
            this.toolbarBtnHelp.TabIndex = 5;
            this.toolbarBtnHelp.Click += new System.EventHandler(this.toolbarBtnHelp_Click);
            // 
            // toolbarBtnSave
            // 
            this.toolbarBtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbarBtnSave.ButtonText = "Save";
            this.toolbarBtnSave.IconImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_save;
            this.toolbarBtnSave.Location = new System.Drawing.Point(124, 6);
            this.toolbarBtnSave.Name = "toolbarBtnSave";
            this.toolbarBtnSave.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarBtnSave.Size = new System.Drawing.Size(52, 52);
            this.toolbarBtnSave.SliceMargins = new System.Windows.Forms.Padding(10);
            this.toolbarBtnSave.SourceImage = ((System.Drawing.Image)(resources.GetObject("toolbarBtnSave.SourceImage")));
            this.toolbarBtnSave.TabIndex = 5;
            this.toolbarBtnSave.Click += new System.EventHandler(this.toolbarBtnSave_Click);
            // 
            // toolbarBtnExport
            // 
            this.toolbarBtnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbarBtnExport.ButtonText = "Export";
            this.toolbarBtnExport.IconImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_export;
            this.toolbarBtnExport.Location = new System.Drawing.Point(182, 6);
            this.toolbarBtnExport.Name = "toolbarBtnExport";
            this.toolbarBtnExport.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarBtnExport.Size = new System.Drawing.Size(52, 52);
            this.toolbarBtnExport.SliceMargins = new System.Windows.Forms.Padding(10);
            this.toolbarBtnExport.SourceImage = ((System.Drawing.Image)(resources.GetObject("toolbarBtnExport.SourceImage")));
            this.toolbarBtnExport.TabIndex = 5;
            this.toolbarBtnExport.Click += new System.EventHandler(this.toolbarBtnExport_Click);
            // 
            // toolbarBtnLoad
            // 
            this.toolbarBtnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbarBtnLoad.ButtonText = "Load";
            this.toolbarBtnLoad.IconImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_load;
            this.toolbarBtnLoad.Location = new System.Drawing.Point(66, 6);
            this.toolbarBtnLoad.Name = "toolbarBtnLoad";
            this.toolbarBtnLoad.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarBtnLoad.Size = new System.Drawing.Size(52, 52);
            this.toolbarBtnLoad.SliceMargins = new System.Windows.Forms.Padding(10);
            this.toolbarBtnLoad.SourceImage = ((System.Drawing.Image)(resources.GetObject("toolbarBtnLoad.SourceImage")));
            this.toolbarBtnLoad.TabIndex = 5;
            this.toolbarBtnLoad.Click += new System.EventHandler(this.toolbarBtnLoad_Click);
            // 
            // toolbarBtnNew
            // 
            this.toolbarBtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbarBtnNew.ButtonText = "New";
            this.toolbarBtnNew.IconImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_new;
            this.toolbarBtnNew.Location = new System.Drawing.Point(8, 6);
            this.toolbarBtnNew.Name = "toolbarBtnNew";
            this.toolbarBtnNew.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarBtnNew.Size = new System.Drawing.Size(52, 52);
            this.toolbarBtnNew.SliceMargins = new System.Windows.Forms.Padding(10);
            this.toolbarBtnNew.SourceImage = ((System.Drawing.Image)(resources.GetObject("toolbarBtnNew.SourceImage")));
            this.toolbarBtnNew.TabIndex = 5;
            this.toolbarBtnNew.Click += new System.EventHandler(this.toolbarBtnNew_Click);
            // 
            // LblLoggedUser
            // 
            this.LblLoggedUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLoggedUser.AutoEllipsis = true;
            this.LblLoggedUser.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.LblLoggedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.LblLoggedUser.Location = new System.Drawing.Point(806, 20);
            this.LblLoggedUser.Name = "LblLoggedUser";
            this.LblLoggedUser.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LblLoggedUser.Size = new System.Drawing.Size(94, 23);
            this.LblLoggedUser.TabIndex = 4;
            this.LblLoggedUser.Text = "UNHS Attendance Encoder";
            this.LblLoggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.ButtonFont = new System.Drawing.Font("Poppins", 9F);
            this.BtnLogin.ButtonText = "Logout";
            this.BtnLogin.ClickedImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.ClickedImage")));
            this.BtnLogin.HoverImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.HoverImage")));
            this.BtnLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogin.Image")));
            this.BtnLogin.Location = new System.Drawing.Point(906, 18);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.NormalImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.NormalImage")));
            this.BtnLogin.Size = new System.Drawing.Size(80, 28);
            this.BtnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.TabStop = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // MainEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.EditorWindowContent);
            this.Controls.Add(this.WindowTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainEditor";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNHS Attendance Encoder";
            this.Load += new System.EventHandler(this.MainEditor_Load);
            this.WindowTitleBar.ResumeLayout(false);
            this.WindowTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowBtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.EditorWindowContent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WindowTitleBar;
        private System.Windows.Forms.Panel EditorWindowContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private CustomControls.ImageButton BtnLogin;
        private System.Windows.Forms.Label LblProjectTitle;
        private System.Windows.Forms.Label LblLoggedUser;
        private CustomControls.ToolbarImageButton toolbarBtnNew;
        private CustomControls.ToolbarImageButton toolbarBtnLoad;
        private CustomControls.ToolbarImageButton toolbarBtnExport;
        private CustomControls.ToolbarImageButton toolbarBtnSave;
        private CustomControls.ToolbarImageButton toolbarBtnHelp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RoundedPanel roundedPanel2;
        private CustomControls.IconButton WindowBtnMinimize;
        private CustomControls.IconButton WindowBtnClose;
        private CustomControls.ToolbarImageButton toolbarBtnInsert;
        private CustomControls.ToolbarImageButton toolbarBtnEditRow;
        private CustomControls.ToolbarImageButton toolbarBtnRemoveRow;
        private CustomControls.ToolbarImageButton toolbarBtnClearRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LunchStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn LunchEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Undertime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Overtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Late;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekNo;
    }
}