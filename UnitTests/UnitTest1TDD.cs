using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1TDD
    {
        [TestMethod]
        public void AddTest()
        {
            ELEducationSample.Calculator c = new ELEducationSample.Calculator();
            int res = c.Add(40, 10);
            Assert.AreEqual(res, 50);
            string result = c.DebugWrite(res);
            Assert.AreEqual(result, res.ToString());
        }
        [TestMethod]
        public void SubtractTest()
        {
            ELEducationSample.Calculator c = new ELEducationSample.Calculator();
            int res = c.Subtract(20, 10);
            Assert.AreEqual(res, 10);
            string result = c.DebugWrite(res);
            Assert.AreEqual(result, res.ToString());
        }
        [TestMethod]
        public void DivideTest()
        {
            ELEducationSample.Calculator c = new ELEducationSample.Calculator();
            int res = c.Divide(50, 5);
            Assert.AreEqual(res, 10);
            string result = c.DebugWrite(res);
            Assert.AreEqual(result, res.ToString());
        }
        [TestMethod]
        public void MultiplyTest()
        {
            ELEducationSample.Calculator c = new ELEducationSample.Calculator();
            int res = c.Multiply(10, 5);
            Assert.AreEqual(res, 50);
            string result = c.DebugWrite(res);
            Assert.AreEqual(result, res.ToString());
        }
    }
}
