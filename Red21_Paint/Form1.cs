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
    Bitmap tmpBitmap { get; set; }
    Graphics graphics;
    Pen pen;
    Point startPoint;
    Color color;
    IFigureCreator figureCreator;
    bool isMouseDown;
    Mode mode;
    List<Figure> figureStorage = new List<Figure>();
    Figure editableFigure;
    Figure tmpFigure;

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
          var penColor = mode == Mode.laser ? Color.White : color;
          pen = new Pen(penColor, sizePen.Value)
          {
            EndCap = LineCap.Round,
            StartCap = LineCap.Round
          };

          if (mode == Mode.pen || mode == Mode.laser)
          {
            graphics.DrawLine(pen, startPoint, e.Location);
            startPoint = e.Location;
            tmpBitmap = (Bitmap)mainBitmap.Clone();
            paintSurface.Image = mainBitmap;
          }

          if (mode == Mode.figure)
          {
            tmpBitmap = new Bitmap(mainBitmap);// в tmp сохраняем mainBitmap до начала рисования новой фигуры, чтобы стирать все рисующиеся фигуры при движении (иначе будет заливка)
            graphics = Graphics.FromImage(tmpBitmap);// отображаем на экране то что рисуется в tmp
            Figure figure = figureCreator.CreateFigure(startPoint, e.Location);
            figure.DrawFigure(graphics, pen);// использую свой собственный метод
            tmpFigure = figure;
            paintSurface.Image = tmpBitmap;
          }

          if (mode == Mode.editFigure && editableFigure != null)
          {
            tmpBitmap = new Bitmap(mainBitmap);// в tmp сохраняем mainBitmap до начала рисования новой фигуры, чтобы стирать все рисующиеся фигуры при движении (иначе будет заливка)
            graphics = Graphics.FromImage(tmpBitmap);// отображаем на экране то что рисуется в tmp           
            
            Figure tmpFigure = new Figure() { Points = new List<Point>() };

            int cx = e.Location.X - startPoint.X;
            int cy = e.Location.Y - startPoint.Y;

            for (int i = 0; i < editableFigure.Points.Count; i++)
            {
              var x = editableFigure.Points[i].X + cx;
              var y = editableFigure.Points[i].Y + cy;
              tmpFigure.Points.Add(new Point(x , y));
            }

            //баг!!!! startPoint и EndPoint не записываются в tmpFigure
            pen = editableFigure.Pen;
            tmpFigure.DrawFigure(graphics, pen);
            paintSurface.Image = tmpBitmap;
            this.tmpFigure = tmpFigure;
          }

          GC.Collect();
        }
      }
    }

    private void paintSurface_MouseDown(object sender, MouseEventArgs e)
    {
      isMouseDown = true;
      startPoint = e.Location;

      if (mode == Mode.editFigure)
      {
        foreach (Figure figure in figureStorage)
        {
          if (IsPointMatch(startPoint,  figure.CenterPoint))
          {
            editableFigure = figure;
          }
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
      graphics.Clear(Color.White);
      paintSurface.Image = mainBitmap;
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
    }

     //проверка попадает ли текущая точка в область центра какой либо фигуры
    private bool IsPointMatch(Point current, Point existed)
    {
      return (current.X > existed.X - 15) && (current.X < existed.X + 15) 
        && (current.Y > existed.Y - 15) && (current.Y < existed.Y + 15);
    }

    private void paintSurface_MouseHover(object sender, EventArgs e)
    {
      if (mode == Mode.editFigure)
      {
        foreach (var figure in figureStorage)
        {
          graphics.FillRectangle(new SolidBrush(Color.Red), figure.CenterPoint.X, figure.CenterPoint.Y, 5, 5);
        }
        paintSurface.Image = mainBitmap;
      }
    }

    private void paintSurface_MouseLeave(object sender, EventArgs e)
    {
      if(mode == Mode.editFigure)
      {
        graphics.Clear(Color.White);
        foreach (var figure in figureStorage)
        {
          figure.DrawFigure(graphics, figure.Pen);
        }
        paintSurface.Image = mainBitmap;
      }
     
    }
  }
  }

    
