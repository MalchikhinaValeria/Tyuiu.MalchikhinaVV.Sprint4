using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalchikhinaVV.Sprint4.Task3.V11.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint4.Task3.V11
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                              *");
            Console.WriteLine("* Выполнил: Мальчихина Валерия Викторовна | ИИПб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 4 до 9.              *");
            Console.WriteLine("* Подсчитайте количество нечетных элементов во всем массиве.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = {
            { 8, 6, 9, 4, 5 },
            { 9, 4, 8, 5, 6 },
            { 9, 7, 9, 8, 4 },
            { 4, 6, 5, 7, 8 },
            { 6, 6, 7, 6, 4 }
            };
            Console.WriteLine("8 6 9 4 5");
            Console.WriteLine("9 4 8 5 6");
            Console.WriteLine("9 7 9 8 4");
            Console.WriteLine("4 6 5 7 8");
            Console.WriteLine("6 6 7 6 4");
            int count = ds.Calculate(matrix);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Всего {count} нечетных элементов.");


            Console.ReadKey();

        }
    }
}

