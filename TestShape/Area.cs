using System.Runtime.ConstrainedExecution;
using TestShape.Class.Method;
using TestShape.Class.Shape;
using TestShape.Class;
using TestShape.Interface;

namespace TestShape
{
    /// <summary>
    /// Класс взаимодействия с пользователем
    /// </summary>
    public static class Area
    {
        /// <summary>
        /// Метод рассчета площади
        /// </summary>
        /// <param name="mas"></param> на вход двумерный массив вещественных чисел
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static double CalculationSquare(IEnumerable<Point> points)
        {
            try
            {
                IShape _shape = null;
                var _points = points.Distinct().ToList();
                switch (_points.Count()) 
                {
                    case 2 : _shape = new Circle(_points); break;
                    case 3 : _shape = new Triangle(_points[0], _points[1], _points[2]); break;
                    default: _shape = new ShapeN(_points); break;
                }
                return _shape.Square();

            }
            catch(Exception ex) 
            {
                throw new Exception("При вычислении площади произошла ошибка: "+ex.Message, ex);
            }

        }

    }
}