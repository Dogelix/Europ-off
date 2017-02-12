using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Europ_off
{
    class RenderProvince
    {
        public Region renderShape(Province province, Graphics renderSpace, Color color)
        {
            PointF[] points = CoordToPointFArray(province);
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(color);
            GraphicsPath gp = new GraphicsPath();

            gp.AddPolygon(points);
            Region region = new Region(gp);

            renderSpace.DrawPath(pen, gp);
            renderSpace.SetClip(region, CombineMode.Replace);
            
            renderSpace.FillPolygon(brush, points);

            return region;
        }

        public PointF[] CoordToPointFArray(Province province)
        {
            PointF[] points = new PointF[province.GetCoordinates.Count];
            for (int i = 0; i < province.GetCoordinates.Count; i++)
            {
                PointF point = new PointF();
                point.X = province.GetCoordinates[i].x;
                point.Y = province.GetCoordinates[i].y;
                points[i] = point;
            }
            return points;
        }
    }
}
