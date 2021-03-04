using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    class Linear
    {
        public static void Do()
        {
            int[] elements = new int[10] { 10, 11, 21, 34, 27, 56, 43, 77, 88, 91 };
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine("Enter search number");
            string searchele = Console.ReadLine();
            int ele = Convert.ToInt32(searchele);
            bool flag = false;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == ele)
                {
                    flag = true;
                    Console.WriteLine(ele + " found at position at " + i);
                }
            }
            if (!flag)
            {
                Console.WriteLine("element not found");
            }
        }
    }
}
