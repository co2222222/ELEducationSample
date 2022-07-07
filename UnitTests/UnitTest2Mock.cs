using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    public class MockCalc : ELEducationSample.IDebugWrite
    {
        public String DebugWrite(int result)
        {
            return result.ToString();
        }

        public void DebugWriteToDB(string operation, int result)
        {
            throw new NotImplementedException();
        }
    }

    [TestClass]
    public class UnitTest2Mock
    {
        [TestMethod]
        public void TestDebugMethodWithMock()
        {
            MockCalc mock = new MockCalc();
            string result = mock.DebugWrite(2);
            Assert.AreEqual(result, 2.ToString());
        }

    }
}
