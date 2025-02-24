using System;
using System.Drawing;
using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48
{
    partial class LoginForm
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
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // LoginForm
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Name = "LoginForm";
        //    this.Text = "Form1";
        //    this.Load += new System.EventHandler(this.LoginForm_Load);
        //    this.ResumeLayout(false);

        //}

        //#endregion

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.ScrollSpy = new System.Windows.Forms.PictureBox();
            this.CarouselDescription = new System.Windows.Forms.Label();
            this.CarouselTitle = new System.Windows.Forms.Label();
            this.CarouselPictureBox = new System.Windows.Forms.PictureBox();
            this.AppIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBackgroundImage = new System.Windows.Forms.PictureBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.iconButton1 = new UNHS_Attendance_Encoder_Net48.CustomControls.IconButton();
            this.LoginPanelInputsWrapper = new System.Windows.Forms.Panel();
            this.roundedPanel2 = new UNHS_Attendance_Encoder_Net48.CustomControls.RoundedPanel();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.InputPasswordIcon = new System.Windows.Forms.PictureBox();
            this.BtnLogin = new UNHS_Attendance_Encoder_Net48.CustomControls.ImageButton();
            this.roundedPanel1 = new UNHS_Attendance_Encoder_Net48.CustomControls.RoundedPanel();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.InputUsernameIcon = new System.Windows.Forms.PictureBox();
            this.LblVersionString = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginH3 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.ContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollSpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarouselPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBackgroundImage)).BeginInit();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton1)).BeginInit();
            this.LoginPanelInputsWrapper.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogin)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputUsernameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.BackColor = System.Drawing.Color.White;
            this.ContainerPanel.Controls.Add(this.ScrollSpy);
            this.ContainerPanel.Controls.Add(this.CarouselDescription);
            this.ContainerPanel.Controls.Add(this.CarouselTitle);
            this.ContainerPanel.Controls.Add(this.CarouselPictureBox);
            this.ContainerPanel.Controls.Add(this.AppIcon);
            this.ContainerPanel.Controls.Add(this.label1);
            this.ContainerPanel.Controls.Add(this.LoginBackgroundImage);
            this.ContainerPanel.Controls.Add(this.LoginPanel);
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(1, 1);
            this.ContainerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(798, 510);
            this.ContainerPanel.TabIndex = 0;
            // 
            // ScrollSpy
            // 
            this.ScrollSpy.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.scrollspy_login_0;
            this.ScrollSpy.Location = new System.Drawing.Point(159, 386);
            this.ScrollSpy.Name = "ScrollSpy";
            this.ScrollSpy.Size = new System.Drawing.Size(100, 50);
            this.ScrollSpy.TabIndex = 7;
            this.ScrollSpy.TabStop = false;
            // 
            // CarouselDescription
            // 
            this.CarouselDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarouselDescription.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarouselDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.CarouselDescription.Location = new System.Drawing.Point(22, 292);
            this.CarouselDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CarouselDescription.Name = "CarouselDescription";
            this.CarouselDescription.Padding = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.CarouselDescription.Size = new System.Drawing.Size(375, 75);
            this.CarouselDescription.TabIndex = 6;
            this.CarouselDescription.Text = "Create attendance records even without an active internet connection.";
            this.CarouselDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarouselTitle
            // 
            this.CarouselTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarouselTitle.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.CarouselTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CarouselTitle.Location = new System.Drawing.Point(22, 264);
            this.CarouselTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CarouselTitle.Name = "CarouselTitle";
            this.CarouselTitle.Size = new System.Drawing.Size(375, 28);
            this.CarouselTitle.TabIndex = 5;
            this.CarouselTitle.Text = "Works Offline";
            this.CarouselTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarouselPictureBox
            // 
            this.CarouselPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarouselPictureBox.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.icn_login_carousel_0;
            this.CarouselPictureBox.Location = new System.Drawing.Point(145, 120);
            this.CarouselPictureBox.Name = "CarouselPictureBox";
            this.CarouselPictureBox.Size = new System.Drawing.Size(128, 128);
            this.CarouselPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarouselPictureBox.TabIndex = 4;
            this.CarouselPictureBox.TabStop = false;
            // 
            // AppIcon
            // 
            this.AppIcon.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.icn_app_icon;
            this.AppIcon.Location = new System.Drawing.Point(22, 33);
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.Size = new System.Drawing.Size(28, 28);
            this.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppIcon.TabIndex = 3;
            this.AppIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "UNHS Attendance Encoder";
            // 
            // LoginBackgroundImage
            // 
            this.LoginBackgroundImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.LoginBackgroundImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBackgroundImage.Name = "LoginBackgroundImage";
            this.LoginBackgroundImage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginBackgroundImage.Size = new System.Drawing.Size(418, 510);
            this.LoginBackgroundImage.TabIndex = 1;
            this.LoginBackgroundImage.TabStop = false;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(61)))), ((int)(((byte)(84)))));
            this.LoginPanel.Controls.Add(this.iconButton1);
            this.LoginPanel.Controls.Add(this.LoginPanelInputsWrapper);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginPanel.Location = new System.Drawing.Point(418, 0);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Padding = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.LoginPanel.Size = new System.Drawing.Size(380, 510);
            this.LoginPanel.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.ClickedImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.icn_login_close_active;
            this.iconButton1.HoverImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.icn_login_close_hover;
            this.iconButton1.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.icn_login_close;
            this.iconButton1.Location = new System.Drawing.Point(340, 18);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.NormalImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.icn_login_close;
            this.iconButton1.Size = new System.Drawing.Size(22, 22);
            this.iconButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconButton1.TabIndex = 2;
            this.iconButton1.TabStop = false;
            this.iconButton1.Click += new System.EventHandler(this.BtnIcnExit_Click);
            // 
            // LoginPanelInputsWrapper
            // 
            this.LoginPanelInputsWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanelInputsWrapper.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanelInputsWrapper.Controls.Add(this.roundedPanel2);
            this.LoginPanelInputsWrapper.Controls.Add(this.BtnLogin);
            this.LoginPanelInputsWrapper.Controls.Add(this.roundedPanel1);
            this.LoginPanelInputsWrapper.Controls.Add(this.LblVersionString);
            this.LoginPanelInputsWrapper.Controls.Add(this.label5);
            this.LoginPanelInputsWrapper.Controls.Add(this.label4);
            this.LoginPanelInputsWrapper.Controls.Add(this.label3);
            this.LoginPanelInputsWrapper.Controls.Add(this.LoginH3);
            this.LoginPanelInputsWrapper.Location = new System.Drawing.Point(12, 50);
            this.LoginPanelInputsWrapper.Name = "LoginPanelInputsWrapper";
            this.LoginPanelInputsWrapper.Padding = new System.Windows.Forms.Padding(8, 32, 8, 8);
            this.LoginPanelInputsWrapper.Size = new System.Drawing.Size(352, 445);
            this.LoginPanelInputsWrapper.TabIndex = 1;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedPanel2.Controls.Add(this.InputPassword);
            this.roundedPanel2.Controls.Add(this.InputPasswordIcon);
            this.roundedPanel2.Location = new System.Drawing.Point(11, 202);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Padding = new System.Windows.Forms.Padding(16, 10, 10, 10);
            this.roundedPanel2.Size = new System.Drawing.Size(333, 40);
            this.roundedPanel2.SliceMargins = new System.Windows.Forms.Padding(10);
            this.roundedPanel2.SourceImage = ((System.Drawing.Image)(resources.GetObject("roundedPanel2.SourceImage")));
            this.roundedPanel2.TabIndex = 14;
            // 
            // InputPassword
            // 
            this.InputPassword.BackColor = System.Drawing.Color.White;
            this.InputPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPassword.Font = new System.Drawing.Font("Poppins", 10F);
            this.InputPassword.Location = new System.Drawing.Point(16, 10);
            this.InputPassword.Margin = new System.Windows.Forms.Padding(1);
            this.InputPassword.MaxLength = 16;
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '◈';
            this.InputPassword.Size = new System.Drawing.Size(287, 20);
            this.InputPassword.TabIndex = 6;
            this.InputPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputLoginField_KeyUp);
            // 
            // InputPasswordIcon
            // 
            this.InputPasswordIcon.BackColor = System.Drawing.Color.White;
            this.InputPasswordIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.InputPasswordIcon.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.icn_password;
            this.InputPasswordIcon.Location = new System.Drawing.Point(303, 10);
            this.InputPasswordIcon.Name = "InputPasswordIcon";
            this.InputPasswordIcon.Size = new System.Drawing.Size(20, 20);
            this.InputPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InputPasswordIcon.TabIndex = 7;
            this.InputPasswordIcon.TabStop = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.ButtonFont = new System.Drawing.Font("Poppins", 10F);
            this.BtnLogin.ButtonText = "Login";
            this.BtnLogin.ClickedImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.ClickedImage")));
            this.BtnLogin.HoverImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.HoverImage")));
            this.BtnLogin.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.btn_bg_login_hover;
            this.BtnLogin.Location = new System.Drawing.Point(264, 263);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.NormalImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.btn_bg_login_hover;
            this.BtnLogin.Size = new System.Drawing.Size(80, 32);
            this.BtnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnLogin.TabIndex = 13;
            this.BtnLogin.TabStop = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedPanel1.Controls.Add(this.InputUsername);
            this.roundedPanel1.Controls.Add(this.InputUsernameIcon);
            this.roundedPanel1.Location = new System.Drawing.Point(11, 128);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(16, 10, 10, 10);
            this.roundedPanel1.Size = new System.Drawing.Size(333, 40);
            this.roundedPanel1.SliceMargins = new System.Windows.Forms.Padding(10);
            this.roundedPanel1.SourceImage = ((System.Drawing.Image)(resources.GetObject("roundedPanel1.SourceImage")));
            this.roundedPanel1.TabIndex = 12;
            // 
            // InputUsername
            // 
            this.InputUsername.BackColor = System.Drawing.Color.White;
            this.InputUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputUsername.Font = new System.Drawing.Font("Poppins", 10F);
            this.InputUsername.Location = new System.Drawing.Point(16, 10);
            this.InputUsername.Margin = new System.Windows.Forms.Padding(1);
            this.InputUsername.MaxLength = 16;
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(287, 20);
            this.InputUsername.TabIndex = 6;
            this.InputUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputLoginField_KeyUp);
            // 
            // InputUsernameIcon
            // 
            this.InputUsernameIcon.BackColor = System.Drawing.Color.White;
            this.InputUsernameIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.InputUsernameIcon.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.icn_user;
            this.InputUsernameIcon.Location = new System.Drawing.Point(303, 10);
            this.InputUsernameIcon.Name = "InputUsernameIcon";
            this.InputUsernameIcon.Size = new System.Drawing.Size(20, 20);
            this.InputUsernameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InputUsernameIcon.TabIndex = 7;
            this.InputUsernameIcon.TabStop = false;
            // 
            // LblVersionString
            // 
            this.LblVersionString.AutoSize = true;
            this.LblVersionString.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblVersionString.Font = new System.Drawing.Font("Poppins", 9F);
            this.LblVersionString.ForeColor = System.Drawing.Color.DarkGray;
            this.LblVersionString.Location = new System.Drawing.Point(8, 415);
            this.LblVersionString.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVersionString.Name = "LblVersionString";
            this.LblVersionString.Size = new System.Drawing.Size(36, 22);
            this.LblVersionString.TabIndex = 11;
            this.LblVersionString.Text = "v0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(1);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label5.Size = new System.Drawing.Size(74, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(1);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.label4.Size = new System.Drawing.Size(79, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please login to your account to use the system.";
            // 
            // LoginH3
            // 
            this.LoginH3.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginH3.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginH3.ForeColor = System.Drawing.Color.White;
            this.LoginH3.Location = new System.Drawing.Point(8, 32);
            this.LoginH3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginH3.Name = "LoginH3";
            this.LoginH3.Size = new System.Drawing.Size(336, 34);
            this.LoginH3.TabIndex = 3;
            this.LoginH3.Text = "User Login";
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 3000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.ContainerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ContainerPanel.ResumeLayout(false);
            this.ContainerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollSpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarouselPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBackgroundImage)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconButton1)).EndInit();
            this.LoginPanelInputsWrapper.ResumeLayout(false);
            this.LoginPanelInputsWrapper.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogin)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputUsernameIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ContainerPanel;
        private PictureBox LoginBackgroundImage;
        private Panel LoginPanel;
        private Label label1;
        private Panel LoginPanelInputsWrapper;
        private Label LoginH3;
        private Label label3;
        private TextBox InputUsername;
        private Label label4;
        private PictureBox InputUsernameIcon;
        private Label label5;
        private TextBox InputPassword;
        private Label LblVersionString;
        private PictureBox AppIcon;
        private PictureBox CarouselPictureBox;
        private Label CarouselTitle;
        private Label CarouselDescription;
        private PictureBox ScrollSpy;
        private Timer Timer1;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomControls.ImageButton BtnLogin;
        private CustomControls.RoundedPanel roundedPanel2;
        private PictureBox InputPasswordIcon;
        private CustomControls.IconButton iconButton1;
    }
}

