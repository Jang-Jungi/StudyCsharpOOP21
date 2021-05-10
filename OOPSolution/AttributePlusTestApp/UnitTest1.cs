using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributePlusTestApp;

namespace AttributePlusTestApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyClass myclass = new();
            int a = 3; int b = 5;
            var result = myclass.Plus(a, b);

            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void DivideTest()
        {
            MyClass myclass = new();
            int a = 10; int b = 3;
            var result = myclass.Divide(a, b);

            Assert.AreEqual(8, result);
        }
    }

    internal class MyClass
    {
        public int Plus(int a, int b) { return a + b; }
        public int Divide(int a, int b) { return a / b; }
    }
}
