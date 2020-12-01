using System.Drawing;

namespace Red21_Paint.Figures
{
	public interface IFigureCreator
	{
		Figure CreateFigure(Point start, Point end);
	}
}
