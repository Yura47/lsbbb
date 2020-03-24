using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x1 = 0, y1 = 0, x2 = 0, y2 = 3, x3 = 4, y3 = 0;
            double result1 = LAB1_CSHARP.Program.Perimetr(x1, y1, x2, y2, x3, y3);
            Assert.AreEqual(12, result1);
            double result2 = LAB1_CSHARP.Program.Ploscha(x1, y1, x2, y2, x3, y3);
            Assert.AreEqual(6, result2);
        }
    }
}
