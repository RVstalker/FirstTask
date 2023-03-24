using System;

namespace First_Task
{
    public class Task18
    {
        // Дана строка, посчитать количество слов, которые начинаются на букву "K".

        public Task18(string str)
        {
            var counter = 0;
            Console.WriteLine($"Your string is: {str}");

            if (str[0] == 'K')
                counter += 1;

            var str1 = str.Replace(" K", "");
            counter += (str.Length - str1.Length) / 2;
            Console.WriteLine($"Result is: {counter}");
            Console.ReadLine();
        }
    }
}
