namespace UNHS_Attendance_Encoder_Net48.Modals
{
    partial class Modal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modal));
            this.WindowTitleBar = new System.Windows.Forms.Panel();
            this.LblProjectTitle = new System.Windows.Forms.Label();
            this.ModalClose = new UNHS_Attendance_Encoder_Net48.CustomControls.IconButton();
            this.ModalTitle = new System.Windows.Forms.Label();
            this.ModalIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ModalMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ModalCancelButton = new UNHS_Attendance_Encoder_Net48.CustomControls.ImageButton();
            this.ModalOkButton = new UNHS_Attendance_Encoder_Net48.CustomControls.ImageButton();
            this.WindowTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModalClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModalIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModalCancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModalOkButton)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowTitleBar
            // 
            this.WindowTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.WindowTitleBar.Controls.Add(this.LblProjectTitle);
            this.WindowTitleBar.Controls.Add(this.ModalClose);
            this.WindowTitleBar.Controls.Add(this.ModalTitle);
            this.WindowTitleBar.Controls.Add(this.ModalIcon);
            this.WindowTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowTitleBar.Location = new System.Drawing.Point(2, 0);
            this.WindowTitleBar.Name = "WindowTitleBar";
            this.WindowTitleBar.Size = new System.Drawing.Size(296, 32);
            this.WindowTitleBar.TabIndex = 1;
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
            // ModalClose
            // 
            this.ModalClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModalClose.ClickedImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close_active;
            this.ModalClose.HoverImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close_hover;
            this.ModalClose.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close;
            this.ModalClose.Location = new System.Drawing.Point(271, 4);
            this.ModalClose.Name = "ModalClose";
            this.ModalClose.NormalImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close;
            this.ModalClose.Size = new System.Drawing.Size(22, 22);
            this.ModalClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModalClose.TabIndex = 4;
            this.ModalClose.TabStop = false;
            this.ModalClose.Click += new System.EventHandler(this.ModalClose_Click);
            // 
            // ModalTitle
            // 
            this.ModalTitle.AutoSize = true;
            this.ModalTitle.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.ModalTitle.ForeColor = System.Drawing.Color.White;
            this.ModalTitle.Location = new System.Drawing.Point(30, 5);
            this.ModalTitle.Name = "ModalTitle";
            this.ModalTitle.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.ModalTitle.Size = new System.Drawing.Size(37, 23);
            this.ModalTitle.TabIndex = 3;
            this.ModalTitle.Text = "Alert";
            // 
            // ModalIcon
            // 
            this.ModalIcon.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.modal_icon_info;
            this.ModalIcon.Location = new System.Drawing.Point(8, 7);
            this.ModalIcon.Name = "ModalIcon";
            this.ModalIcon.Size = new System.Drawing.Size(18, 18);
            this.ModalIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModalIcon.TabIndex = 2;
            this.ModalIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ModalMessage);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 163);
            this.panel1.TabIndex = 3;
            // 
            // ModalMessage
            // 
            this.ModalMessage.Location = new System.Drawing.Point(0, 0);
            this.ModalMessage.Name = "ModalMessage";
            this.ModalMessage.Size = new System.Drawing.Size(285, 112);
            this.ModalMessage.TabIndex = 4;
            this.ModalMessage.Text = "label2";
            this.ModalMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.ModalCancelButton);
            this.panel2.Controls.Add(this.ModalOkButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 47);
            this.panel2.TabIndex = 3;
            // 
            // ModalCancelButton
            // 
            this.ModalCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ModalCancelButton.ButtonFont = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModalCancelButton.ButtonText = "Cancel";
            this.ModalCancelButton.ClickedImage = ((System.Drawing.Image)(resources.GetObject("ModalCancelButton.ClickedImage")));
            this.ModalCancelButton.HoverImage = ((System.Drawing.Image)(resources.GetObject("ModalCancelButton.HoverImage")));
            this.ModalCancelButton.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.image_button_default_bg_outlined;
            this.ModalCancelButton.Location = new System.Drawing.Point(114, 10);
            this.ModalCancelButton.Name = "ModalCancelButton";
            this.ModalCancelButton.NormalImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.image_button_default_bg_outlined;
            this.ModalCancelButton.Size = new System.Drawing.Size(80, 28);
            this.ModalCancelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModalCancelButton.TabIndex = 1;
            this.ModalCancelButton.TabStop = false;
            this.ModalCancelButton.Visible = false;
            this.ModalCancelButton.Click += new System.EventHandler(this.ModalCancelButton_Click);
            // 
            // ModalOkButton
            // 
            this.ModalOkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ModalOkButton.ButtonFont = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModalOkButton.ButtonText = "OK";
            this.ModalOkButton.ClickedImage = ((System.Drawing.Image)(resources.GetObject("ModalOkButton.ClickedImage")));
            this.ModalOkButton.HoverImage = ((System.Drawing.Image)(resources.GetObject("ModalOkButton.HoverImage")));
            this.ModalOkButton.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.image_button_default_bg_outlined;
            this.ModalOkButton.Location = new System.Drawing.Point(200, 10);
            this.ModalOkButton.Name = "ModalOkButton";
            this.ModalOkButton.NormalImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.image_button_default_bg_outlined;
            this.ModalOkButton.Size = new System.Drawing.Size(80, 28);
            this.ModalOkButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModalOkButton.TabIndex = 0;
            this.ModalOkButton.TabStop = false;
            this.ModalOkButton.Click += new System.EventHandler(this.ModalOkButton_Click);
            // 
            // Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.WindowTitleBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modal";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modal";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Modal_KeyUp);
            this.WindowTitleBar.ResumeLayout(false);
            this.WindowTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModalClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModalIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModalCancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModalOkButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WindowTitleBar;
        private System.Windows.Forms.Label LblProjectTitle;
        private CustomControls.IconButton ModalClose;
        private System.Windows.Forms.Label ModalTitle;
        private System.Windows.Forms.PictureBox ModalIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ModalMessage;
        private CustomControls.ImageButton ModalOkButton;
        private CustomControls.ImageButton ModalCancelButton;
    }
}