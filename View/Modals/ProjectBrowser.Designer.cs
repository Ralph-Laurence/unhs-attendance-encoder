namespace UNHS_Attendance_Encoder_Net48.View.Modals
{
    partial class ProjectBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectBrowser));
            this.WindowTitleBar = new System.Windows.Forms.Panel();
            this.ModalClose = new UNHS_Attendance_Encoder_Net48.CustomControls.IconButton();
            this.ModalTitle = new System.Windows.Forms.Label();
            this.ModalIcon = new System.Windows.Forms.PictureBox();
            this.btnLoad = new UNHS_Attendance_Encoder_Net48.CustomControls.ImageButton();
            this.btnCancel = new UNHS_Attendance_Encoder_Net48.CustomControls.ImageButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LblProjectFolder = new System.Windows.Forms.Label();
            this.WindowTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModalClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModalIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowTitleBar
            // 
            this.WindowTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.WindowTitleBar.Controls.Add(this.ModalClose);
            this.WindowTitleBar.Controls.Add(this.ModalTitle);
            this.WindowTitleBar.Controls.Add(this.ModalIcon);
            this.WindowTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowTitleBar.Location = new System.Drawing.Point(0, 0);
            this.WindowTitleBar.Name = "WindowTitleBar";
            this.WindowTitleBar.Size = new System.Drawing.Size(280, 32);
            this.WindowTitleBar.TabIndex = 4;
            // 
            // ModalClose
            // 
            this.ModalClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModalClose.ClickedImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close_active;
            this.ModalClose.HoverImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close_hover;
            this.ModalClose.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close;
            this.ModalClose.Location = new System.Drawing.Point(254, 6);
            this.ModalClose.Name = "ModalClose";
            this.ModalClose.NormalImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close;
            this.ModalClose.Size = new System.Drawing.Size(22, 22);
            this.ModalClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModalClose.TabIndex = 5;
            this.ModalClose.TabStop = false;
            this.ModalClose.Click += new System.EventHandler(this.ModalClose_Click);
            // 
            // ModalTitle
            // 
            this.ModalTitle.AutoSize = true;
            this.ModalTitle.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.ModalTitle.ForeColor = System.Drawing.Color.White;
            this.ModalTitle.Location = new System.Drawing.Point(35, 5);
            this.ModalTitle.Name = "ModalTitle";
            this.ModalTitle.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.ModalTitle.Size = new System.Drawing.Size(83, 23);
            this.ModalTitle.TabIndex = 4;
            this.ModalTitle.Text = "Load Project";
            // 
            // ModalIcon
            // 
            this.ModalIcon.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_load;
            this.ModalIcon.Location = new System.Drawing.Point(7, 5);
            this.ModalIcon.Name = "ModalIcon";
            this.ModalIcon.Size = new System.Drawing.Size(22, 22);
            this.ModalIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModalIcon.TabIndex = 2;
            this.ModalIcon.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.ButtonFont = new System.Drawing.Font("Poppins Medium", 9F);
            this.btnLoad.ButtonText = "Load";
            this.btnLoad.ClickedImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.ClickedImage")));
            this.btnLoad.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.HoverImage")));
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(188, 360);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.NormalImage")));
            this.btnLoad.Size = new System.Drawing.Size(80, 28);
            this.btnLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLoad.TabIndex = 5;
            this.btnLoad.TabStop = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonFont = new System.Drawing.Font("Poppins Medium", 9F);
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.ClickedImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ClickedImage")));
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(102, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.NormalImage")));
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(12, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 257);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LblProjectFolder
            // 
            this.LblProjectFolder.AutoEllipsis = true;
            this.LblProjectFolder.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProjectFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblProjectFolder.Location = new System.Drawing.Point(12, 45);
            this.LblProjectFolder.Name = "LblProjectFolder";
            this.LblProjectFolder.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LblProjectFolder.Size = new System.Drawing.Size(256, 42);
            this.LblProjectFolder.TabIndex = 6;
            this.LblProjectFolder.Text = "Project Folder";
            this.LblProjectFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProjectBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(280, 400);
            this.Controls.Add(this.LblProjectFolder);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.WindowTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectBrowser";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProjectBrowser_Load);
            this.WindowTitleBar.ResumeLayout(false);
            this.WindowTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModalClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModalIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WindowTitleBar;
        private CustomControls.IconButton ModalClose;
        private System.Windows.Forms.Label ModalTitle;
        private System.Windows.Forms.PictureBox ModalIcon;
        private CustomControls.ImageButton btnLoad;
        private CustomControls.ImageButton btnCancel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label LblProjectFolder;
    }
}