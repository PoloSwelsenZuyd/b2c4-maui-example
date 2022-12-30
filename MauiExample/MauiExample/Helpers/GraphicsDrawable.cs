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

            PointF center = new PointF(dirtyRect.Center.X, dirtyRect.Center.Y + 220);
            float radius = Math.Min(dirtyRect.Width, dirtyRect.Height) / 4;
            float distance = 0.8f * radius;

            PointF center1 = new PointF(distance * (float)Math.Cos(9 * Math.PI / 6) + center.X,
                distance * (float)Math.Sin(9 * Math.PI / 6) + center.Y);
            PointF center2 = new PointF(distance * (float)Math.Cos(1 * Math.PI / 6) + center.X,
                distance * (float)Math.Sin(1 * Math.PI / 6) + center.Y);
            PointF center3 = new PointF(distance * (float)Math.Cos(5 * Math.PI / 6) + center.X,
                distance * (float)Math.Sin(5 * Math.PI / 6) + center.Y);

            canvas.BlendMode = BlendMode.Multiply;

            canvas.FillColor = Colors.Cyan;
            canvas.FillCircle(center1, radius);

            canvas.FillColor = Colors.Magenta;
            canvas.FillCircle(center2, radius);

            canvas.FillColor = Colors.Yellow;
            canvas.FillCircle(center3, radius);
        }
    }
}
