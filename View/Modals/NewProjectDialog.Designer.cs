namespace UNHS_Attendance_Encoder_Net48.View.Modals
{
    partial class NewProjectDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectDialog));
            this.WindowTitleBar = new System.Windows.Forms.Panel();
            this.ModalTitle = new System.Windows.Forms.Label();
            this.ModalIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new UNHS_Attendance_Encoder_Net48.CustomControls.ImageButton();
            this.inputProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModalClose = new UNHS_Attendance_Encoder_Net48.CustomControls.IconButton();
            this.btnCancel = new UNHS_Attendance_Encoder_Net48.CustomControls.ImageButton();
            this.WindowTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModalIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModalClose)).BeginInit();
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
            this.WindowTitleBar.Location = new System.Drawing.Point(2, 0);
            this.WindowTitleBar.Name = "WindowTitleBar";
            this.WindowTitleBar.Size = new System.Drawing.Size(296, 32);
            this.WindowTitleBar.TabIndex = 3;
            // 
            // ModalTitle
            // 
            this.ModalTitle.AutoSize = true;
            this.ModalTitle.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.ModalTitle.ForeColor = System.Drawing.Color.White;
            this.ModalTitle.Location = new System.Drawing.Point(35, 5);
            this.ModalTitle.Name = "ModalTitle";
            this.ModalTitle.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.ModalTitle.Size = new System.Drawing.Size(80, 23);
            this.ModalTitle.TabIndex = 4;
            this.ModalTitle.Text = "New Project";
            // 
            // ModalIcon
            // 
            this.ModalIcon.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.toolbar_icn_new;
            this.ModalIcon.Location = new System.Drawing.Point(7, 5);
            this.ModalIcon.Name = "ModalIcon";
            this.ModalIcon.Size = new System.Drawing.Size(22, 22);
            this.ModalIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModalIcon.TabIndex = 2;
            this.ModalIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputProjectName);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(5, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 157);
            this.panel1.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.ButtonFont = new System.Drawing.Font("Poppins Medium", 9F);
            this.btnOK.ButtonText = "OK";
            this.btnOK.ClickedImage = ((System.Drawing.Image)(resources.GetObject("btnOK.ClickedImage")));
            this.btnOK.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnOK.HoverImage")));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(201, 119);
            this.btnOK.Name = "btnOK";
            this.btnOK.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnOK.NormalImage")));
            this.btnOK.Size = new System.Drawing.Size(80, 28);
            this.btnOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOK.TabIndex = 0;
            this.btnOK.TabStop = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // inputProjectName
            // 
            this.inputProjectName.Location = new System.Drawing.Point(13, 43);
            this.inputProjectName.MaxLength = 32;
            this.inputProjectName.Name = "inputProjectName";
            this.inputProjectName.Size = new System.Drawing.Size(268, 27);
            this.inputProjectName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set a project name. (Max 32 chars)";
            // 
            // ModalClose
            // 
            this.ModalClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModalClose.ClickedImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close_active;
            this.ModalClose.HoverImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close_hover;
            this.ModalClose.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close;
            this.ModalClose.Location = new System.Drawing.Point(270, 6);
            this.ModalClose.Name = "ModalClose";
            this.ModalClose.NormalImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close;
            this.ModalClose.Size = new System.Drawing.Size(22, 22);
            this.ModalClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModalClose.TabIndex = 5;
            this.ModalClose.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonFont = new System.Drawing.Font("Poppins Medium", 9F);
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.ClickedImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ClickedImage")));
            this.btnCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.HoverImage")));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(115, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.NormalImage")));
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WindowTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewProjectDialog";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProjectDialog";
            this.TopMost = true;
            this.WindowTitleBar.ResumeLayout(false);
            this.WindowTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModalIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModalClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WindowTitleBar;
        private System.Windows.Forms.Label ModalTitle;
        private System.Windows.Forms.PictureBox ModalIcon;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.ImageButton btnOK;
        private System.Windows.Forms.TextBox inputProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.IconButton ModalClose;
        private CustomControls.ImageButton btnCancel;
    }
}