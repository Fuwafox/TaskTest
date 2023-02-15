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
        public static double CalculationSquare(double[,] mas)
        {
            try
            {
                
                    List<Point> points = new List<Point>();
                    points = Adapter.ListPoint(mas);
                   // CheckEmpty(points);                       
                    
                        if (points.Count > 3)
                        {
                            var shape = ConstructorShape(points);
                            return shape.Square();
                        }
                        else
                        {
                            var listSegment = new List<double>(Calculator.СalculationoftheSegment(points));
                            var shape = ConstructorShape(listSegment);
                            return shape.Square();
                        }

            }
            catch(Exception ex) 
            {
                throw new Exception("При вычислении площади произошла ошибка: "+ex.Message, ex);
            }

        }

        /// <summary>
        /// Проверка на дубликаты точек
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
     /*   private static CheckEmpty(List<Point> points) 
        {
            IEnumerable<Point> listcur = points.Distinct();
            if (listcur.Count()<points.Count())
                throw new Exception("Повторяющиеся точки.");

        }*/

        /// <summary>
        /// Создание фигуры в зависимости от входных параметров
        /// </summary>
        /// <param name="segments"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private static IShape ConstructorShape(List<double> segments)
        {
            if (segments is not null)
            {
                if (segments.Count() == 1)
                    return new Circle(segments.First());
                else
                    return new Triangle(segments.First(), segments[1], segments.Last());
            }
            else
                throw new Exception("Нет параметров - нет площади.");
        }

        private static IShape ConstructorShape(List<Point> points = null)
        {
            if (points is not null)
                {
                    return new ShapeN(points);
                }
                else
                    throw new Exception("Нет параметров - нет площади.");

        }

    }
}