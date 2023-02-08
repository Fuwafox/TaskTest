using TestTask;

namespace TestTestTask
{
    [TestClass]
    public class UnitTestSquare
    {
        [TestMethod]
        ///���� ������ Sum
        public void TestSum()
        {
            double a = 2;
            double b = 3;
            double result = Calculator.Sum(a, b);
            Assert.AreEqual(13, result);
        }

        /// <summary>
        /// ���� ������ CheckEmpty (�������� �� 2 � ����� ������� ���������� ��� ����� � ������������)
        /// </summary>
        [TestMethod]
        public void TestCheckEmpty()
        {
            double[,] arr = new double[,] { { 1, 2 }, { 0, 0 }, { 0, 0 } };
            bool result = Calculator.CheckEmpty(arr);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// ���� �������� ���������
        /// </summary>
        [TestMethod]
        public void Test�alculationoPerimeter()
        {
            double a = 1, b = 2, c = 3;
            double result = Calculator.�alculationoPerimeter(a, b, c);
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// ���� ������ �������� ������� ������������ �� 3-� ��������
        /// </summary>
        [TestMethod]
        public void TestSquareTreugolnikaOnthreesides()
        {
            double a = 3, b = 4, c = 5;
            double result = Calculator.SquareTreugolnikaOnthreesides(a, b, c);
            Assert.AreEqual(6, result);
        }

        /// <summary>
        /// ���� ������ �������� ������� �������������� ������������
        /// </summary>
        [TestMethod]
        public void TestSquareRightTriangle()
        {
            double a = 3, b = 4, c = 5;
            double result = Calculator.SquareRightTriangle(a, b, c);
            Assert.AreEqual(6, result);
        }

        /// <summary>
        /// ���� ������ ���������� ������� ��� ���� ������
        /// </summary>
        [TestMethod]
        public void Test�alculationoftheSegment()
        {
            double[,] arr = new double[,] { { 0, 3 }, { 4, 0 } };
            double result = Calculator.�alculationoftheSegment(arr[0, 0], arr[0, 1], arr[1, 0], arr[1, 1]);
            Assert.AreEqual(5, result);
        }

        /// <summary>
        /// ���� ������ ������������ ������������� �� �����������
        /// </summary>
        [TestMethod]
        public void Test�heckingForRightAngles()
        {
            double a = 3, b = 4, c = 5;
            bool result = Calculator.�heckingForRightAngles(a, b, c);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// ���� ������ �������� ������� ���������� �� �������
        /// </summary>
        [TestMethod]
        public void TestCicrleSquare()
        {
            double[,] arr = new double[,] { { 1, 2 }, { 0.0, 0.0 } };
            double result = Calculator.CicrleSquare(arr);
            Assert.AreEqual(15.7, Math.Round(result, 1));
        }

        /// <summary>
        /// ���� ������ �������� ������� �������������� � �������� ������, ������������ ������� �������
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
        /// ���� ������, ������������ ������� �������, ���� �������� ���������� 2-� �����
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