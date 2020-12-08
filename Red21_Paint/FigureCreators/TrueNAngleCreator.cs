using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red21_Paint.Figures
{
    public class TrueNAngleCreator : IFigureCreator
    {
        public Figure CreateFigure(Point start, Point end)
        {
            int cx = start.X;
            int cy = start.Y;
            Point center = new Point(((end.X + start.X)) / 2, (end.Y + start.Y) / 2);
            List<Point> nAnglePoints = new List<Point>();
            double radius = Math.Sqrt(Math.Pow(end.Y - cy, 2) + Math.Pow(end.X - cx, 2));
            for (int i = 0; i < 5; i++)
            {
                nAnglePoints.Add(new Point(Convert.ToInt32(cx + radius * Math.Cos((2 * Math.PI * i) / 5)),
                                      Convert.ToInt32(cy + radius * Math.Sin((2 * Math.PI * i) / 5))));
            }

            return new Figure(nAnglePoints, start, end, center);
        }
    }
}
