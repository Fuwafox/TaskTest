using TestShape;
using TestShape.Class;



namespace TestTestTask
{
    [TestClass]
    public class UnitTestSquare
    {
        /// <summary>
        /// “ест метода подсчета площади треугольника по 3-м сторонам
        /// </summary>
        [TestMethod]
        public void TestSquareTreugolnikaOnthreesides()
        {
            List<Point> mas = new List<Point>() { new Point() { X = -0.763, Y = 7.738 }, new Point() { X = 17.188, Y = 17.115 }, new Point() { X = 7.447, Y = 36.052 } };
            double result = Area.CalculationSquare(mas);
            Assert.AreEqual(215.6, Math.Round(result,1));
        }



        /// <summary>
        /// “ест метода рассчета площади многоугольника
        /// </summary>
        [TestMethod]
        public void TestSquarePolygon()
        {
            List<Point> mas = new List<Point>(){new Point() { X = 0.000, Y = 0.000}, new Point(){X = -0.763, Y = 7.738 }, new Point(){ X = 17.188, Y = 17.115 },new Point() { X = 7.447, Y = 36.052 }, 
                                                new Point(){ X = 14.154, Y = 58.584 },new Point() {X = -0.942, Y = 37.863 }, new Point(){ X = -3.633, Y = 47.647 },new Point(){ X = -17.659, Y = 27.007 },
                                                new Point(){ X = -2.428, Y = 19.790 },new Point(){ X = -11.183, Y = 0.338 } } ;
            double result = Area.CalculationSquare(mas);
            Assert.AreEqual(817.894, Math.Round(result, 3));

        }

        /// <summary>
        /// “ест метода, запускающего рассчет площади окружности, если получены координаты 3-х точек, где 2 повтор€ютс€
        /// </summary>
        [TestMethod]
        public void TestMethodCalculatorSquareCicrlewithCopy()
        {
            List<Point> mas = new List<Point>() { new Point() { X = 1, Y = 2 }, new Point() { X = 0.0, Y = 0.0 }, new Point() { X = 0.0, Y = 0.0 } };
            double result = Area.CalculationSquare(mas);
            Assert.AreEqual(15.7, Math.Round(result, 1));
        }

        /// <summary>
        /// ѕроверка исключени€ при недостаточном кол-ве параметров
        /// </summary>
        [TestMethod]
        public void TestMethodCalculatorSquarePoint()
        {
            List<Point> mas = new List<Point>() { new Point() { X = 0.0, Y = 0.0 }, new Point() { X = 0.0, Y = 0.0 } };
            var exception = Assert.ThrowsException<Exception>(() => Area.CalculationSquare(mas));
            Assert.AreEqual("ѕри вычислении площади произошла ошибка: Ќедостаточно точек дл€ посчета площади.", exception.Message);
        }

        /// <summary>
        /// “ест метода, запускающего рассчет площади окружности, если получены координаты 2-х точек
        /// </summary>
        [TestMethod]
        public void TestMethodCalculatorSquareCicrle()
        {
            List<Point> mas = new List<Point>() { new Point() {X = 1, Y = 2 }, new Point() { X = 0.0, Y = 0.0 } };
            double result = Area.CalculationSquare(mas);
            Assert.AreEqual(15.7, Math.Round(result, 1));
        }

    }
}