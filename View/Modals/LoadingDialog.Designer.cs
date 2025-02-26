namespace UNHS_Attendance_Encoder_Net48.View.Modals
{
    partial class LoadingDialog
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
            this.WindowTitleBar = new System.Windows.Forms.Panel();
            this.ModalTitle = new System.Windows.Forms.Label();
            this.ModalIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.indefiniteLoader1 = new UNHS_Attendance_Encoder_Net48.CustomControls.IndefiniteLoader();
            this.ModalMessage = new System.Windows.Forms.Label();
            this.WindowTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModalIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindowTitleBar
            // 
            this.WindowTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.WindowTitleBar.Controls.Add(this.ModalTitle);
            this.WindowTitleBar.Controls.Add(this.ModalIcon);
            this.WindowTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowTitleBar.Location = new System.Drawing.Point(2, 0);
            this.WindowTitleBar.Name = "WindowTitleBar";
            this.WindowTitleBar.Size = new System.Drawing.Size(296, 32);
            this.WindowTitleBar.TabIndex = 2;
            // 
            // ModalTitle
            // 
            this.ModalTitle.AutoSize = true;
            this.ModalTitle.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.ModalTitle.ForeColor = System.Drawing.Color.White;
            this.ModalTitle.Location = new System.Drawing.Point(35, 5);
            this.ModalTitle.Name = "ModalTitle";
            this.ModalTitle.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.ModalTitle.Size = new System.Drawing.Size(99, 23);
            this.ModalTitle.TabIndex = 4;
            this.ModalTitle.Text = "Working on it...";
            // 
            // ModalIcon
            // 
            this.ModalIcon.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.modal_icon_in_action;
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
            this.panel1.Controls.Add(this.indefiniteLoader1);
            this.panel1.Controls.Add(this.ModalMessage);
            this.panel1.Location = new System.Drawing.Point(5, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 132);
            this.panel1.TabIndex = 4;
            // 
            // indefiniteLoader1
            // 
            this.indefiniteLoader1.Location = new System.Drawing.Point(10, 100);
            this.indefiniteLoader1.Name = "indefiniteLoader1";
            this.indefiniteLoader1.Size = new System.Drawing.Size(268, 19);
            this.indefiniteLoader1.TabIndex = 5;
            this.indefiniteLoader1.Text = "indefiniteLoader1";
            // 
            // ModalMessage
            // 
            this.ModalMessage.Location = new System.Drawing.Point(3, 0);
            this.ModalMessage.Name = "ModalMessage";
            this.ModalMessage.Size = new System.Drawing.Size(284, 86);
            this.ModalMessage.TabIndex = 4;
            this.ModalMessage.Text = "Hold on... This shouldn\'t take long.";
            this.ModalMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(300, 170);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WindowTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoadingDialog";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingDialog";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoadingDialog_Load);
            this.WindowTitleBar.ResumeLayout(false);
            this.WindowTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModalIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WindowTitleBar;
        private System.Windows.Forms.PictureBox ModalIcon;
        private System.Windows.Forms.Label ModalTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ModalMessage;
        private CustomControls.IndefiniteLoader indefiniteLoader1;
    }
}