using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    public class Task_2
    {
        public void MainMethodTask2()
        {            
            Console.WriteLine("Введите размер массива");
            string SizeArray = Console.ReadLine();
            bool CheckSizeArray = int.TryParse(SizeArray, out int _sizeArray);
            if(CheckSizeArray)
            {
                int[] _array = new int[_sizeArray];
                int i = 0;
                Console.WriteLine("Введите числа:");
                while(i < _sizeArray)
                {
                    string value = Console.ReadLine();
                    bool Checkvalue = int.TryParse(SizeArray, out int _value);
                    if (CheckSizeArray)
                    {
                        _array[i] = _value;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Не вверное число, попробуйте снова");
                    }
                }
                int sum = StrangeSum(_array);
                Console.WriteLine(sum);
            }
        }
        public int StrangeSum(int[] inputArray)
        {
            int sum = 0;    //O(1)
            for (int i = 0; i < inputArray.Length; i++) // O(N)
            {
                for (int j = 0; j < inputArray.Length; j++) // O(N * N)
                {
                    for (int k = 0; k < inputArray.Length; k++) //O ( N * N * N)
                    {
                        int y = 0; //f

                        if (j != 0) // g
                        {
                            y = k / j; // h
                        }

                        sum += inputArray[i] + i + k + j + y; // s
                    }
                }
            } // (O (f (N3) + g(N3) + h (N3)))

            return sum; //(O(1))
        }// O(2 + ((f (N3) + g(N3) + h (N3))))
    }
}
