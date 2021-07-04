using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class Task3
    {
        public void MainMethodTask3()
        {
            Console.WriteLine("До какого числа считать ряд Фибоначчи?");
            string value = Console.ReadLine();
            bool Checkvalue = int.TryParse(value, out int _value);

            int first = 1;
            Console.Write($"{first}  ");
            int Second = 1;
            Console.Write($"{Second}  ");
            int sum = 0;
            while (_value >= sum)
            {
                sum = first + Second;

                Console.Write($"{sum}  ");

                first = Second;
                Second = sum;
            }
        }
    }
}
