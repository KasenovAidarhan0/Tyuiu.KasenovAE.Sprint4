using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint4.Task7.V12.Lib;

namespace Tyuiu.KasenovAE.Sprint4.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            string str = "658932125478";
            DataService ds = new DataService();
            Assert.AreEqual(ds.Calculate(4, 3, str), 30);
        }
    }
}
