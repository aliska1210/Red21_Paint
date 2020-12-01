using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red21_Paint.Figures
{
    class LineCreator : IFigureCreator
    {
        public Figure CreateFigure(Point start, Point end)
        {


            List<Point> linePoints = new List<Point>();
            linePoints.Add(new Point(start.X, start.Y));
            linePoints.Add(new Point(end.X, end.Y));

            //List<Point> nLinePoints = new List<Point>();
            //nLinePoints.Add(new Point(start.X, start.Y));
            //nLinePoints.Add(new Point(end.X, end.Y));

            ////nlinePoints.Add(new Point(end.X, end.Y));
           
            //for (int i =0; i < nLinePoints.Count; i++)
            //{
             
            //    nLinePoints.Add(new Point(nLinePoints[i].X, nLinePoints[i].Y));
            //    //nlinePoints.Add(new Point(nlinePoints[i+1].X, nlinePoints[i+1].Y));
            //}
         
            return new Figure (linePoints);
        }
    }
}
