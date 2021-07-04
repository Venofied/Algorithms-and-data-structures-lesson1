using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    public class Task_1
    {
        public void MainMethodTask_1()
        {
            Console.WriteLine("Введите число");
            string StrNumberTask = Console.ReadLine();
            int.TryParse(StrNumberTask, out int Number);
            Search(Number);
        }
        public string Search(int Number)
        {
            int d = 0;
            int i = 2;
            string result = string.Empty;
            if (i < Number)
            {
                if (Number % i == 0) d++;
                else i++;
            }
            if (d == 0)
            {
                Console.WriteLine("Простое");
                result = "Простое";
            }
            else
            {
                Console.WriteLine("Не Простое");
                result = "Не Простое";
            }
            return result;
        }
    }
}
