using System.Collections.Generic;
using System.Drawing;

namespace Red21_Paint.Figures
{
  public class Figure // класс для хранения точек 
  {
    public Figure()
    {
    }
    public Figure(List<Point> points, Point start, Point end)
    {
      Points = points;
      StartPoint = start;
      EndPoint = end;
      CenterPoint = new Point((start.X + (end.X - start.X)) / 2, start.Y + (end.Y - start.Y) / 2);
    }

    public List<Point> Points { get; set; } // поле принимающее точки
    public Point CenterPoint { get; set; }
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }
    public Pen Pen { get; set; }
    
    public void DrawFigure(Graphics graphics, Pen pen)
    {
      Pen = pen;
      if (Points.Count < 2) return;
      for (int i = 0; i < Points.Count - 1; i++)
      {
        graphics.DrawLine(pen, Points[i], Points[i + 1]);
      }
      graphics.DrawLine(pen, Points[0], Points[Points.Count - 1]);
    }
  }
}
