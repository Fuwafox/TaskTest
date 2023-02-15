using TestShape;



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
            double result = Area.CalculationSquare(mas);
            Assert.AreEqual(215.6, Math.Round(result,1));
        }



        /// <summary>
        /// ���� ������ �������� ������� ��������������
        /// </summary>
        [TestMethod]
        public void TestSquarePolygon()
        {
            double[,] mas = new double[,]{ { 0.000,0.000}, { -0.763, 7.738 }, { 17.188, 17.115 }, { 7.447, 36.052 }, { 14.154, 58.584 }, { -0.942, 37.863 }, { -3.633, 47.647 },
                                            { -17.659, 27.007 },{ -2.428, 19.790 },{ -11.183, 0.338 } } ;
            double result = Area.CalculationSquare(mas);
            Assert.AreEqual(817.894, Math.Round(result, 3));

        }


        /// <summary>
        /// �������� �� ���������� ��� �� ����������� ���-�� ����������
        /// </summary>
        [TestMethod]
        public void TestSquarePolygonExeptionMin()
        {
            double[,] mas = new double[,]{{ -11.183, 0.338 } };
            var exception = Assert.ThrowsException<Exception>(() => Area.CalculationSquare(mas));

            Assert.AreEqual("��� ���������� ������� ��������� ������: ������� ���� ���������� ��� ����������.", exception.Message);


        }

        /// <summary>
        /// �������� �� ������������� �����
        /// </summary>
        [TestMethod]
        public void TestSquarePolygonExeptionCopy()
        {
            double[,] mas = new double[,] { { 0.000,0.000}, { 0.000,0.000}, { 17.188, 17.115 }, { 7.447, 36.052 }, { 7.447, 36.052 }, { -0.942, 37.863 }, { -3.633, 47.647 },
                                            { -17.659, 27.007 },{ -2.428, 19.790 },{ -11.183, 0.338 } };
            var exception = Assert.ThrowsException<Exception>(() => Area.CalculationSquare(mas));

            Assert.AreEqual("��� ���������� ������� ��������� ������: ������������� �����.", exception.Message);


        }

        /// <summary>
        /// ���� ������, ������������ ������� ������� ����������, ���� �������� ���������� 2-� �����
        /// </summary>
        [TestMethod]
        public void TestMethodCalculatorSquareCicrle()
        {
            double[,] mas = new double[,] { { 1, 2 }, { 0.0, 0.0 } };
            double result = Area.CalculationSquare(mas);
            Assert.AreEqual(15.7, Math.Round(result, 1));
        }

    }
}