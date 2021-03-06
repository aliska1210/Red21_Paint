﻿using System.Collections.Generic;
using System.Drawing;

namespace Red21_Paint.Figures
{
    public class TriangleCreator : IFigureCreator
    {
        public Figure CreateFigure(Point start, Point end)
        {
            Point center = new Point(((end.X + start.X)) / 2, (end.Y + start.Y) / 2);
            List<Point> trianglePoints = new List<Point>();
            trianglePoints.Add(new Point(start.X, start.Y)); 
            trianglePoints.Add(new Point(end.X, end.Y)); 
            trianglePoints.Add(new Point(start.X, end.Y));

            return new Figure(trianglePoints, start, end, center);
        }
    }
}
