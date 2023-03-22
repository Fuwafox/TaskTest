using TestShape.Class.Method;
using TestShape.Interface;

namespace TestShape.Class.Shape
{
    /// <summary>
    /// Фигура окружность
    /// </summary>
    public class Circle : IShape
    {
        internal readonly double Radius;
        public Circle(IEnumerable<Point> points) 
        {
            this.Radius = Calculator.СalculationoftheSegment(points.First(),  points.Last());
        }
        
        /// <summary>
        /// Вычисление площади по радиусу
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double Square()
        {
            return double.Pi * Math.Pow(Radius, 2);          
        }

    }
}
