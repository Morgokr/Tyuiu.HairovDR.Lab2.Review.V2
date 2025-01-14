// See https://aka.ms/new-console-template for more information
using System;



namespace Hairov_Lab
{
    internal class Program
    {
        static void Main(string[], args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Хаиров Д. Р. | МКМб-22-1";
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.Calculate(x));
        }
    }
}
//Console.WriteLine(DataService.GetMassFunction(1, 2, 3));
