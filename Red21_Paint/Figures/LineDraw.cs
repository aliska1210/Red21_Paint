using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red21_Paint.Figures
{
    public class LineDraw : IFigures
    {
        public FigureResult Draw (Bitmap mainBitmap, Bitmap tmpBitmap, Graphics graphics, Point point, Pen pen, MouseEventArgs e)
        {
            graphics = Graphics.FromImage(mainBitmap);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            Point[] points = new Point[2];
            //points[0] = new Point(point.X, point.Y);
            //points[1] = new Point(e.X, e.Y);
            points[0] = point;
            points[1] = e.Location;
            graphics.DrawPolygon(pen, points);

            tmpBitmap = (Bitmap)mainBitmap.Clone();

            return new FigureResult(tmpBitmap, e.Location);


            ////tmpBitmap = (Bitmap)mainBitmap.Clone();
            ////graphics = Graphics.FromImage(tmpBitmap);
            ////pen = new Pen(Color.Red, 5);

            ////Point[] points = new Point[2];
            ////points[0] = point;
            ////points[1] = e.Location;
            ////graphics.DrawPolygon(pen, points);

            ////tmpBitmap = (Bitmap)mainBitmap.Clone();
            ////return new FigureResult(tmpBitmap, e.Location);
            //graphics = Graphics.FromImage(mainBitmap);
            //pen.StartCap = LineCap.Round;
            //pen.EndCap = LineCap.Round;
            //graphics.SmoothingMode = SmoothingMode.HighQuality;
            //Point[] points = new Point[4];
            //points[0] = new Point(point.X, point.Y);
            //points[1] = new Point(e.X, e.Y);
            //points[2] = new Point(point.X, e.Y);
            //points[3] = new Point(point.X, point.Y);
            //graphics.DrawLines(pen, points);

            //tmpBitmap = (Bitmap)mainBitmap.Clone();
            //return new FigureResult(tmpBitmap, e.Location);
        }
    }
}
