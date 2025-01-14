using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.HairovDR.Lab2.Review.V2;

public class DataService
{
        public void GetMassFunction(int startValue, int stopValue)
        {
            Console.WriteLine("| {0,11} | {1,11} |", "X","f(x)");
            Console.WriteLine("+-------------+-------------+");
            if (startValue > stopValue)
            {
                (startValue, stopValue) = (stopValue, startValue);
            }
            for (int x = startValue; x <= stopValue; x++)
                {
                    double Func = Math.Pow(2, -x) + (5 / 3) * (Math.Pow(x,-1)) - Math.Cos(Math.Pow(x, 2)) + Math.Sin(2 * x);
                    if (x == 0)
                    {
                        Console.WriteLine("| {0,11} | {1,11}|", x, "Нет значения");
                    }
                    else
                    {
                        Console.WriteLine("| {0,11} | {1,11} |", x, Math.Round(Func, 2));
                    }

                }
        }
    }

