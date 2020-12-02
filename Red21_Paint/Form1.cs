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
    Pen laserWhite;
    Point point;
    IFigureCreator figureCreator;
    bool isFigure;
    bool isMouseDown;
    bool isLaser;
    bool isClear;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      mainBitmap = new Bitmap(paintSurface.MaximumSize.Width, paintSurface.MaximumSize.Height);
      graphics = Graphics.FromImage(mainBitmap);
      pen = new Pen(Color.Black, sizePen.Value);
    }

    private void paintSurface_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        if (isMouseDown)
        {
          pen = new Pen(Color.Black, sizePen.Value);
          pen.EndCap = LineCap.Round;
          pen.StartCap = LineCap.Round;
          laserWhite = new Pen(Color.White, 15);
          laserWhite.StartCap = LineCap.Round;
          laserWhite.EndCap = LineCap.Round;


          if (!isFigure)
          {
            if (isLaser)
            {
              graphics.DrawLine(laserWhite, point, e.Location);
              point = e.Location;
              tmpBitmap = (Bitmap)mainBitmap.Clone();
              paintSurface.Image = mainBitmap;
            }
            else
            {
              graphics.DrawLine(pen, point, e.Location);
              point = e.Location;
              tmpBitmap = (Bitmap)mainBitmap.Clone();
              paintSurface.Image = mainBitmap;
            }

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
      figureCreator = new TrueNAngleCreator();
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

    private void button33_Click(object sender, EventArgs e)
    {
      graphics.Clear(Color.White);
      paintSurface.Image = mainBitmap;
    }

    private void button33_MouseUp(object sender, MouseEventArgs e)
    {
    }

    private void ellipse_Click(object sender, EventArgs e)
    {
      figureCreator = new OvalCreator();
      isFigure = true;
    }
  }
}
