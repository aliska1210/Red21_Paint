using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Red21_Paint.Figures
{
	class FigureResult
	{
		public Bitmap Image { get; }
		public Point Location { get; }

		public FigureResult(Bitmap image, Point location)
		{
			Image = image;
			Location = location;
		}
	}
}
