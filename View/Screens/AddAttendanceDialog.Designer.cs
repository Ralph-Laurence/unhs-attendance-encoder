namespace UNHS_Attendance_Encoder_Net48.View.Screens
{
    partial class AddAttendanceDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAttendanceDialog));
            this.WindowOutline = new System.Windows.Forms.Panel();
            this.Container = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.BtnCancelAdd = new UNHS_Attendance_Encoder_Net48.CustomControls.ImageButton();
            this.BtnDoneAdd = new UNHS_Attendance_Encoder_Net48.CustomControls.ImageButton();
            this.roundedPanel1 = new UNHS_Attendance_Encoder_Net48.CustomControls.RoundedPanel();
            this.LblOvertimeIndicator = new System.Windows.Forms.Label();
            this.LblUndertimeIndicator = new System.Windows.Forms.Label();
            this.LblLateIndicator = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputTimeOut = new System.Windows.Forms.DateTimePicker();
            this.inputLunchTo = new System.Windows.Forms.DateTimePicker();
            this.inputLunchFrom = new System.Windows.Forms.DateTimePicker();
            this.inputTimeIn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.inputDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputEmployeeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WindowTitleBar = new System.Windows.Forms.Panel();
            this.WindowBtnClose = new UNHS_Attendance_Encoder_Net48.CustomControls.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WindowOutline.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDoneAdd)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.WindowTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowOutline
            // 
            this.WindowOutline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.WindowOutline.Controls.Add(this.Container);
            this.WindowOutline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowOutline.Location = new System.Drawing.Point(0, 32);
            this.WindowOutline.Name = "WindowOutline";
            this.WindowOutline.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.WindowOutline.Size = new System.Drawing.Size(475, 368);
            this.WindowOutline.TabIndex = 2;
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.White;
            this.Container.Controls.Add(this.ErrorLabel);
            this.Container.Controls.Add(this.BtnCancelAdd);
            this.Container.Controls.Add(this.BtnDoneAdd);
            this.Container.Controls.Add(this.roundedPanel1);
            this.Container.Controls.Add(this.label4);
            this.Container.Controls.Add(this.inputTimeOut);
            this.Container.Controls.Add(this.inputLunchTo);
            this.Container.Controls.Add(this.inputLunchFrom);
            this.Container.Controls.Add(this.inputTimeIn);
            this.Container.Controls.Add(this.label7);
            this.Container.Controls.Add(this.inputDate);
            this.Container.Controls.Add(this.label6);
            this.Container.Controls.Add(this.label5);
            this.Container.Controls.Add(this.inputEmployeeID);
            this.Container.Controls.Add(this.label3);
            this.Container.Controls.Add(this.label2);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(3, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(469, 365);
            this.Container.TabIndex = 0;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorLabel.Location = new System.Drawing.Point(20, 292);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(430, 22);
            this.ErrorLabel.TabIndex = 40;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCancelAdd
            // 
            this.BtnCancelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelAdd.ButtonFont = new System.Drawing.Font("Poppins Medium", 9F);
            this.BtnCancelAdd.ButtonText = "Cancel";
            this.BtnCancelAdd.ClickedImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelAdd.ClickedImage")));
            this.BtnCancelAdd.HoverImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelAdd.HoverImage")));
            this.BtnCancelAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelAdd.Image")));
            this.BtnCancelAdd.Location = new System.Drawing.Point(284, 328);
            this.BtnCancelAdd.Name = "BtnCancelAdd";
            this.BtnCancelAdd.NormalImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelAdd.NormalImage")));
            this.BtnCancelAdd.Size = new System.Drawing.Size(80, 28);
            this.BtnCancelAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnCancelAdd.TabIndex = 33;
            this.BtnCancelAdd.TabStop = false;
            this.BtnCancelAdd.Click += new System.EventHandler(this.BtnCancelAdd_Click);
            // 
            // BtnDoneAdd
            // 
            this.BtnDoneAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDoneAdd.ButtonFont = new System.Drawing.Font("Poppins Medium", 9F);
            this.BtnDoneAdd.ButtonText = "Done";
            this.BtnDoneAdd.ClickedImage = ((System.Drawing.Image)(resources.GetObject("BtnDoneAdd.ClickedImage")));
            this.BtnDoneAdd.HoverImage = ((System.Drawing.Image)(resources.GetObject("BtnDoneAdd.HoverImage")));
            this.BtnDoneAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnDoneAdd.Image")));
            this.BtnDoneAdd.Location = new System.Drawing.Point(370, 328);
            this.BtnDoneAdd.Name = "BtnDoneAdd";
            this.BtnDoneAdd.NormalImage = ((System.Drawing.Image)(resources.GetObject("BtnDoneAdd.NormalImage")));
            this.BtnDoneAdd.Size = new System.Drawing.Size(80, 28);
            this.BtnDoneAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnDoneAdd.TabIndex = 32;
            this.BtnDoneAdd.TabStop = false;
            this.BtnDoneAdd.Click += new System.EventHandler(this.BtnDoneAdd_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedPanel1.Controls.Add(this.LblOvertimeIndicator);
            this.roundedPanel1.Controls.Add(this.LblUndertimeIndicator);
            this.roundedPanel1.Controls.Add(this.LblLateIndicator);
            this.roundedPanel1.Controls.Add(this.label11);
            this.roundedPanel1.Controls.Add(this.label10);
            this.roundedPanel1.Controls.Add(this.label9);
            this.roundedPanel1.Controls.Add(this.label8);
            this.roundedPanel1.Location = new System.Drawing.Point(20, 155);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(430, 124);
            this.roundedPanel1.SliceMargins = new System.Windows.Forms.Padding(10);
            this.roundedPanel1.SourceImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.rounded_panel_9slice;
            this.roundedPanel1.TabIndex = 31;
            // 
            // LblOvertimeIndicator
            // 
            this.LblOvertimeIndicator.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.LblOvertimeIndicator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.LblOvertimeIndicator.Location = new System.Drawing.Point(290, 75);
            this.LblOvertimeIndicator.Name = "LblOvertimeIndicator";
            this.LblOvertimeIndicator.Size = new System.Drawing.Size(120, 22);
            this.LblOvertimeIndicator.TabIndex = 38;
            this.LblOvertimeIndicator.Text = "0h";
            this.LblOvertimeIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUndertimeIndicator
            // 
            this.LblUndertimeIndicator.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.LblUndertimeIndicator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.LblUndertimeIndicator.Location = new System.Drawing.Point(153, 75);
            this.LblUndertimeIndicator.Name = "LblUndertimeIndicator";
            this.LblUndertimeIndicator.Size = new System.Drawing.Size(120, 22);
            this.LblUndertimeIndicator.TabIndex = 37;
            this.LblUndertimeIndicator.Text = "0h";
            this.LblUndertimeIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLateIndicator
            // 
            this.LblLateIndicator.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.LblLateIndicator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.LblLateIndicator.Location = new System.Drawing.Point(16, 75);
            this.LblLateIndicator.Name = "LblLateIndicator";
            this.LblLateIndicator.Size = new System.Drawing.Size(120, 22);
            this.LblLateIndicator.TabIndex = 33;
            this.LblLateIndicator.Text = "0h";
            this.LblLateIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label11.Location = new System.Drawing.Point(290, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 22);
            this.label11.TabIndex = 35;
            this.label11.Text = "Overtime";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label10.Location = new System.Drawing.Point(153, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 22);
            this.label10.TabIndex = 34;
            this.label10.Text = "Undertime";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label9.Location = new System.Drawing.Point(16, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 33;
            this.label9.Text = "Late";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(16, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(404, 22);
            this.label8.TabIndex = 32;
            this.label8.Text = "* These values are automatically calculated based on your inputs.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label4.Location = new System.Drawing.Point(346, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Time Out";
            // 
            // inputTimeOut
            // 
            this.inputTimeOut.Checked = false;
            this.inputTimeOut.CustomFormat = "H:mm tt";
            this.inputTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputTimeOut.Location = new System.Drawing.Point(350, 104);
            this.inputTimeOut.Name = "inputTimeOut";
            this.inputTimeOut.ShowUpDown = true;
            this.inputTimeOut.Size = new System.Drawing.Size(100, 27);
            this.inputTimeOut.TabIndex = 5;
            this.inputTimeOut.ValueChanged += new System.EventHandler(this.inputTimeOut_ValueChanged);
            this.inputTimeOut.Leave += new System.EventHandler(this.dateTimePicker_Leave);
            // 
            // inputLunchTo
            // 
            this.inputLunchTo.Checked = false;
            this.inputLunchTo.CustomFormat = "H:mm tt";
            this.inputLunchTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputLunchTo.Location = new System.Drawing.Point(240, 104);
            this.inputLunchTo.Name = "inputLunchTo";
            this.inputLunchTo.ShowUpDown = true;
            this.inputLunchTo.Size = new System.Drawing.Size(100, 27);
            this.inputLunchTo.TabIndex = 4;
            this.inputLunchTo.Leave += new System.EventHandler(this.dateTimePicker_Leave);
            // 
            // inputLunchFrom
            // 
            this.inputLunchFrom.Checked = false;
            this.inputLunchFrom.CustomFormat = "H:mm tt";
            this.inputLunchFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputLunchFrom.Location = new System.Drawing.Point(130, 104);
            this.inputLunchFrom.Name = "inputLunchFrom";
            this.inputLunchFrom.ShowUpDown = true;
            this.inputLunchFrom.Size = new System.Drawing.Size(100, 27);
            this.inputLunchFrom.TabIndex = 3;
            this.inputLunchFrom.Leave += new System.EventHandler(this.dateTimePicker_Leave);
            // 
            // inputTimeIn
            // 
            this.inputTimeIn.CustomFormat = "H:mm tt";
            this.inputTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputTimeIn.Location = new System.Drawing.Point(20, 104);
            this.inputTimeIn.Name = "inputTimeIn";
            this.inputTimeIn.ShowUpDown = true;
            this.inputTimeIn.Size = new System.Drawing.Size(100, 27);
            this.inputTimeIn.TabIndex = 2;
            this.inputTimeIn.ValueChanged += new System.EventHandler(this.inputTimeIn_ValueChanged);
            this.inputTimeIn.Leave += new System.EventHandler(this.dateTimePicker_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label7.Location = new System.Drawing.Point(236, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Date";
            // 
            // inputDate
            // 
            this.inputDate.CustomFormat = "yyyy-MM-dd";
            this.inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDate.Location = new System.Drawing.Point(240, 38);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(210, 27);
            this.inputDate.TabIndex = 1;
            this.inputDate.Leave += new System.EventHandler(this.dateTimePicker_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label6.Location = new System.Drawing.Point(126, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Lunch From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label5.Location = new System.Drawing.Point(236, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Lunch To";
            // 
            // inputEmployeeID
            // 
            this.inputEmployeeID.Location = new System.Drawing.Point(20, 38);
            this.inputEmployeeID.Name = "inputEmployeeID";
            this.inputEmployeeID.Size = new System.Drawing.Size(210, 27);
            this.inputEmployeeID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Time In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID Number";
            // 
            // WindowTitleBar
            // 
            this.WindowTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.WindowTitleBar.Controls.Add(this.WindowBtnClose);
            this.WindowTitleBar.Controls.Add(this.label1);
            this.WindowTitleBar.Controls.Add(this.pictureBox1);
            this.WindowTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowTitleBar.Location = new System.Drawing.Point(0, 0);
            this.WindowTitleBar.Name = "WindowTitleBar";
            this.WindowTitleBar.Size = new System.Drawing.Size(475, 32);
            this.WindowTitleBar.TabIndex = 1;
            // 
            // WindowBtnClose
            // 
            this.WindowBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowBtnClose.ClickedImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close_active;
            this.WindowBtnClose.HoverImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close_hover;
            this.WindowBtnClose.Image = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close;
            this.WindowBtnClose.Location = new System.Drawing.Point(450, 4);
            this.WindowBtnClose.Name = "WindowBtnClose";
            this.WindowBtnClose.NormalImage = global::UNHS_Attendance_Encoder_Net48.Properties.Resources.window_control_close;
            this.WindowBtnClose.Size = new System.Drawing.Size(22, 22);
            this.WindowBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WindowBtnClose.TabIndex = 8;
            this.WindowBtnClose.TabStop = false;
            this.WindowBtnClose.Click += new System.EventHandler(this.WindowBtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Attendance";
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
            // AddAttendanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(475, 400);
            this.Controls.Add(this.WindowOutline);
            this.Controls.Add(this.WindowTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAttendanceDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAttendanceDialog";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddAttendanceDialog_Load);
            this.WindowOutline.ResumeLayout(false);
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDoneAdd)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.WindowTitleBar.ResumeLayout(false);
            this.WindowTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WindowTitleBar;
        private CustomControls.IconButton WindowBtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel WindowOutline;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputEmployeeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker inputDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker inputTimeOut;
        private System.Windows.Forms.DateTimePicker inputLunchTo;
        private System.Windows.Forms.DateTimePicker inputLunchFrom;
        private System.Windows.Forms.DateTimePicker inputTimeIn;
        private System.Windows.Forms.Label label4;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label8;
        private CustomControls.ImageButton BtnDoneAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblLateIndicator;
        private System.Windows.Forms.Label LblOvertimeIndicator;
        private System.Windows.Forms.Label LblUndertimeIndicator;
        private CustomControls.ImageButton BtnCancelAdd;
        private System.Windows.Forms.Label ErrorLabel;
    }
}