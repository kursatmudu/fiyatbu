using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace FiyatBu.Views
{
    internal class ScrollBarView
    {

        internal void CustomizeScrollBarColor(Panel panel)
        {
            // ScrollBar rengini değiştirmek için VisualStyleRenderer kullanılır
            VisualStyleRenderer renderer = new VisualStyleRenderer(VisualStyleElement.ScrollBar.ThumbButtonHorizontal.Normal);

            // ScrollBar rengini özelleştirmek istediğiniz renge ayarlayın
            Color scrollBarColor = Color.LightBlue;

            // ScrollBar rengini ayarlamak için özel render yapılır
            renderer.SetParameters(VisualStyleElement.ScrollBar.ThumbButtonHorizontal.Normal);

            // ScrollBar arka planını değiştirmek için VisualStyleElement.ScrollBar.ThumbBackground elemanı kullanılır
            Rectangle thumbBounds = renderer.GetBackgroundContentRectangle(panel.CreateGraphics(), new Rectangle(0, 0, panel.VerticalScroll.Value, panel.VerticalScroll.Value));

            using (SolidBrush brush = new SolidBrush(scrollBarColor))
            {
                FillRoundRectangle(panel.CreateGraphics(), brush, thumbBounds, 3);
            }
        }

        private void FillRoundRectangle(Graphics graphics, Brush brush, Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rectangle.Right - radius * 2, rectangle.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rectangle.Right - radius * 2, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rectangle.X, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();

            graphics.FillPath(brush, path);
        }
    }
}
