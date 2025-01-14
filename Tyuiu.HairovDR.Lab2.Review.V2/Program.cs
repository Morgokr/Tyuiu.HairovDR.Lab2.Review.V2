using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.HairovDR.Lab2.Review.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Хаиров Д. Р. | МКМб-22-1";
            Console.WriteLine("*********************************************************");
            Console.WriteLine("УСЛОВИЕ ЗАДАЧИ: написать программу, которая выводит \nтаблицу значений функции (произвести табулирование) f(x)\nна заданном диапазоне X1, X2. Произвести проверку деления\nна ноль. Значения должны храниться в массиве.\nОкруглить значения до двух знаков после запятой.");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Введите старт шага:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец шага:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                            *");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("+-------------+-------------+");
            ds.GetMassFunction(x1,x2);
            Console.WriteLine("+-------------+-------------+");
            Console.ReadKey();

        }
    }
}
//Console.WriteLine(DataService.GetMassFunction(1, 2, 3));
