using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint4.Task6.V9.Lib;

namespace Tyuiu.KasenovAE.Sprint4.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            DataService ds = new DataService();
            string[] arr = new string[] { "Красный", "Оранжевый", "Желтый", "Зеленый",
                                        "Синий", "Индиго", "Фиолетовый" };
            Assert.AreEqual(ds.Calculate(arr), 3);
        }
    }
}
