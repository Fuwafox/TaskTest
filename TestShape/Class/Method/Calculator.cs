using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShape.Interface;

namespace TestShape.Class.Method
{
    static class Calculator
    {
        public static IEnumerable<double> СalculationoftheSegment(List<Point> listpoint)
        {
            try
            {
                List<double> result= new List<double>();
                double segment = 0;
                if (listpoint.Count == 2)
                {
                    segment = Math.Sqrt(Math.Pow(listpoint.Last().X - listpoint.First().X, 2) +
                                            Math.Pow(listpoint.Last().Y - listpoint.First().Y, 2));
                    result.Add(segment);
                }
                else
                {
                    for (int i = 0; i < listpoint.Count(); i++)
                    {

                        if (i == listpoint.Count() - 1)
                        {
                            segment = Math.Sqrt(Math.Pow(listpoint.Last().X - listpoint.First().X, 2) +
                                                 Math.Pow(listpoint.Last().Y - listpoint.First().Y, 2));                            
                        }
                        else
                            segment = Math.Sqrt(Math.Pow(listpoint[i + 1].X - listpoint[i].X, 2) +
                                                 Math.Pow(listpoint[i + 1].Y - listpoint[i].Y, 2));
                        result.Add(segment);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("При вычислении длинны отрезка произошла ошибка", ex);
            }
        }

        public static double Sum(double seg1, double seg2)
        {
            double result = 0;
            try
            {
                result = Math.Pow(seg1, 2) + Math.Pow(seg2, 2);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public static double СalculationoPerimeter(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }
    }
}
