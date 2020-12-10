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
    Figure figure;

    Pen pen;
    Point point;
    List<Point> points = new List<Point>();
    Color color;
    bool isFilled;

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
      mode = Mode.pen;
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
            points.Add(point);
            graphics.DrawLine(pen, point, e.Location);
            point = e.Location;
            tmpBitmap = (Bitmap)mainBitmap.Clone();
            paintSurface.Image = mainBitmap;
          }

          if (mode == Mode.figure)
          {
            tmpBitmap = new Bitmap(mainBitmap);// в tmp сохраняем mainBitmap до начала рисования новой фигуры, чтобы стирать все рисующиеся фигуры при движении (иначе будет заливка)
            graphics = Graphics.FromImage(tmpBitmap);// отображаем на экране то что рисуется в tmp
            figure = figureCreator.CreateFigure(point, e.Location);
            figure.DrawFigure(graphics, pen, isFilled);// использую свой собственный метод
            paintSurface.Image = tmpBitmap;
          }

          if (mode == Mode.editFigure && editableFigure != null)
          {
            tmpBitmap = new Bitmap(mainBitmap);
            graphics = Graphics.FromImage(tmpBitmap);
            Point delta = new Point(e.Location.X - point.X, e.Location.Y - point.Y);
            point = e.Location;
            editableFigure.Move(delta);
            editableFigure.DrawFigure(graphics, editableFigure.Pen, editableFigure.IsFilled);
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

      if (mode == Mode.pen)
      {
        points = new List<Point>();
      }

      if (mode == Mode.editFigure)
      {
        if (isFigureCatchedByCenterPoint())
        {
          figureStorage.Remove(editableFigure);
          DrawAll();
        }
      }
    }

    private void paintSurface_MouseUp(object sender, MouseEventArgs e)
    {
      isMouseDown = false;
      if (mode == Mode.pen)
      {
        SavePenAsFigure();
      }
      if (mode == Mode.figure)
      {
        mainBitmap = tmpBitmap;
        figureStorage.Add(figure);
      }
      if (mode == Mode.editFigure)
      {
        mainBitmap = tmpBitmap;
        figureStorage.Add(editableFigure);
        editableFigure = null;
        DrawMarkers();
      }
    }

    private void cyrcle_Click(object sender, EventArgs e)
    {
      figureCreator = new CircleCreator();
      mode = Mode.figure;
    }

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
      DrawMarkers();
    }

    private void isFilledCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      isFilled = checkBox1.Checked == true;
    }

    //public bool IsYou(Point point)
    //{
    //  Point p1 =  [3];
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
    //
    private void paintSurface_MouseHover(object sender, EventArgs e)
    {
      if (mode == Mode.editFigure) DrawMarkers();
    }

    private void paintSurface_MouseLeave(object sender, EventArgs e)
    {
      if (mode == Mode.editFigure) DeleteMarkers();
    }

    private void DrawAll()
    {
      graphics.Clear(Color.White);
      if (figureStorage == null) return;

      foreach (Figure figure in figureStorage)
      {
        if (figure != null) figure.DrawFigure(graphics, figure.Pen, figure.IsFilled);
      }
      paintSurface.Image = mainBitmap;
    }

    //проверка попадает ли текущая точка в область центра какой либо фигуры
    private bool isFigureCatchedByCenterPoint()
    {
      var isFigureChosen = false;
      foreach (Figure figure in figureStorage)
      {
        if (IsPointMatch(point, figure.CenterPoint))
        {
          editableFigure = figure;
          isFigureChosen = true;
        }
      }
      return isFigureChosen;
    }
    private bool IsPointMatch(Point current, Point existed)
    {
      return (current.X > existed.X - 15) && (current.X < existed.X + 15)
        && (current.Y > existed.Y - 15) && (current.Y < existed.Y + 15);
    }
    private void DrawMarkers()
    {
      foreach (var figure in figureStorage)
      {
        graphics.FillRectangle(new SolidBrush(Color.Red), figure.CenterPoint.X, figure.CenterPoint.Y, 5, 5);
      }
      paintSurface.Image = mainBitmap;
    }

    private void DeleteMarkers()
    {
      DrawAll();
    }

    private void SavePenAsFigure()
    {
      var penAsFigure = new Figure(points, point, point, point);
      penAsFigure.Pen = pen;
      figureStorage.Add(penAsFigure);
    }
  }
}


