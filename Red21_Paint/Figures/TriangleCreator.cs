using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red21_Paint.Figures
{
    public class TriangleCreator : IFigureCreator
    {
        public Figure CreateFigure(Point start, Point end)
        {
            int cx = start.X;
            int cy = start.Y;

            List<Point> trianglePoints = new List<Point>();
            trianglePoints.Add(new Point(cx, cy)); 
            trianglePoints.Add(new Point(end.X, end.Y)); 
            trianglePoints.Add(new Point(cx, end.Y)); 
            trianglePoints.Add(new Point(cx, cy)); 

            return new Figure(trianglePoints);
        }
    }
}
