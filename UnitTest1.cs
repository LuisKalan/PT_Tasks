using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator cal = new Calculator();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, cal.add(2, 2));
        }
    }
}