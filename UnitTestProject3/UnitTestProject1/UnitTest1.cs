using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.Fail(Environment.GetEnvironmentVariable("COR_PROFILER_PATH_32") + "***" + Environment.GetEnvironmentVariable("COR_PROFILER_PATH_64"));
        }
    }
}
