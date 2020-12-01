using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red21_Paint.Figures
{
    class SquareCreator: IFigureCreator
    {
        public Figure CreateFigure(Point start, Point end)
        {
            int dif = Math.Abs(start.X - end.X);

            List<Point> squarePoints = new List<Point>();
            squarePoints.Add(new Point(start.X, start.Y));
            squarePoints.Add(new Point(start.X, start.Y + dif));
            squarePoints.Add(new Point(start.X+dif, start.Y+dif));
            squarePoints.Add(new Point(start.X + dif, start.Y));

            return new Figure(squarePoints);
        }
    }
}
