using TestShape.Interface;

namespace TestShape.Class.Shape
{
    /// <summary>
    /// Неопределенная фигура
    /// </summary>
    public class ShapeN:IShape
    {
        public List<Point> ListPoint { get;}
        public ShapeN(List<Point> points = null) 
        {
            if ((points == null) || (points.Count() == 1))
                throw new Exception("Недостаточно точек для посчета площади.");
            else
                this.ListPoint = points;
        }

        /// <summary>
        /// Вычисление площади по точкам
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double Square()
        {
            double _result;
            double _sum1 = 0, _sum2 = 0;
            try
            {
                for (int i = 0; i < ListPoint.Count - 1; i++)
                {
                    _sum1 = _sum1 + ListPoint[i].X * ListPoint[i+1].Y - ListPoint[i + 1].X * ListPoint[i].Y;
                }
                _sum2 = _sum1 + (ListPoint.Last().X * ListPoint.First().Y) - (ListPoint.First().X * ListPoint.Last().Y);
                _result = 0.5 * Math.Abs(_sum2);
                return _result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        
    }
}
