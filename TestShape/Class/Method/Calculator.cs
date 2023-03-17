using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShape.Interface;

namespace TestShape.Class.Method
{
    static class Calculator
    {
        public static double СalculationoftheSegment(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        public static double Sum(double seg1, double seg2)
        {
            return Math.Pow(seg1, 2) + Math.Pow(seg2, 2);

        }

        public static double СalculationoPerimeter(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }
    }
}
