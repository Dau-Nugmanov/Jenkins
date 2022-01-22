using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cls = new Class1();
            var res = cls.doWork(1);
            Assert.AreEqual(1, res); 
        }

        [TestMethod]
        public void TestMutliplierTwo()
        {
            var cls = new Class1();
            var one = cls.MutliplierTwo(1);
            Assert.AreEqual(2, one);

            var negativeValue = cls.MutliplierTwo(-1);
            Assert.AreEqual(-2, negativeValue);
        }
    }
}
