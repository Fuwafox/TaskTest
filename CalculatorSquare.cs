﻿using System.Threading;

namespace TestTask
{
    /// <summary>
    /// Вообще методы, которые не относятся к доступных для вычисления площади не должны быть публичными, но оставляю так из-за тестов
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Общий метод для вычисления площади с проверками на тип фигуры
        /// </summary>
        /// <param name="arrayСoordinates"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static double CalculatorSquare(double[,] arrayCoordinates)
        {
            try
            {
                double result  ;
                if (arrayCoordinates.Length == 0 || arrayCoordinates == null)
                    throw new Exception("Вы ничего не ввели.");
                if (arrayCoordinates.Length < 4)
                    throw new Exception("Точка - это не фигура.");
                else
                {
                    if (arrayCoordinates.Length % 2 != 0)
                        throw new Exception("Кажется вы потеряли одну координату.");
                    else
                    {
                        if (arrayCoordinates.Length == 4)
                        {
                            if (CheckEmpty(arrayCoordinates))
                                throw new Exception("Точка - это не фигура.");
                            else
                            {
                                result = CicrleSquare(arrayCoordinates);
                                return result;
                            }
                        }
                        else
                        {
                            if (arrayCoordinates.Length == 6)
                            {
                                if (CheckEmpty(arrayCoordinates))
                                    throw new Exception("Две из трёх точек cовпадают по координатам. Площадь треугольника не возможно посчитать по одному отрезку");
                                else
                                {
                                    result = STriangle(arrayCoordinates);
                                    return result;
                                }
                            }
                            else
                            {
                                result = SquarePolygon(arrayCoordinates);
                                return result;
                            }
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message, ex);               
            }
        }

        /// <summary>
        /// Проверка для треугольника и круга на 0 в координатах
        /// </summary>
        /// <param name="arrayСoordinates"></param>
        /// <returns></returns>
        public static bool CheckEmpty(double[,] arrayCoordinates)
        {
            int j = 0;
            bool result = false;
            for (int i = 0; i < (arrayCoordinates.Length / 2)-1 ; i++)
            {
                for (int k = i+1 ; k < (arrayCoordinates.Length / 2); k++)
                {
                   if ((arrayCoordinates[i,0] == arrayCoordinates[k,0]) && (arrayCoordinates[i, 1] == arrayCoordinates[k, 1]))
                       j++;
                }
            }
            if (j >= 1)
                result = true;
            return result; 
        }
        /// <summary>
        /// Вычисление площади круга по радиусу
        /// </summary>
        /// <param name="arrayСoordinates"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static double CicrleSquare(double[,] arrayCoordinates)
        {
            double _radius;
            double result;
            try
            {
                _radius = СalculationoftheSegment(arrayCoordinates[0, 0], arrayCoordinates[0, 1], arrayCoordinates[1, 0], arrayCoordinates[1, 1]);
                result = double.Pi * Math.Pow(_radius, 2);
                return result;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }

        }

        /// <summary>
        /// Вычисление длинны отрезка по координатам двух точек
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Метод для выявления по какой формуле вычислять площадь треугольника
        /// </summary>
        /// <param name="arrayСoordinates"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static double STriangle(double[,] arrayCoordinates)
        {
            double A, B, C;
            double result;
            try
            { 
                A = СalculationoftheSegment(arrayCoordinates[0, 0], arrayCoordinates[0, 1], arrayCoordinates[1, 0], arrayCoordinates[1, 1]);
                C = СalculationoftheSegment(arrayCoordinates[0, 0], arrayCoordinates[0, 1], arrayCoordinates[2, 0], arrayCoordinates[2, 1]);
                B = СalculationoftheSegment(arrayCoordinates[1, 0], arrayCoordinates[1, 1], arrayCoordinates[2, 0], arrayCoordinates[2, 1]);
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

        /// <summary>
        /// Проверка прямоугольный ли треугольник
        /// </summary>
        /// <param name="ab"></param>
        /// <param name="ac"></param>
        /// <param name="bc"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Метод для подсчета суммы квадратов двух сторон
        /// </summary>
        /// <param name="seg1"></param>
        /// <param name="seg2"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Вычисление площади треугольника по 3-м сторонам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Вычиление периметра по 3 сторонам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double СalculationoPerimeter(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }

        /// <summary>
        /// Вычисление площади прямоугольного треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Сам посчет площади прямоугольного треугольника вынесен в отдельный метод
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double SquareTriangle(double a, double b) 
        {
            return (a * b) / 2;
        }

        /// <summary>
        /// Вычисление площади многоугольника
        /// </summary>
        /// <param name="arrayСoordinates"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static double SquarePolygon(double[,] arrayCoordinates)
        {
            double result;
            double sum1 = 0, sum2 = 0;
            try
            {
                for (int i = 0; i < (arrayCoordinates.Length/2)-1 ; i++)
                {
                    sum1 = sum1 + arrayCoordinates[i, 0] * arrayCoordinates[i + 1, 1] - arrayCoordinates[i + 1, 0] * arrayCoordinates[i, 1];
                }
                sum2 = sum1 + (arrayCoordinates[(arrayCoordinates.Length / 2) - 1, 0] * arrayCoordinates[0, 1]) - (arrayCoordinates[(arrayCoordinates.Length / 2) - 1, 1] * arrayCoordinates[0, 0]);
                result = 0.5*Math.Abs(sum2);
                return result;
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message,ex);
            }
        }
    }
}