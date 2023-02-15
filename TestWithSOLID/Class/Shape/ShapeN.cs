﻿using TestTask.Interface;
using TestWithSOLID.Interface;

namespace TestWithSOLID.Class.Shape
{
    public class ShapeN:IShape
    {
        public List<IPoint> ListPoint { get;}
        public ShapeN(List<Point> listpoint) 
        {
            this.ListPoint = new List<IPoint>(listpoint);
        }
        public double Square()
        {
            double result;
            double sum1 = 0, sum2 = 0;
            try
            {
                for (int i = 0; i < ListPoint.Count - 1; i++)
                {
                    sum1 = sum1 + ListPoint[i].X * ListPoint[i+1].Y - ListPoint[i + 1].X * ListPoint[i].Y;
                }
                sum2 = sum1 + (ListPoint.Last().X * ListPoint.First().Y) - (ListPoint.First().X * ListPoint.Last().Y);
                result = 0.5 * Math.Abs(sum2);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        
    }
}