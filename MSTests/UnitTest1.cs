using System;
using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests
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
    }
}
