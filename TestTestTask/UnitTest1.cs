using TestTask;

namespace TestTestTask
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            double a = 2;
            double b = 3;
            double result = Calculator.Sum(a, b);
            Assert.AreEqual(13, result);
        }
    }
}