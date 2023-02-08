using TestTask;

namespace TestTestTask
{
    [TestClass]
    public class UnitTestSquare
    {
        [TestMethod]
        ///Тест метода Sum
        public void TestSum()
        {
            double a = 2;
            double b = 3;
            double result = Calculator.Sum(a, b);
            Assert.AreEqual(13, result);
        }

        /// <summary>
        /// Тест метода CheckEmpty (проверка на 2 и более нулевых координаты для круга и треугольника)
        /// </summary>
        [TestMethod]
        public void TestCheckEmpty()
        {
            double[,] arr = new double[,] { { 1, 2 }, { 0, 0 }, { 0, 0 } };
            bool result = Calculator.CheckEmpty(arr);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Тест подсчета периметра
        /// </summary>
        [TestMethod]
        public void TestСalculationoPerimeter()
        {
            double a = 1, b = 2, c = 3;
            double result = Calculator.СalculationoPerimeter(a, b, c);
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// Тест метода подсчета площади треугольника по 3-м сторонам
        /// </summary>
        [TestMethod]
        public void TestSquareTreugolnikaOnthreesides()
        {
            double a = 3, b = 4, c = 5;
            double result = Calculator.SquareTreugolnikaOnthreesides(a, b, c);
            Assert.AreEqual(6, result);
        }

        /// <summary>
        /// Тест метода подсчета площади прямоугольного треугольника
        /// </summary>
        [TestMethod]
        public void TestSquareRightTriangle()
        {
            double a = 3, b = 4, c = 5;
            double result = Calculator.SquareRightTriangle(a, b, c);
            Assert.AreEqual(6, result);
        }

        /// <summary>
        /// Тест метода вычисления отрезка под двум точкам
        /// </summary>
        [TestMethod]
        public void TestСalculationoftheSegment()
        {
            double[,] arr = new double[,] { { 0, 3 }, { 4, 0 } };
            double result = Calculator.СalculationoftheSegment(arr[0, 0], arr[0, 1], arr[1, 0], arr[1, 1]);
            Assert.AreEqual(5, result);
        }

        /// <summary>
        /// Тест метода проверяющего прямоугольный ли треугольник
        /// </summary>
        [TestMethod]
        public void TestСheckingForRightAngles()
        {
            double a = 3, b = 4, c = 5;
            bool result = Calculator.СheckingForRightAngles(a, b, c);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Тест метода рассчета площади окружности по радиусу
        /// </summary>
        [TestMethod]
        public void TestCicrleSquare()
        {
            double[,] arr = new double[,] { { 1, 2 }, { 0.0, 0.0 } };
            double result = Calculator.CicrleSquare(arr);
            Assert.AreEqual(15.7, Math.Round(result, 1));
        }

        /// <summary>
        /// Тест метода рассчета площади многоугольника и главного метода, запускающего рассчет площади
        /// </summary>
        [TestMethod]
        public void TestSquarePolygon()
        {
            double[,] arr = new double[,] { { 0.000, 0.000 }, { -0.763, 7.738 }, { 17.188, 17.115 }, { 7.447, 36.052 }, { 14.154, 58.584 }, { -0.942, 37.863 }, { -3.633, 47.647 },
                                            { -17.659, 27.007 },{ -2.428, 19.790 },{ -11.183, 0.338 }};
            double result = Calculator.CalculatorSquare(arr);
            Assert.AreEqual(817.894, Math.Round(result, 3));

        }
        
        /// <summary>
        /// Тест метода, запускающего рассчет площади, если получины координаты 2-х точек
        /// </summary>
        [TestMethod]
        public void TestMethodCalculatorSquareCicrle()
        {
            double[,] arr = new double[,] { { 1, 2 }, { 0.0, 0.0 } };
            double result = Calculator.CalculatorSquare(arr);
            Assert.AreEqual(15.7, Math.Round(result, 1));
        }

    }
}