using TestShape.Interface;

namespace TestShape.Class.Shape
{
    /// <summary>
    /// Фигура окружность
    /// </summary>
    public class Circle : IShape
    {
        public double Radius { get;}
        public Circle(double radius) 
        {
            this.Radius = radius;
        }
        
        /// <summary>
        /// Вычисление площади по радиусу
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double Square()
        {
            double result;
            try
            {
                result = double.Pi * Math.Pow(Radius, 2);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

    }
}
