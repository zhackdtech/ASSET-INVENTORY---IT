using IT_ASSET_INVENTORY.UserInterface.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_ASSET_INVENTORY.UserInterface.Controls
{
    internal class SmoothPanel : Panel
    {
        #region Variables
        /// <summary>
        /// variable declarations
        /// </summary>
        private Color fill_color;
        #endregion

        #region access descriptors
        public Color SetFillColor
        {
            get { return fill_color; }
            set => fill_color = value;
        }
        #endregion
        /// <summary>
        /// override the paint method of the main control
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(fill_color), 10, 10, this.Width - 40, this.Height - 60, 10);
            SolidBrush brush = new SolidBrush(
                fill_color
                );
            g.FillRoundedRectangle(brush, 12, 12, this.Width - 44, this.Height - 64, 10);
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(fill_color, 0.00f)), 12, 12, this.Width - 44, this.Height - 64, 10);
            g.FillRoundedRectangle(new SolidBrush(fill_color), 12, 12 + ((this.Height - 64) / 2), this.Width - 44, (this.Height - 64) / 2, 10);
        }
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.Invalidate(); //redraw the control
        }
        const int WS_EX_TRANSPARENT = 0x20;
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TRANSPARENT;
                return cp;
            }
        }
    }
}
