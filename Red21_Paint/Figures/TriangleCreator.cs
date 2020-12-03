﻿using System.Collections.Generic;
using System.Drawing;

namespace Red21_Paint.Figures
{
    public class TriangleCreator : IFigureCreator
    {
        public Figure CreateFigure(Point start, Point end)
        {
            List<Point> trianglePoints = new List<Point>();
            trianglePoints.Add(new Point(start.X, start.Y)); 
            trianglePoints.Add(new Point(end.X, end.Y)); 
            trianglePoints.Add(new Point(start.X, end.Y));

            return new Figure(trianglePoints);
        }
    }
}
