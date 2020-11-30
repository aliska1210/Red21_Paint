using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Red21_Paint.Figures;

namespace Red21_Paint.Figures
{
	class PencilDraw : IFigures
	{

		public FigureResult Draw(Bitmap mainBitmap, Bitmap tmpBitmap, Graphics graphics, Point point, Pen pen, MouseEventArgs e)
		{
			graphics = Graphics.FromImage(mainBitmap);
			pen.StartCap = LineCap.Round;
			pen.EndCap = LineCap.Round;
			graphics.DrawLine(pen, point.X, point.Y, e.X, e.Y);
			tmpBitmap = (Bitmap)mainBitmap.Clone();
			return new FigureResult(tmpBitmap, e.Location);
		}

	}
}
