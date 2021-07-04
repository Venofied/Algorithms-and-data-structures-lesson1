using System;

namespace Lesson1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания");
            string StrNumberTask = Console.ReadLine();
            bool CheckNumberTask = int.TryParse(StrNumberTask, out int NumberTask);
            if (CheckNumberTask)
            {
                switch (NumberTask)
                {
                    case 1:
                        Task_1 task_1 = new Task_1();
                        task_1.MainMethodTask_1();
                        break;
                    case 2:
                        Task_2 task_2 = new Task_2();
                        task_2.MainMethodTask2();
                        break;
                    case 3:
                        Task3 task3 = new Task3();
                        task3.MainMethodTask3();
                        break;
                    default:
                        Console.WriteLine("Не вверно введен номер задания");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
