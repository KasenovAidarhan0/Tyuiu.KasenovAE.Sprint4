﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint4.Task3.V9.Lib;

namespace Tyuiu.KasenovAE.Sprint4.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            int[,] arr = new int[5, 5] { { 9, 6, 4, 5, 3},
                                         { 7, 4, 7, 5, 3},
                                         { 8, 5, 9, 9, 3},
                                         { 7, 8, 7, 9, 3},
                                         { 3, 7, 3, 7, 7} };

            DataService ds = new DataService();
            Assert.AreEqual(ds.Calculate(arr), 30);

        }
    }
}
