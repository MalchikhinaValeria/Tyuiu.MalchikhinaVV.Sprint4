using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalchikhinaVV.Sprint4.Task2.V4.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint4.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Мальчихина В. В. | ИИПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Мальчихина Валерия Викторовна | ИИПб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов,                    *");
            Console.WriteLine("* заполненный случайными числами в диапазоне от 2 до 9,                   *");
            Console.WriteLine("* подсчитать сумму нечетных элементов массива.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите количество элементов массива: ");

            Random rnd = new Random();
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];

            for (int i = 0; i < len; i++) array[i] = rnd.Next(2, 9);

            Console.WriteLine("Mассив: ");

            for (int i = 0; i < array.Length; i++) Console.Write(array[i] + "\t");


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма нечётных элементов массива: {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}

