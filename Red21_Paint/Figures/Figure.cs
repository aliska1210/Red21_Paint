using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red21_Paint.Figures
{
  public class Figure // класс для хранения точек 
  {
    public Figure(List<Point> points)
    {
      Points = points;
    }
    public List<Point> Points { get; set; } // поле принимающее точки
    public void DrawFigure(Graphics graphics, Pen pen)
    {
      if (Points.Count < 2) return;
      for (int i = 0; i < Points.Count - 1; i++)
      {
        graphics.DrawLine(pen, Points[i], Points[i + 1]);
      }
      graphics.DrawLine(pen, Points[0], Points[Points.Count - 1]);
    }
  }
}
