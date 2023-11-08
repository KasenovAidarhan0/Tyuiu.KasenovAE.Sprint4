using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint4.Task4.V14.Lib;

namespace Tyuiu.KasenovAE.Sprint4.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            int[,] mat = new int[,] { { 1, 3, 7, 7, 6 }, 
                                      { 4, 2, 6, 3, 3 },
                                      { 4, 5, 1, 4, 6 },
                                      { 7, 5, 2, 7, 7 },
                                      { 2, 4, 4, 4, 7 } };

            int[,] res = new int[,] { { 0, 0, 0, 0, 6 },
                                      { 4, 2, 6, 0, 0 },
                                      { 4, 0, 0, 4, 6 },
                                      { 0, 0, 2, 0, 0 },
                                      { 2, 4, 4, 4, 0 } };

            DataService ds = new DataService();
            CollectionAssert.AreEqual(ds.Calculate(mat), res);
        }
    }
}
