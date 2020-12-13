using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red21_Paint.Figures
{
  class SquareCreator : IFigureCreator
  {
    public Figure CreateFigure(Point start, Point end)
    {
      int dif = Math.Abs(start.X - end.X);
      int R = start.X - end.X;
      if (R >= 0)
      {
        end.X = start.X - dif;
        end.Y = start.Y - dif;
      }
      else
      {
        end.X = start.X + dif;
        end.Y = start.Y + dif;
      }


      List<Point> squarePoints = new List<Point>();

      squarePoints.Add(new Point(start.X, start.Y));
      squarePoints.Add(new Point(start.X, end.Y));
      squarePoints.Add(new Point(end.X, end.Y));
      squarePoints.Add(new Point(end.X, start.Y));

      Point center = new Point(((end.X + start.X)) / 2, (end.Y + start.Y) / 2);
      return new Figure(squarePoints, start, end, center);
    }
  }
}
