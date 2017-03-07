using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWMMToolkitWrapper;

namespace TestSWMMToolkit
{
    [TestClass]
    public class TestSWMMToolkitGlobal
    {
        [TestMethod]
        public void TestMethod1()
        {
            var toolkitSWMM = new SWMMToolkit();

            string f1 = "";
            string f2 = "";
            string f3 = "";

            int error = toolkitSWMM.Open(f1, f2, f3);

            Assert.AreEqual(0, error);
           
        }
    }
}
