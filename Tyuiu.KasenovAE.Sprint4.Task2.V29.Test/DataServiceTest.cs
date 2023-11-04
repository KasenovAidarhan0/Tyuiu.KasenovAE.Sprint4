using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint4.Task2.V29.Lib;

namespace Tyuiu.KasenovAE.Sprint4.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            int[] arr = new int[] { 5, 4, 8, 3, 5, 2, 8, 6, 6, 8, 6 };
            DataService ds = new DataService();
            Assert.AreEqual(ds.Calculate(arr), 884736);
        }
    }
}
