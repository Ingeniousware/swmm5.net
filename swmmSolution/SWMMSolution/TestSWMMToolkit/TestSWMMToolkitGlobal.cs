using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWMMToolkitWrapper;

namespace TestSWMMToolkit
{
    [TestClass]
    public class TestSWMMToolkitGlobal
    {
        string f1 = "Afshar.inp";
        string f2 = "Afshar.rpt";
        string f3 = "Afshar.out";

        [TestMethod]
        public void TestMethodOpen()
        {
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Open(f1, f2, f3);

            Assert.AreEqual(0, error);
           
        }

        [TestMethod]
        public void TestMethodRun()
        {
            var toolkitSWMM = new SWMMToolkit();

            int error = toolkitSWMM.Run(f1, f2, f3);

            Assert.AreEqual(0, error);

        }

        [TestMethod]
        public void TestMethodGetNodeValue()
        {
            var toolkitSWMM = new SWMMToolkit();

            

            Assert.AreEqual(0, error);

        }
    }
}
