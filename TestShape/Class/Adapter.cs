using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShape.Class.Method;
using TestShape.Interface;

namespace TestShape.Class
{
    /// <summary>
    /// класс для преобразования двумерного массива вещественных чисел в список точек
    /// </summary>
    public static class Adapter
    {
        public static List<Point> ListPoint(double[,] mas)
        {
            if ((mas.Length / 2 < 2) || (mas is null) || (mas.Length % 2 != 0))
                throw new Exception("Слишком мало параметров для вычисления.");
            List<Point> points = new List<Point>();
            for (int i = 0; i < mas.Length / 2; i++)
            {
                points.Add(new Point { X = mas[i, 0], Y = mas[i, 1] });
            }
            IEnumerable<Point> listcur = points.Distinct();
            if (listcur.Count() < points.Count())
                throw new Exception("Повторяющиеся точки.");
            return points;
        }
    }
}
