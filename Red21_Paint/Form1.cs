using Red21_Paint.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Red21_Paint
{
    public partial class Form1 : Form
    {
        Bitmap mainBitmap;
        Bitmap tmpBitmap;
        Graphics graphics;

        bool isMouseDown;
        Mode mode;
        IFigureCreator figureCreator;
        List<Figure> figureStorage = new List<Figure>();
        Figure editableFigure;
        Figure tmpFigure;

        Pen pen;
        Point point;
        Color color;

        public  Form1()
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
                    var penColor = mode == Mode.laser ? paintSurface.BackColor : color;
                    pen = new Pen(penColor, sizePen.Value)
                    {
                        EndCap = LineCap.Round,
                        StartCap = LineCap.Round
                    };

                    if (mode == Mode.pen || mode == Mode.laser)
                    {
                        PenOrEraserDrawingModePaint(e.Location);
                    }

                    if (mode == Mode.figure)
                    {
                        FigureDrawingModeFigure(e.Location);
                    }

                    if (mode == Mode.editFigure && editableFigure != null)
                    {
                        EnditFigureModeEditFigure(e.Location);
                    }

                    GC.Collect();
                }
            }
        }

        private void paintSurface_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            point = e.Location;

            if (mode == Mode.editFigure)
            {
                bool isFigureChosen = false;
                foreach (Figure figure in figureStorage)
                {
                    if (IsPointMatch(point, figure.CenterPoint))
                    {
                        editableFigure = figure;
                        isFigureChosen = true;
                    }
                }

                if (isFigureChosen)
                {
                    figureStorage.Remove(editableFigure);
                    DrawAll();
                }
            }
        }

        private void paintSurface_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (mode == Mode.figure)
            {
                mainBitmap = tmpBitmap;
                figureStorage.Add(tmpFigure);
            }
            if (mode == Mode.editFigure)
            {
                mainBitmap = tmpBitmap;
                figureStorage.Add(tmpFigure);
                editableFigure = null;
            }
        }

        private void cyrcle_Click(object sender, EventArgs e)
        {
            figureCreator = new CircleCreator();
            mode = Mode.figure;
        }

        // метод для соединения точек. Написали свой, так как стандартный не работал с List
        private void pencil_Click(object sender, EventArgs e)
        {
            mode = Mode.pen;
        }

        private void triangleDraw_Click(object sender, EventArgs e)
        {
            figureCreator = new TriangleCreator();
            mode = Mode.figure;
        }

        public void NumberOfCorners_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nAngle_Click(object sender, EventArgs e)
        {
            figureCreator = new TrueNAngleCreator();
            mode = Mode.figure;
        }
        private void square_Click(object sender, EventArgs e)
        {
            figureCreator = new SquareCreator();
            mode = Mode.figure;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            figureCreator = new RectangleCreator();
            mode = Mode.figure;
        }
        private void line_Click(object sender, EventArgs e)
        {
            figureCreator = new LineCreator();
            mode = Mode.figure;
        }

        private void sasTriangle_Click(object sender, EventArgs e)
        {
            figureCreator = new SasTriangleCreator();
            mode = Mode.figure;
        }

        private void laser_Click(object sender, EventArgs e)
        {
            mode = Mode.laser;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(paintSurface.BackColor);
            paintSurface.Image = mainBitmap;
            layerPaintSurface.Image = paintSurface.Image;
            figureStorage = new List<Figure>();
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            figureCreator = new OvalCreator();
            mode = Mode.figure;
        }
        // выбор цвета 
        public void buttonChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            mode = Mode.editFigure;
            if (mode == Mode.editFigure)
            {
                foreach (var figure in figureStorage)
                {
                    graphics.FillRectangle(new SolidBrush(Color.Red), figure.CenterPoint.X, figure.CenterPoint.Y, 5, 5);
                }
                paintSurface.Image = mainBitmap;
                layerPaintSurface.Image = paintSurface.Image;
            }

        }

        //проверка попадает ли текущая точка в область центра какой либо фигуры
        private bool IsPointMatch(Point current, Point existed)
        {
            return (current.X > existed.X - 15) && (current.X < existed.X + 15)
              && (current.Y > existed.Y - 15) && (current.Y < existed.Y + 15);
        }
        //public bool IsYou(Figure points)
        //{
        //  Point p1 = Points[3];
        //  Point p2;
        //  foreach (Figure figure in points)
        //  {
        //    p2 = p;
        //    if (Math.Abs((point.X - p1.X) * (p2.Y - p1.Y) - (point.Y - p1.Y) * (p2.X - p1.X))
        //        <= Math.Abs(10 * ((p2.Y - p1.Y) + (p2.X - p1.X))))
        //    {
        //      return true;
        //    }
        //    p1 = p2;
        //  }
        //  return false;
        //}

        private void paintSurface_MouseHover(object sender, EventArgs e)
        {
            /*      if (mode == Mode.editFigure)
                  {
                    foreach (var figure in figureStorage)
                    {
                      graphics.FillRectangle(new SolidBrush(Color.Red), figure.CenterPoint.X, figure.CenterPoint.Y, 5, 5);
                    }
                    paintSurface.Image = mainBitmap;
                  }*/
        }

        private void paintSurface_MouseLeave(object sender, EventArgs e)
        {
            if (mode == Mode.editFigure)
            {
                DrawAll();
                paintSurface.Image = mainBitmap;
                layerPaintSurface.Image = paintSurface.Image;
            }

        }
        private void DrawAll()
        {
            graphics.Clear(paintSurface.BackColor);
            foreach (Figure figure in figureStorage)
            {
                figure.DrawFigure(graphics, figure.Pen);
            }
        }

        private void PenOrEraserDrawingModePaint(Point eLocation)
        {
            graphics.DrawLine(pen, point, eLocation);
            point = eLocation;
            tmpBitmap = (Bitmap)mainBitmap.Clone();
            paintSurface.Image = mainBitmap;
            layerPaintSurface.Image = paintSurface.Image;
        }

        private void FigureDrawingModeFigure(Point eLocation)
        {
            tmpBitmap = new Bitmap(mainBitmap);
            graphics = Graphics.FromImage(tmpBitmap);
            Figure figure = figureCreator.CreateFigure(point, eLocation);
            figure.DrawFigure(graphics, pen);
            tmpFigure = figure;
            paintSurface.Image = tmpBitmap;
            layerPaintSurface.Image = paintSurface.Image;
        }

        private void EnditFigureModeEditFigure(Point eLocation)
        {
            tmpBitmap = new Bitmap(mainBitmap);
            graphics = Graphics.FromImage(tmpBitmap);
            Point delta = new Point(eLocation.X - point.X, eLocation.Y - point.Y);
            point = eLocation;
            editableFigure.Move(delta);
            tmpFigure.DrawFigure(graphics, editableFigure.Pen);
            paintSurface.Image = tmpBitmap;
            layerPaintSurface.Image = paintSurface.Image;
            this.tmpFigure = editableFigure;
        }

        private void background_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                paintSurface.BackColor = colorDialog1.Color;
            }
        }

    }
}




