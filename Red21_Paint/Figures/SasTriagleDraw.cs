using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Red21_Paint.Figures
{
    class SasTriagleDraw
    {
		public FigureResult Draw(Bitmap mainBitmap, Bitmap tmpBitmap, Graphics graphics, Point point, Pen pen, MouseEventArgs e)
		{
			graphics = Graphics.FromImage(mainBitmap);
			pen.StartCap = LineCap.Round;
			pen.EndCap = LineCap.Round;
			graphics.SmoothingMode = SmoothingMode.HighQuality;

			double A = Math.Pow(e.X - point.X, 2);
			double B = Math.Pow(e.Y - point.Y, 2);
			double SqrtHipotinuse = A + B;
			int hipotinusse = (int)Math.Sqrt(SqrtHipotinuse);
			int catet = hipotinusse / 2;


			Point[] points = new Point[4];
			points[0] = new Point(point.X, point.Y);
			points[1] = new Point(e.X, e.Y);
			//points[2] = new Point(point.X, e.Y);
			points[2] = new Point(catet * 2, e.Y);
			points[3] = new Point(point.X, point.Y);
			graphics.DrawLines(pen, points);
			tmpBitmap = (Bitmap)mainBitmap.Clone();
			return new FigureResult(tmpBitmap, e.Location);
		}
	}
}
