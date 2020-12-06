using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red21_Paint.Figures
{
    class RectangleCreator:IFigureCreator
    {
        public Figure CreateFigure(Point start, Point end)
        {
            List<Point> rectanglePoints = new List<Point>();
            rectanglePoints.Add(new Point(start.X, start.Y));
            rectanglePoints.Add(new Point(start.X, end.Y));
            rectanglePoints.Add(new Point(end.X, end.Y));
            rectanglePoints.Add(new Point(end.X, start.Y));

            return new Figure(rectanglePoints, start, end);
        }
    }
}
