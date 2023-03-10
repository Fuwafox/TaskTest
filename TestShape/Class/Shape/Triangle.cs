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

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double Square()
        {
            try
            {
                double perimeter = Calculator.СalculationoPerimeter(A, B, C);
                double result = Math.Sqrt(perimeter * (perimeter - A) * (perimeter - B) * (perimeter - C));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        /// <summary>
        /// Провера прямоугльного треугольника
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool СheckingForRightAngles()
        {
            bool result = false;
            try
            {
                if ((Math.Pow(A, 2) == Calculator.Sum(C, B)) || (Math.Pow(C, 2) == Calculator.Sum(A, B)) || (Math.Pow(B, 2) == Calculator.Sum(C, A)))
                    result = true;
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


    }
}
