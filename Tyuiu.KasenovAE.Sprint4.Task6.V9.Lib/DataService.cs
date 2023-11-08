﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KasenovAE.Sprint4.Task6.V9.Lib
{
    public class DataService : ISprint4Task6V9
    {
        public int Calculate(string[] array)
        {
            string[] arr = Array.FindAll(array, i => i.Length < 7);
            return arr.Length;
        }
    }
}
