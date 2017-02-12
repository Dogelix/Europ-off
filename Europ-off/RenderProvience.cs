using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Europ_off
{
    class RenderProvince
    {
        public void renderShape(Province provience, Graphics renderSpace, Color color)
        {
            PointF[] points = new PointF[provience.GetCoordinates.Count];
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(color);
            for(int i = 0; i < provience.GetCoordinates.Count; i++ )
            {
                PointF point = new PointF();
                point.X = provience.GetCoordinates[i].x;
                point.Y = provience.GetCoordinates[i].y;
                points[i] = point;
            }
            renderSpace.DrawPolygon(pen, points);
            renderSpace.FillPolygon(brush, points);
        }
    }
}
