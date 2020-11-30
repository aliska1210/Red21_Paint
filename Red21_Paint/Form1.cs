using Red21_Paint.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red21_Paint
{
    public partial class Form1 : Form
    {
		Bitmap mainBitmap;
		Bitmap tmpBitmap { get; set; }
		Graphics graphics;
		SasTriagleDraw triangle = new SasTriagleDraw();
		Pen pen;
		Point point;


		public Form1()
		{
			InitializeComponent();
		}



		private void Form1_Load(object sender, EventArgs e)
		{
			mainBitmap = new Bitmap(paintSurface.Width, paintSurface.Height);
			graphics = Graphics.FromImage(mainBitmap);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			pen = new Pen(Color.Red, 5);
			paintSurface.Image = mainBitmap;
			point = new Point(0, 0);
		}

		private void paintSurface_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				FigureResult result = triangle.Draw(mainBitmap, tmpBitmap, graphics, point, pen, e);
				graphics.Clear(Color.White);
				paintSurface.Image = result.Image;
				//point = result.Location;
			}
		}

		private void paintSurface_MouseDown(object sender, MouseEventArgs e)
		{
			point = e.Location;
		}

		private void paintSurface_MouseUp(object sender, MouseEventArgs e)
		{

			point = e.Location;
		}

        private void button34_Click(object sender, EventArgs e)
        {

        }
    }
}
