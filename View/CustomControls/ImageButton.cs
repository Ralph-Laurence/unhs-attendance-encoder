using System;
using System.Drawing;
using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48.CustomControls
{
    public partial class ImageButton : PictureBox
    {
        public Image NormalImage { get; set; }
        public Image HoverImage { get; set; }
        public Image ClickedImage { get; set; }
        private Label textLabel;

        public ImageButton()
        {
            this.NormalImage  = Properties.Resources.image_button_default_bg;
            this.HoverImage   = Properties.Resources.image_button_default_hover;
            this.ClickedImage = Properties.Resources.image_button_default_active;
            
            textLabel = new Label
            {
                AutoSize  = false,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
            };

            this.Controls.Add(textLabel);

            this.MouseEnter += ImageButton_MouseEnter;
            this.MouseLeave += ImageButton_MouseLeave;
            this.MouseDown  += ImageButton_MouseDown;
            this.MouseUp    += ImageButton_MouseUp;
            this.Click      += ImageButton_Click;
            this.LostFocus  += ImageButton_MouseLeave;

            // Forward the text label's hover events onto the picturebox
            // as the text label is covering the picturebox entirely
            // which causes the picturebox to not recieve the event.
            textLabel.MouseEnter += (s, e) => this.OnMouseEnter(e);
            textLabel.MouseLeave += (s, e) => this.OnMouseLeave(e);
            textLabel.MouseDown  += (s, e) => this.OnMouseDown(e);
            textLabel.MouseUp    += (s, e) => this.OnMouseUp(e);
            textLabel.Click      += (s, e) => this.OnClick(e);


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

        public string ButtonText
        {
            get => textLabel.Text;
            set => textLabel.Text = value;
        }

        public Font ButtonFont
        {
            get => textLabel.Font;
            set => textLabel.Font = value;
        }
    }
}
