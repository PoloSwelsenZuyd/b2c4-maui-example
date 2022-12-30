using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiExample.Helpers
{
    public class GraphicsDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.FillColor = Colors.Red;
            canvas.SetShadow(new SizeF(10, 10), 4, Colors.Grey);
            canvas.FillRectangle(10, 10, 90, 100);

            canvas.FillColor = Colors.Green;
            canvas.SetShadow(new SizeF(10, -10), 4, Colors.Grey);
            canvas.FillEllipse(110, 10, 90, 100);

            canvas.FillColor = Colors.Blue;
            canvas.SetShadow(new SizeF(-10, 10), 4, Colors.Grey);
            canvas.FillRoundedRectangle(210, 10, 90, 100, 25);
        }
    }
}
