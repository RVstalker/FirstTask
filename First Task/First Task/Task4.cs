﻿using System;

namespace First_Task
{
    public class Task4
    {
        // Получить сумму первых N чисел с шагом M от числа X 
        // (X=10 N=5 M=2 → 10+12+14+16+18=70).

        public  Task4()
        {
            double n = 5.0;
            double m = 2.0;
            double x = 10.0;            
            Console.Write($"X={x} N={n} M={m} -> ");
            double sum = (2 * x + m * (n - 1)) / 2 * n;
            Console.WriteLine($"{sum}");
            Console.ReadLine();
        }
    }
}
