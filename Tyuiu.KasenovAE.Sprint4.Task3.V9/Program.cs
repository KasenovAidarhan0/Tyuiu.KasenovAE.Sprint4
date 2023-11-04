using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KasenovAE.Sprint4.Task3.V9.Lib;

namespace Tyuiu.KasenovAE.Sprint4.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Касенов А. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Касенов Айдархан Есенаевич | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 9.                          *");
            Console.WriteLine("* Найдите сумму элементов во втором столбце массива.                      *");
            Console.WriteLine("* 9, 6, 4, 5, 3,                                                          *");
            Console.WriteLine("* 7, 4, 7, 5, 3,                                                          *");
            Console.WriteLine("* 8, 5, 9, 9, 3,                                                          *");
            Console.WriteLine("* 7, 8, 7, 9, 3,                                                          *");
            Console.WriteLine("* 3, 7, 3, 7, 7,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] arr = new int[5, 5] { { 9, 6, 4, 5, 3},
                                         { 7, 4, 7, 5, 3},
                                         { 8, 5, 9, 9, 3},
                                         { 7, 8, 7, 9, 3},
                                         { 3, 7, 3, 7, 7} };
            Console.WriteLine(" Массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine(ds.Calculate(arr));
            Console.ReadKey();
        }
    }
}
