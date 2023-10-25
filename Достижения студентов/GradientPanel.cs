using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Достижения_студентов
{
    internal class GradientPanel : Panel
    {
        public Color ColorTop {  get; set; }
        public Color ColorBottom { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            PointF startPoint = new PointF(this.ClientRectangle.Left, this.ClientRectangle.Top);
            PointF endPoint = new PointF(this.ClientRectangle.Right, this.ClientRectangle.Bottom);
            LinearGradientBrush lgb = new LinearGradientBrush(startPoint, endPoint, this.ColorTop, this.ColorBottom);


            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
