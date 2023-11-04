using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KasenovAE.Sprint4.Task2.V29.Lib;

namespace Tyuiu.KasenovAE.Sprint4.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Касенов А. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Касенов Айдархан Есенаевич | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 1 до 8 подсчитать произведение четных         *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] arr = new int[11];
            Random rnd = new Random();
            Console.WriteLine(" Массив:");
            for (int i = 0; i < 11; i++)
            {
                arr[i] = rnd.Next(1, 8);
                Console.Write(arr[i] + "\t");
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
