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

        public int Number { get; set; }

        public TrueNAngleCreator(int n)
        {
            Number = n;
        }

        public Figure CreateFigure(Point start, Point end)
        {
            int cx = start.X;
            int cy = start.Y;
            List<Point> nAnglePoints = new List<Point>();
            double radius = Math.Sqrt(Math.Pow(end.Y - cy, 2) + Math.Pow(end.X - cx, 2));
            for (int i = 0; i < Number; i++)
            {
                nAnglePoints.Add(new Point(Convert.ToInt32(cx + radius * Math.Cos((2 * Math.PI * i) / Number)),
                                      Convert.ToInt32(cy + radius * Math.Sin((2 * Math.PI * i) / Number))));
            }
            return new Figure(nAnglePoints);
        }

    
    }
}
