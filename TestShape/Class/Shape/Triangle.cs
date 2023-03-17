using TestShape.Class.Method;
using TestShape.Interface;

namespace TestShape.Class.Shape
{
    /// <summary>
    /// Фигура треугольник
    /// </summary>
    public class Triangle:IShape
    {
        public double A { get;}
        public double B { get;}
        public double C { get;}

        public Triangle(Point a, Point b, Point c)
        {
            this.A = Calculator.СalculationoftheSegment(a, b);
            this.B = Calculator.СalculationoftheSegment(b, c);
            this.C = Calculator.СalculationoftheSegment(a, c);
        }
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double Square()
        {
            double _perimeter = Calculator.СalculationoPerimeter(A, B, C);
            return Math.Sqrt(_perimeter * (_perimeter - A) * (_perimeter - B) * (_perimeter - C));

        }

        /// <summary>
        /// Провера прямоугльного треугольника
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool СheckingForRightAngles()
        {
            bool _result = false;
            try
            {
                if ((Math.Pow(A, 2) == Calculator.Sum(C, B)) || (Math.Pow(C, 2) == Calculator.Sum(A, B)) || (Math.Pow(B, 2) == Calculator.Sum(C, A)))
                    _result = true;
                return _result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


    }
}
