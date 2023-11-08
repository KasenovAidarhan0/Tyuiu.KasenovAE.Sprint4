using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KasenovAE.Sprint4.Task7.V12.Lib
{
    public class DataService : ISprint4Task7V12
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[m, n];
            int count = 0;
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    mtrx[i, j] = Convert.ToInt32(Convert.ToString(value[count]));
                    count++;                   
                }
            }
            int sum = 0;
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    if (mtrx[i, j] % 2 != 0)
                        sum += mtrx[i, j];
                }
            }
            return sum;
        }
    }
}
