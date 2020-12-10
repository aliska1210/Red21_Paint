using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red21_Paint.Figures
{
  public class OvalCreator : IFigureCreator
  {
    public Figure CreateFigure(Point start, Point end)
    {
      int N = 360;
      Point centre = new Point((start.X + end.X) / 2, (start.Y + end.Y) / 2);
      Point delta = new Point(end.X - start.X, end.Y - start.Y);
      int radiusX = delta.X / 2;
      int radiusY = delta.Y / 2;
      List<Point> ovalPoints = new List<Point>();
      for (int i = 0; i < N; i++)
      {
        ovalPoints.Add(new Point(centre.X + (int)(radiusX * Math.Cos(2 * Math.PI * i / N)),
          centre.Y + (int)(radiusY * Math.Sin(2 * Math.PI * i / N))));
      }
      return new Figure(ovalPoints, start, end, centre);
    }
  }
}
//public class OvalCreator: IFigureCreator
//{
//  public Figure CreateFigure(Point start, Point end)
//  {
//    int cx = start.X;
//    int cy = start.Y;
//    int a = Math.Abs(end.X - start.X) / 2;
//    int b = Math.Abs(end.Y - start.Y) / 2;

//    List<Point> arcPoints = new List<Point>();

//    if (b == 0 || a == 0) return new Figure(arcPoints);

//    int arcMidPoint = b;
//    //  количество вычисляемых точек на одну дугу
//    //int arcMidPoint = (a > b) ? (int)(a * 0.707) : (int)(b * 0.707);//тернарный оператор        

//    for (int y = 0; y <= arcMidPoint; y++)
//    {
//      arcPoints.Add(new Point(a * Convert.ToInt32(Math.Round(Math.Sqrt(1-((y*y)/(b*b))))), y));
//    }

//    for (int i = arcPoints.Count - 2; i >= 0; i--)
//    {
//      arcPoints.Add(new Point(arcPoints[i].Y, arcPoints[i].X));
//    }

//    List<Point> ovalPoints = new List<Point>(); // 
//    List<Point> ovalPoints1 = new List<Point>();
//    List<Point> ovalPoints2 = new List<Point>();
//    List<Point> ovalPoints3 = new List<Point>();
//    List<Point> ovalPoints4 = new List<Point>();
//    for (int i = 1; i < arcPoints.Count; i++)
//    {
//      ovalPoints1.Add(new Point(arcPoints[i].X + cx, arcPoints[i].Y + cy));
//      ovalPoints2.Add(new Point(arcPoints[arcPoints.Count - i - 1].X + cx, cy - arcPoints[arcPoints.Count - i - 1].Y));
//      ovalPoints3.Add(new Point(cx - arcPoints[i - 1].X, cy - arcPoints[i - 1].Y));
//      ovalPoints4.Add(new Point(cx - arcPoints[arcPoints.Count - i - 1].X, arcPoints[arcPoints.Count - i - 1].Y + cy));
//    }
//    ovalPoints.AddRange(ovalPoints1);
//    ovalPoints.AddRange(ovalPoints2);
//    ovalPoints.AddRange(ovalPoints3);
//    ovalPoints.AddRange(ovalPoints4);

//    return new Figure(ovalPoints);
//  }
//  }
