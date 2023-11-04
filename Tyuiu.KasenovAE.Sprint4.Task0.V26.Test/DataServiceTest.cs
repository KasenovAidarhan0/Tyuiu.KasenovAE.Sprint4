using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint4.Task0.V26.Lib;

namespace Tyuiu.KasenovAE.Sprint4.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumOddArrEl_Test()
        {
            int[] arr = new int[] { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int sum = 41;
            DataService ds = new DataService();
            Assert.AreEqual(sum, ds.GetSumOddArrEl(arr));
        }
    }
}
