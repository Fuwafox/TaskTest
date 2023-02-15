using System.Runtime.ConstrainedExecution;
using TestTask.Interface;
using TestWithSOLID.Class.Method;
using TestWithSOLID.Class.Shape;
using TestWithSOLID.Interface;
using TestWithSOLID.Class;

namespace TestWithSOLID
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
                if ((mas.Length/2 < 2) || (mas is null) || (mas.Length% 2 != 0))
                    throw new Exception("Слишком мало параметров для вычисления.");
                else
                {
                    List<Point> points = new List<Point>();
                    points = Adapter.ListPoint(mas);
                    if (CheckEmpty(points))
                        throw new Exception("Повторяющиеся точки.");
                    else
                    {
                        if (points.Count > 3)
                        {
                            var shape = ConstructorShape(null, points);
                            return shape.Square();
                        }
                        else
                        {
                            var listSegment = new List<double>(Calculator.СalculationoftheSegment(points));
                            var shape = ConstructorShape(listSegment);
                            return shape.Square();
                        }
                                                
                           
                    }

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
        private static bool CheckEmpty (List<Point> points) 
        {
            bool result = false;
            IEnumerable<Point> listcur = points.Distinct();
            if (listcur.Count()<points.Count())
                result= true;
            return result;

        }

        /// <summary>
        /// Создание фигуры в зависимости от входных параметров
        /// </summary>
        /// <param name="segments"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private static IShape ConstructorShape(List<double> segments = null, List<Point> points = null)
        {
            if (segments is not null)
            {
                if (segments.Count() == 1)
                    return new Circle(segments.First());
                else
                    return new Triangle(segments.First(), segments[1], segments.Last());
            }
            else
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
}