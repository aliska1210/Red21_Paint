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
           
            List<Point> trianglePoints = new List<Point>();
            trianglePoints.Add(new Point((end.X - start.X) / 2 + start.X, start.Y));
            trianglePoints.Add(new Point(end.X, end.Y));
            trianglePoints.Add(new Point(start.X, end.Y));

            return new Figure(trianglePoints);
        } 
    }
}
