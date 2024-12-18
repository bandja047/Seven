using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness
{
    public class VerticalProgressBar :ProgressBar
    {
        public VerticalProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                Rectangle rect = this.ClientRectangle;
                ProgressBarRenderer.DrawVerticalBar(g, rect);
               
                rect.Inflate(-3, -3);
                if (this.Value > 0)
                {
                    Rectangle fillRect = new Rectangle(rect.X, rect.Bottom - (int)((float)rect.Height * ((float)this.Value / this.Maximum)), rect.Width, (int)((float)rect.Height * ((float)this.Value / this.Maximum)));
                    ProgressBarRenderer.DrawVerticalChunks(g, fillRect);
                }
            }
        }
    }
}
