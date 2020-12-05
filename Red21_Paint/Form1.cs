using Red21_Paint.Figures;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Red21_Paint
{
    public partial class Form1 : Form
    {
        Bitmap mainBitmap;
        Bitmap tmpBitmap { get; set; }
        Graphics graphics;
        Pen pen;
        Point point;
        Color color;
        IFigureCreator figureCreator;
        bool isFigure;
        bool isMouseDown;
        bool isLaser;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainBitmap = new Bitmap(paintSurface.MaximumSize.Width, paintSurface.MaximumSize.Height);
            graphics = Graphics.FromImage(mainBitmap);
            color = Color.Black;
            pen = new Pen(color, sizePen.Value);
        }

        private void paintSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isMouseDown)
                {
                    color = isLaser ? Color.White : color;
                    pen = new Pen(color, sizePen.Value);
                    pen.EndCap = LineCap.Round;
                    pen.StartCap = LineCap.Round;

                    if (!isFigure)
                    {
                        graphics.DrawLine(pen, point, e.Location);
                        point = e.Location;
                        tmpBitmap = (Bitmap)mainBitmap.Clone();
                        paintSurface.Image = mainBitmap;
                    }

                    if (isFigure)
                    {
                        isLaser = false;
                        tmpBitmap = new Bitmap(mainBitmap);// в tmp сохраняем mainBitmap до начала рисования новой фигуры, чтобы стирать все рисующиеся фигуры при движении (иначе будет заливка)
                        graphics = Graphics.FromImage(tmpBitmap);// отображаем на экране то что рисуется в tmp
                        Figure figure = figureCreator.CreateFigure(point, e.Location);
                        figure.DrawFigure(graphics, pen);// использую свой собственный метод
                        paintSurface.Image = tmpBitmap;
                    }

                    GC.Collect();
                }
            }
        }

        private void paintSurface_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            point = e.Location;
        }

        private void paintSurface_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (isFigure)
            {
                mainBitmap = tmpBitmap;
            }
        }

        private void cyrcle_Click(object sender, EventArgs e)
        {
            figureCreator = new CircleCreator();
            isFigure = true;
        }

        // метод для соединения точек. Написали свой, так как стандартный не работал с List
        private void pencil_Click(object sender, EventArgs e)
        {
            isFigure = false;
            isLaser = false;
        }

        private void triangleDraw_Click(object sender, EventArgs e)
        {
            figureCreator = new TriangleCreator();
            isFigure = true;
        }

        public void NumberOfCorners_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nAngle_Click(object sender, EventArgs e)
        {
            figureCreator = new TrueNAngleCreator((int)NumberOfCorners.Value);
            isFigure = true;
        }
        private void square_Click(object sender, EventArgs e)
        {
            figureCreator = new SquareCreator();
            isFigure = true;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            figureCreator = new RectangleCreator();
            isFigure = true;
        }
        private void line_Click(object sender, EventArgs e)
        {
            figureCreator = new LineCreator();
            isFigure = true;
        }

        private void sasTriangle_Click(object sender, EventArgs e)
        {
            figureCreator = new SasTriangleCreator();
            isFigure = true;
        }

        private void laser_Click(object sender, EventArgs e)
        {
            isLaser = true;
            isFigure = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            paintSurface.Image = mainBitmap;
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            figureCreator = new OvalCreator();
            isFigure = true;
        }
        // выбор цвета 
        public void buttonChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }
    }
}


