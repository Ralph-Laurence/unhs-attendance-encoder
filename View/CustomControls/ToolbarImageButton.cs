using System;
using System.Drawing;
using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48.CustomControls
{
    internal class ToolbarImageButton : RoundedPanel
    {
        private readonly Label       label;
        private readonly PictureBox  icon;

        public ToolbarImageButton()
        {
            // 
            this.Padding     = new Padding(2);
            this.Size        = new Size(52, 52);
            this.TabIndex    = 5;
            this.SourceImage = Properties.Resources.toolbar_icn_outline;
            // 
            // Label
            //
            this.label = new Label
            {
                Dock        = DockStyle.Bottom,
                Font        = new Font("Poppins", 8F),
                Location    = new Point(2, 35),
                Name        = "ToolbarIconButtonLabel",
                Size        = new Size(48, 15),
                TabIndex    = 0,
                Text        = "Button",
                TextAlign   = ContentAlignment.MiddleCenter,
                BackColor   = Color.Transparent
            };
            // 
            // Icon
            //
            this.icon = new PictureBox
            {
                BackgroundImage         = Properties.Resources.toolbar_icn_placeholder,
                BackgroundImageLayout   = ImageLayout.Zoom,
                Dock                    = DockStyle.Fill,
                Location                = new Point(2, 2),
                Name                    = "ToolbarIconBtnIcn",
                Size                    = new Size(48, 33),
                SizeMode                = PictureBoxSizeMode.CenterImage,
                BackColor               = Color.Transparent
            };
            //
            //
            //
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label);

            this.label.MouseEnter  += (s, e) => this.OnMouseEnter(e);
            this.label.MouseLeave  += (s, e) => this.OnMouseLeave(e);
            this.label.MouseDown   += (s, e) => this.OnMouseDown(e);
            this.label.MouseUp     += (s, e) => this.OnMouseUp(e);
            this.label.Click       += (s, e) => this.OnClick(e);

            this.icon.MouseEnter   += (s, e) => this.OnMouseEnter(e);
            this.icon.MouseLeave   += (s, e) => this.OnMouseLeave(e);
            this.icon.MouseDown    += (s, e) => this.OnMouseDown(e);
            this.icon.MouseUp      += (s, e) => this.OnMouseUp(e);
            this.icon.Click        += (s, e) => this.OnClick(e);

            this.MouseEnter += this.Handle_MouseEnter;
            this.MouseLeave += this.Handle_MouseLeave;
            this.MouseDown  += this.Handle_MouseDown;
            this.MouseUp    += this.Handle_MouseUp;
        }

        private void Handle_MouseEnter(object sender, EventArgs e)
        {
            this.SetSourceImage(Properties.Resources.toolbar_icn_outline_hover);
        }

        private void Handle_MouseLeave(object sender, EventArgs e)
        {
            this.SetSourceImage(Properties.Resources.toolbar_icn_outline);
        }

        private void Handle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.SetSourceImage(Properties.Resources.toolbar_icn_outline_active);
            }
        }

        private void Handle_MouseUp(object sender, MouseEventArgs e)
        {
            this.SetSourceImage(Properties.Resources.toolbar_icn_outline_hover);
        }

        public string ButtonText
        {
            get => this.label.Text;
            set => this.label.Text = value;
        }

        public Image IconImage
        {
            get => this.icon.BackgroundImage; 
            set => this.icon.BackgroundImage = value;
        }
    }
}
