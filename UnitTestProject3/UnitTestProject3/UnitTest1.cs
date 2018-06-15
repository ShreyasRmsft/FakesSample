using System;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        protected IDisposable _shimsContext;
        [TestMethod]
        public void TestMethod1()
        {
            //System.Threading.Thread.Sleep(10 * 1000);
           // using (ShimsContext.Create())
           // {
           //     //System.Diagnostics.Debugger.Launch();
           //     Assert.IsTrue(true);
           //}

            this._shimsContext = ShimsContext.Create();
        }
    }
}
