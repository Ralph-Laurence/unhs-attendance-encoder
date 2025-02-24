using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48.CustomControls
{
    public class RoundedPanel : Panel
    {
        private Image sourceImage;
        public Image SourceImage
        {
            get => sourceImage;
            set
            {
                sourceImage = value;
                Invalidate();
            }
        }

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.ContainerControl |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor
                          , true);

            SourceImage = Properties.Resources.rounded_panel_9slice;
            this.BackgroundImageLayout = ImageLayout.None;
            Invalidate();
        }

        public void SetSourceImage(Image image)
        {
            SourceImage = image;
            Invalidate();
        }

        public Padding SliceMargins { get; set; } = new Padding(10);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (sourceImage == null) return;

            Graphics g = e.Graphics;

            int left = SliceMargins.Left;
            int right = SliceMargins.Right;
            int top = SliceMargins.Top;
            int bottom = SliceMargins.Bottom;

            int width = sourceImage.Width;
            int height = sourceImage.Height;

            int destWidth = this.Width;
            int destHeight = this.Height;

            // Source Rectangles (from the original image)
            Rectangle[] sourceRects = new Rectangle[]
            {
                new Rectangle(0, 0, left, top), // Top-Left
                new Rectangle(left, 0, width - left - right, top), // Top
                new Rectangle(width - right, 0, right, top), // Top-Right
        
                new Rectangle(0, top, left, height - top - bottom), // Left
                new Rectangle(left, top, width - left - right, height - top - bottom), // Center
                new Rectangle(width - right, top, right, height - top - bottom), // Right
        
                new Rectangle(0, height - bottom, left, bottom), // Bottom-Left
                new Rectangle(left, height - bottom, width - left - right, bottom), // Bottom
                new Rectangle(width - right, height - bottom, right, bottom) // Bottom-Right
            };

            // Destination Rectangles (where to draw on the panel)
            Rectangle[] destRects = new Rectangle[]
            {
                new Rectangle(0, 0, left, top),
                new Rectangle(left, 0, destWidth - left - right, top),
                new Rectangle(destWidth - right, 0, right, top),

                new Rectangle(0, top, left, destHeight - top - bottom),
                new Rectangle(left, top, destWidth - left - right, destHeight - top - bottom),
                new Rectangle(destWidth - right, top, right, destHeight - top - bottom),

                new Rectangle(0, destHeight - bottom, left, bottom),
                new Rectangle(left, destHeight - bottom, destWidth - left - right, bottom),
                new Rectangle(destWidth - right, destHeight - bottom, right, bottom)
            };

            // Draw each section with proper scaling
            for (int i = 0; i < 9; i++)
            {
                g.DrawImage(sourceImage, destRects[i], sourceRects[i], GraphicsUnit.Pixel);
            }
        }
    }
}
