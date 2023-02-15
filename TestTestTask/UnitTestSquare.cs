using TestTask;
using TestWithSOLID;
using TestWithSOLID.Class;


namespace TestTestTask
{
    [TestClass]
    public class UnitTestSquare
    {
        /// <summary>
        /// ���� ������ �������� ������� ������������ �� 3-� ��������
        /// </summary>
        [TestMethod]
        public void TestSquareTreugolnikaOnthreesides()
        {
            double[,] mas = new double[,] { { -0.763, 7.738 }, { 17.188, 17.115 }, { 7.447, 36.052 } };
            List<Point> arr = new List<Point>();
            for (int i = 0; i < mas.Length / 2; i++)
            {
                arr.Add(new Point { X = mas[i, 0], Y = mas[i, 1] });
            }
            double result = Area.CalculationSquare(arr);
            Assert.AreEqual(215.6, Math.Round(result,1));
        }



        /// <summary>
        /// ���� ������ �������� ������� ��������������
        /// </summary>
        [TestMethod]
        public void TestSquarePolygon()
        {
            List<Point> arr = new List<Point>();
            double[,] mas = new double[,]{ { 0.000,0.000}, { -0.763, 7.738 }, { 17.188, 17.115 }, { 7.447, 36.052 }, { 14.154, 58.584 }, { -0.942, 37.863 }, { -3.633, 47.647 },
                                            { -17.659, 27.007 },{ -2.428, 19.790 },{ -11.183, 0.338 } } ;
            for (int i = 0; i < mas.Length / 2; i++)
            {
                arr.Add(new Point {X = mas[i,0], Y = mas[i,1]});
            }
            double result = Area.CalculationSquare(arr);
            Assert.AreEqual(817.894, Math.Round(result, 3));

        }

        [TestMethod]
        public void TestSquarePolygonExeptionMin()
        {
            List<Point> arr = new List<Point>();
            double[,] mas = new double[,]{{ -11.183, 0.338 } };
            for (int i = 0; i < mas.Length / 2; i++)
            {
                arr.Add(new Point { X = mas[i, 0], Y = mas[i, 1] });
            }
            
            var exception = Assert.ThrowsException<Exception>(() => Area.CalculationSquare(arr));

            Assert.AreEqual("��� ���������� ������� ��������� ������: ������� ���� ���������� ��� ����������.", exception.Message);


        }


        [TestMethod]
        public void TestSquarePolygonExeptionCopy()
        {
            List<Point> arr = new List<Point>();
            double[,] mas = new double[,] { { 0.000,0.000}, { 0.000,0.000}, { 17.188, 17.115 }, { 7.447, 36.052 }, { 7.447, 36.052 }, { -0.942, 37.863 }, { -3.633, 47.647 },
                                            { -17.659, 27.007 },{ -2.428, 19.790 },{ -11.183, 0.338 } };
            for (int i = 0; i < mas.Length / 2; i++)
            {
                arr.Add(new Point { X = mas[i, 0], Y = mas[i, 1] });
            }

            var exception = Assert.ThrowsException<Exception>(() => Area.CalculationSquare(arr));

            Assert.AreEqual("��� ���������� ������� ��������� ������: ������������� �����.", exception.Message);


        }

        /// <summary>
        /// ���� ������, ������������ ������� �������, ���� �������� ���������� 2-� �����
        /// </summary>
        [TestMethod]
        public void TestMethodCalculatorSquareCicrle()
        {
            double[,] mas = new double[,] { { 1, 2 }, { 0.0, 0.0 } };
            List<Point> arr = new List<Point>();
            for (int i = 0; i < mas.Length / 2; i++)
            {
                arr.Add(new Point { X = mas[i, 0], Y = mas[i, 1] });
            }
            double result = Area.CalculationSquare(arr);
            Assert.AreEqual(15.7, Math.Round(result, 1));
        }

    }
}