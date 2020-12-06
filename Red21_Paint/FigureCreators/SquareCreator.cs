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
            int dif = start.X - end.X;
            end.X = start.X + dif;
            end.Y = start.Y + dif;

            List<Point> squarePoints = new List<Point>();

            squarePoints.Add(new Point(start.X, start.Y));
            squarePoints.Add(new Point(start.X, end.Y));
            squarePoints.Add(new Point(end.X, end.Y));
            squarePoints.Add(new Point(end.X, start.Y));

            return new Figure(squarePoints, start, end);
        }
    }
}
