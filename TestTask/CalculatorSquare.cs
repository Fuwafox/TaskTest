using System.Threading;

namespace TestTask
{
    public static class Calculator
    {

        public static double? CalculatorSquare(double[,] arrayСoordinates)
        {
            try
            {
                double? result = null;
                
                    if (arrayСoordinates.Length == 2)
                    {
                        result = CicrleSquare(arrayСoordinates);
                        return result;
                    }
                    else
                    {
                        if (arrayСoordinates.Length == 3)
                        {
                            result = STriangle(arrayСoordinates);
                        }
                        else
                        {
                            if (arrayСoordinates.Length > 3)
                                result = SquarePolygon(arrayСoordinates);
                        }
                        return result;
                    }                 
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message, ex);               
            }
        }

        public static double CicrleSquare(double[,] arrayСoordinates)
        {
            double _radius;
            double result;
            try
            {
                _radius = СalculationoftheSegment(arrayСoordinates[0, 0], arrayСoordinates[0, 1], arrayСoordinates[1, 0], arrayСoordinates[1, 1]);
                result = double.Pi * Math.Pow(_radius, 2);
                return result;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public static double СalculationoftheSegment(double x1, double y1, double x2, double y2)
        {
            try
            {
                double result = Math.Sqrt(Math.Pow((x2 - x1), 2) +
                                     Math.Pow((y2 - y1), 2));
                return result;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public static double STriangle(double[,] arrayСoordinates)
        {
            double A, B, C;
            double result;
            try
            { 
                A = СalculationoftheSegment(arrayСoordinates[0, 0], arrayСoordinates[0, 1], arrayСoordinates[1, 0], arrayСoordinates[1, 1]);
                C = СalculationoftheSegment(arrayСoordinates[0, 0], arrayСoordinates[0, 1], arrayСoordinates[2, 0], arrayСoordinates[2, 1]);
                B = СalculationoftheSegment(arrayСoordinates[1, 0], arrayСoordinates[1, 1], arrayСoordinates[2, 0], arrayСoordinates[2, 1]);
                if (!СheckingForRightAngles(A, B, C))
                    result = SquareTreugolnikaOnthreesides(A, B, C);
                else
                {
                    result = SquareRightTriangle(A, B, C);
                }
                return result;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public static bool СheckingForRightAngles(double ab, double ac, double bc)
        {
            bool result = false ;
            try
            {
                if ((Math.Pow(ab, 2) == Sum(ac, bc)) || (Math.Pow(ac, 2) == Sum(ab, bc)) || (Math.Pow(bc, 2) == Sum(ac, ab)))
                    result = true;
                return result;
            }
            catch(Exception ex)
            {
              throw new Exception(ex.Message,ex);   
            }
        }

        public static double Sum(double seg1, double seg2)
        {
            double result = 0 ;
            try
            {
                result = Math.Pow(seg1, 2) + Math.Pow(seg2, 2);
                return result;
            }
            catch(Exception ex)
            { 
                throw new Exception(ex.Message,ex);
            }

        }

        public static double SquareTreugolnikaOnthreesides(double a, double b, double c)
        {
            try
            {
                double perimeter = СalculationoPerimeter(a, b, c);
                double result = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
                return result;
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message,ex);
            }
        }

        public static double СalculationoPerimeter(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }

        public static double SquareRightTriangle(double a, double b, double c)
        {
            double result;
            try
            {
                if ((a > b) && (a > c))
                {
                    result = SquareTriangle(b, c);
                }
                else
                {
                    if ((b > a) && (b > c))
                    {
                        {
                            result = SquareTriangle(a, c);
                        }
                    }
                    else
                        result = SquareTriangle(a, b);

                }
                return result;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public static double SquareTriangle(double a, double b) 
        {
            return (a * b) / 2;
        }

        public static double SquarePolygon(double[,] arrayСoordinates)
        {
            double result;
            double sum1 = 0, sum2 = 0;
            try
            {
                for (int i = 0; i < arrayСoordinates.Length - 2; i++)
                {
                    sum1 = sum1 + arrayСoordinates[i, 0] * arrayСoordinates[i + 1, 1];
                    sum2 = sum2 - arrayСoordinates[i + 1, 0] * arrayСoordinates[i, 1];
                }
                result = (1 / 2) * Math.Abs(sum1 + arrayСoordinates[arrayСoordinates.Length - 1, 0] * arrayСoordinates[0, 1] - sum2 - arrayСoordinates[arrayСoordinates.Length - 1, 1] * arrayСoordinates[0, 0]);
                return result;
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message,ex);
            }
        }
    }
}