using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWithSOLID.Class.Method;
using TestWithSOLID.Interface;

namespace TestWithSOLID.Class
{
    /// <summary>
    /// класс для преобразования двумерного массива вещественных чисел в список точек
    /// </summary>
    public static class Adapter
    {
        public static List<Point> ListPoint(double[,] mas)
        {
            List<Point> points = new List<Point>();
            for (int i = 0; i < mas.Length / 2; i++)
            {
                points.Add(new Point { X = mas[i, 0], Y = mas[i, 1] });
            }
            return points;
        }
    }
}
