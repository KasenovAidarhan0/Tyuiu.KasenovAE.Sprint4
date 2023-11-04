using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KasenovAE.Sprint4.Task3.V9.Lib
{
    public class DataService : ISprint4Task3V9
    {
        public int Calculate(int[,] array)
        {
            int res = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                res += array[i, 1];
            }
            return res;
        }
    }
}
