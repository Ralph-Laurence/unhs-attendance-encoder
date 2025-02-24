using System;
using System.Drawing;
using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48.CustomControls
{
    public partial class IconButton : PictureBox
    {
        public Image NormalImage { get; set; }
        public Image HoverImage { get; set; }
        public Image ClickedImage { get; set; }

        public IconButton()
        {
            this.NormalImage  = Properties.Resources.image_button_default_bg;
            this.HoverImage   = Properties.Resources.image_button_default_hover;
            this.ClickedImage = Properties.Resources.image_button_default_active;

            this.MouseEnter += ImageButton_MouseEnter;
            this.MouseLeave += ImageButton_MouseLeave;
            this.MouseDown += ImageButton_MouseDown;
            this.MouseUp += ImageButton_MouseUp;
            this.Click += ImageButton_Click;

            this.Size = new Size(80, 28);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Image = NormalImage;
            this.Invalidate();
        }

        private void ImageButton_MouseEnter(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void ImageButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }

        private void ImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Image = ClickedImage;
            }
        }

        private void ImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.Image = HoverImage;
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            // Handle click event here
        }
    }
}
