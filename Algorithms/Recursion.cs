using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Recursion
    {
        public static void Do()
        {
            int[] numbers = new int[20] { 21, 32, 43, 24, 35, 67, 87, 99, 56, 63, 21, 11, 55, 88, 91, 39, 7, 9, 45, 32 };
            Print(numbers, 0);
        }
        private static void Print(int[] numbers, int currentElementIndex)
        {
            Console.WriteLine(numbers[currentElementIndex]);
            if (currentElementIndex < numbers.Length - 1)
            {
                Print(numbers, currentElementIndex+1);
            }
        }
    }
}
