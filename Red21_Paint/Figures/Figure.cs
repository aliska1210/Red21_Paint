using System.Collections.Generic;
using System.Drawing;

namespace Red21_Paint.Figures
{
  public class Figure // класс для хранения точек  
  {
    public Figure()
    {
    }
    public Figure(List<Point> points, Point start, Point end, Point center)
    {
      Points = points;
      StartPoint = start;
      EndPoint = end;
      CenterPoint = center;
    }

    public List<Point> Points { get; set; } // поле принимающее точки 
    public Point CenterPoint { get; set; }
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }
    public Pen Pen { get; set; }
    public bool IsFilled { get; set; }

    public void DrawFigure(Graphics graphics, Pen pen, bool isFilled)
    {
      Pen = pen;
      IsFilled = isFilled;
      if (Points.Count < 2) return;
      if (!IsFilled)
      {
        for (int i = 0; i < Points.Count - 1; i++)
        {
          graphics.DrawLine(pen, Points[i], Points[i + 1]); 
        }
        graphics.DrawLine(pen, Points[0], Points[Points.Count - 1]);
      }
      else
      {
        SolidBrush Mybrush = new SolidBrush(pen.Color);
        for (int i = 0; i < Points.Count - 1; i++)
        {
          graphics.FillPolygon(Mybrush, Points.ToArray());
        }
      }
    }

    public void Move(Point delta)
    {
      for (int i = 0; i < this.Points.Count; i++)
      {
        this.Points[i] = new Point(this.Points[i].X + delta.X, this.Points[i].Y + delta.Y);
      }
      this.CenterPoint = new Point(this.CenterPoint.X + delta.X, this.CenterPoint.Y + delta.Y);
      this.StartPoint = new Point(this.StartPoint.X + delta.X, StartPoint.Y + delta.Y);
      this.EndPoint = new Point(this.EndPoint.X + delta.X, EndPoint.Y + delta.Y);
    }
  }
}

