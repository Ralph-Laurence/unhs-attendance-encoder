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
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LunchStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LunchEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlyoutContainer = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new UNHS_Attendance_Encoder_Net48.CustomControls.RoundedPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolbarImageButton2 = new UNHS_Attendance_Encoder_Net48.CustomControls.ToolbarImageButton();
            this.toolbarImageButton1 = new UNHS_Attendance_Encoder_Net48.CustomControls.ToolbarImageButton();
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
            this.FlyoutContainer.SuspendLayout();
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
            this.WindowTitleBar.Size = new System.Drawing.Size(1076, 32);
            this.WindowTitleBar.TabIndex = 0;
            // 
            // WindowBtnClose
            // 
            this.WindowBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowBtnClose.ClickedImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close_active;
            this.WindowBtnClose.HoverImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close_hover;
            this.WindowBtnClose.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close;
            this.WindowBtnClose.Location = new System.Drawing.Point(1051, 4);
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
            this.WindowBtnMinimize.Location = new System.Drawing.Point(1023, 4);
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
            this.LblProjectTitle.Location = new System.Drawing.Point(482, 4);
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
            this.EditorWindowContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.EditorWindowContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditorWindowContent.Controls.Add(this.panel2);
            this.EditorWindowContent.Controls.Add(this.FlyoutContainer);
            this.EditorWindowContent.Controls.Add(this.panel1);
            this.EditorWindowContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorWindowContent.Location = new System.Drawing.Point(2, 34);
            this.EditorWindowContent.Name = "EditorWindowContent";
            this.EditorWindowContent.Size = new System.Drawing.Size(1076, 684);
            this.EditorWindowContent.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.roundedPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 64);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 16, 8, 16);
            this.panel2.Size = new System.Drawing.Size(826, 620);
            this.panel2.TabIndex = 4;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedPanel2.Controls.Add(this.dataGridView1);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel2.Location = new System.Drawing.Point(8, 16);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanel2.Size = new System.Drawing.Size(810, 588);
            this.roundedPanel2.SliceMargins = new System.Windows.Forms.Padding(10);
            this.roundedPanel2.SourceImage = ((System.Drawing.Image)(resources.GetObject("roundedPanel2.SourceImage")));
            this.roundedPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.CreatedAt,
            this.TimeIn,
            this.LunchStart,
            this.LunchEnd,
            this.TimeOut});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(778, 556);
            this.dataGridView1.TabIndex = 3;
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "ID No.";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.HeaderText = "Date";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // TimeIn
            // 
            this.TimeIn.HeaderText = "Time In";
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.ReadOnly = true;
            // 
            // LunchStart
            // 
            this.LunchStart.HeaderText = "Lunch Start";
            this.LunchStart.Name = "LunchStart";
            this.LunchStart.ReadOnly = true;
            // 
            // LunchEnd
            // 
            this.LunchEnd.HeaderText = "Lunch End";
            this.LunchEnd.Name = "LunchEnd";
            this.LunchEnd.ReadOnly = true;
            // 
            // TimeOut
            // 
            this.TimeOut.HeaderText = "TimeOut";
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.ReadOnly = true;
            // 
            // FlyoutContainer
            // 
            this.FlyoutContainer.Controls.Add(this.roundedPanel1);
            this.FlyoutContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlyoutContainer.Location = new System.Drawing.Point(0, 64);
            this.FlyoutContainer.Name = "FlyoutContainer";
            this.FlyoutContainer.Padding = new System.Windows.Forms.Padding(8, 16, 8, 16);
            this.FlyoutContainer.Size = new System.Drawing.Size(250, 620);
            this.FlyoutContainer.TabIndex = 2;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedPanel1.Location = new System.Drawing.Point(11, 19);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(228, 206);
            this.roundedPanel1.SliceMargins = new System.Windows.Forms.Padding(10);
            this.roundedPanel1.SourceImage = ((System.Drawing.Image)(resources.GetObject("roundedPanel1.SourceImage")));
            this.roundedPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.toolbarImageButton2);
            this.panel1.Controls.Add(this.toolbarImageButton1);
            this.panel1.Controls.Add(this.toolbarBtnExport);
            this.panel1.Controls.Add(this.toolbarBtnLoad);
            this.panel1.Controls.Add(this.toolbarBtnNew);
            this.panel1.Controls.Add(this.LblLoggedUser);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 64);
            this.panel1.TabIndex = 0;
            // 
            // toolbarImageButton2
            // 
            this.toolbarImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbarImageButton2.ButtonText = "Help";
            this.toolbarImageButton2.IconImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_help;
            this.toolbarImageButton2.Location = new System.Drawing.Point(240, 6);
            this.toolbarImageButton2.Name = "toolbarImageButton2";
            this.toolbarImageButton2.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarImageButton2.Size = new System.Drawing.Size(52, 52);
            this.toolbarImageButton2.SliceMargins = new System.Windows.Forms.Padding(10);
            this.toolbarImageButton2.SourceImage = ((System.Drawing.Image)(resources.GetObject("toolbarImageButton2.SourceImage")));
            this.toolbarImageButton2.TabIndex = 5;
            // 
            // toolbarImageButton1
            // 
            this.toolbarImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbarImageButton1.ButtonText = "Save";
            this.toolbarImageButton1.IconImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_save;
            this.toolbarImageButton1.Location = new System.Drawing.Point(124, 6);
            this.toolbarImageButton1.Name = "toolbarImageButton1";
            this.toolbarImageButton1.Padding = new System.Windows.Forms.Padding(2);
            this.toolbarImageButton1.Size = new System.Drawing.Size(52, 52);
            this.toolbarImageButton1.SliceMargins = new System.Windows.Forms.Padding(10);
            this.toolbarImageButton1.SourceImage = ((System.Drawing.Image)(resources.GetObject("toolbarImageButton1.SourceImage")));
            this.toolbarImageButton1.TabIndex = 5;
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
            // 
            // LblLoggedUser
            // 
            this.LblLoggedUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLoggedUser.AutoEllipsis = true;
            this.LblLoggedUser.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.LblLoggedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.LblLoggedUser.Location = new System.Drawing.Point(886, 20);
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
            this.BtnLogin.Location = new System.Drawing.Point(986, 18);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
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
            this.FlyoutContainer.ResumeLayout(false);
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
        private System.Windows.Forms.Panel FlyoutContainer;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label LblLoggedUser;
        private CustomControls.ToolbarImageButton toolbarBtnNew;
        private CustomControls.ToolbarImageButton toolbarBtnLoad;
        private CustomControls.ToolbarImageButton toolbarBtnExport;
        private CustomControls.ToolbarImageButton toolbarImageButton1;
        private CustomControls.ToolbarImageButton toolbarImageButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RoundedPanel roundedPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LunchStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn LunchEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOut;
        private CustomControls.IconButton WindowBtnMinimize;
        private CustomControls.IconButton WindowBtnClose;
    }
}