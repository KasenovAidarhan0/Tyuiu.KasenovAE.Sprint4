using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KasenovAE.Sprint4.Task6.V9.Lib;

namespace Tyuiu.KasenovAE.Sprint4.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Касенов А. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Касенов Айдархан Есенаевич | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных  [\"Красный\", \"Оранжевый\", \"Желтый\",   *");
            Console.WriteLine("* \"Зеленый\", \"Синий\", \"Индиго\", \"Фиолетовый\"] используя класс     *");
            Console.WriteLine("* Array подсчитайте количество элементов, длина которых меньше 7.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] arr = new string[] { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };
            Console.WriteLine("Исходный массив:");
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементво длина которых меньше 7:");
            DataService ds = new DataService();
            Console.WriteLine(ds.Calculate(arr));
            Console.ReadKey();
        }
    }
}
