﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red21_Paint.Figures
{
  public class CircleCreator: IFigureCreator
  {
    public Figure CreateFigure(Point start, Point end)
    {
      int cx = start.X;
      int cy = start.Y;
      int r = Convert.ToInt32(Math.Sqrt((end.X - start.X) * (end.X - start.X) + (end.Y - start.Y) * (end.Y - start.Y)));

      List<Point> arcPoints = new List<Point>();

      int arcMidPoint = (int)(r * 0.707); //  количество вычисляемых точек на одну дугу
      for (int i = 0; i <= arcMidPoint; i++)
      {
        arcPoints.Add(new Point(i, Convert.ToInt32(Math.Round(Math.Sqrt(r * r - i * i)))));
      }

      for (int i = arcPoints.Count - 2; i >= 0; i--)
      {
        arcPoints.Add(new Point(arcPoints[i].Y, arcPoints[i].X));
      }

      List<Point> circlePoints = new List<Point>(); 
      List<Point> circlePoints1 = new List<Point>();
      List<Point> circlePoints2 = new List<Point>();
      List<Point> circlePoints3 = new List<Point>();
      List<Point> circlePoints4 = new List<Point>();
      for (int i = 1; i < arcPoints.Count; i++)
      {
        circlePoints1.Add(new Point(arcPoints[i].X + cx, arcPoints[i].Y + cy));
        circlePoints2.Add(new Point(arcPoints[arcPoints.Count - i - 1].X + cx, cy - arcPoints[arcPoints.Count - i - 1].Y));
        circlePoints3.Add(new Point(cx - arcPoints[i - 1].X, cy - arcPoints[i - 1].Y));
        circlePoints4.Add(new Point(cx - arcPoints[arcPoints.Count - i - 1].X, arcPoints[arcPoints.Count - i - 1].Y + cy));
      }
      circlePoints.AddRange(circlePoints1);
      circlePoints.AddRange(circlePoints2);
      circlePoints.AddRange(circlePoints3);
      circlePoints.AddRange(circlePoints4);

      return new Figure(circlePoints);
    }
  }
}
