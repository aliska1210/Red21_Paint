using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red21_Paint.Figures 
{
    public class LineBreak
    {
        public LineBreak(List<Point> points)
        {
            Points = points;
        }
        public List<Point> Points { get; set; } // поле принимающее точки
        public void DrawBreakLine(Graphics graphics, Pen pen)
        {
            if (Points.Count < 2) return;
            for (int i = 0; i < Points.Count - 1; i++)
            {
                graphics.DrawLine(pen, Points[i], Points[i + 1]);
            }
        }
    }
}
