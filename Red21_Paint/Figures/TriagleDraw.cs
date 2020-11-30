using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Red21_Paint.Figures;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Red21_Paint.Figures
{
	class TriangleDraw : IFigures
	{
		public FigureResult Draw(Bitmap mainBitmap, Bitmap tmpBitmap, Graphics graphics, Point point, Pen pen, MouseEventArgs e)
		{
			graphics = Graphics.FromImage(mainBitmap);
			pen.StartCap = LineCap.Round;
			pen.EndCap = LineCap.Round;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			Point[] points = new Point[4];
			points[0] = new Point(point.X, point.Y);
			points[1] = new Point(e.X, e.Y);
			points[2] = new Point(point.X, e.Y);
			points[3] = new Point(point.X, point.Y);
			graphics.DrawLines(pen, points);

			tmpBitmap = (Bitmap)mainBitmap.Clone();
			return new FigureResult(tmpBitmap, e.Location);
		}
	}
}
