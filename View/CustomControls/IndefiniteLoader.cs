using System;
using System.Drawing;
using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48.CustomControls
{
    internal class IndefiniteLoader : Control
    {
        private readonly Timer timer;
        private int marqueePosition;

        public IndefiniteLoader()
        {
            // Set the default size and timer interval
            this.Size = new Size(200, 30);
            this.timer = new Timer { Interval = 30 };
            this.timer.Tick += Timer_Tick;
            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the marquee position and trigger a repaint
            marqueePosition += 5;
            if (marqueePosition > this.Width)
                marqueePosition = -50;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the background
            e.Graphics.FillRectangle(Brushes.LightGray, this.ClientRectangle);

            // Draw the marquee
            using (Brush brush = new SolidBrush(Color.Orange))
            {
                e.Graphics.FillRectangle(brush, marqueePosition, 0, 50, this.Height);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Stop and dispose of the timer
                this.timer.Stop();
                this.timer.Dispose();
            }
            base.Dispose(disposing);
        }
    }

}
