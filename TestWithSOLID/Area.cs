using System.Runtime.ConstrainedExecution;
using TestTask.Interface;
using TestWithSOLID.Class.Method;
using TestWithSOLID.Class.Shape;
using TestWithSOLID.Interface;
using TestWithSOLID.Class;

namespace TestWithSOLID
{
    public static class Area
    {

        public static double CalculationSquare(List<Point> points)
        {
            try
            {
                if ((points.Count < 2) || (points is null))
                    throw new Exception("Слишком мало параметров для вычисления.");
                else
                {
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

        private static bool CheckEmpty (List<Point> points) 
        {
            bool result = false;
            IEnumerable<Point> listcur = points.Distinct();
            if (listcur.Count()<points.Count())
                result= true;
            return result;

        }

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