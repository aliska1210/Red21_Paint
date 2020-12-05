using System.Drawing;

namespace Red21_Paint.Figures
{
    interface INAngleFigureCreator : IFigureCreator
    {
        Figure CreateNAngleFigure(Point start, Point end, int numberAngles);
    }
}
