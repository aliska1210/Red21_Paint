using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red21_Paint.Figures
{
    class SasTriangleCreator : IFigureCreator
    {
        public Figure CreateFigure(Point start, Point end)
        {
            int cx = start.X;
            int cy = start.Y;

            double AB = (Math.Pow(end.X, 2) - Math.Pow(cx, 2)) + (Math.Pow(end.Y, 2) - Math.Pow(cy, 2));
            double angelDelta = 60;
            double foundation = Math.Sqrt(2 * AB * Math.Cos(2 * angelDelta));
            double CAx = cx - foundation/6;
            
            List<Point> trianglePoints = new List<Point>();
                trianglePoints.Add(new Point(cx, cy));
                trianglePoints.Add(new Point(end.X, end.Y));
                trianglePoints.Add(new Point((int)CAx, end.Y));
                trianglePoints.Add(new Point(cx, cy));

            return new Figure(trianglePoints);
        }
    }
}
