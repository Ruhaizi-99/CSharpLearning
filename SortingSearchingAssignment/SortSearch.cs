using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SortingSearchingAssignment
{
    class SortSearch
    {
        public static void Do()
        {
            WriteLine();
            ReadLine();
            //LinearSearch(names);

        }
        private static void WriteLine()
        {
            //Console.WriteLine("student details entered into the file");
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            StreamWriter wrt = File.CreateText(filename);
            wrt.WriteLine("Shinee, 21, ECE");
            wrt.WriteLine("Minho, 20, IT");
            wrt.WriteLine("Jjong, 20, CSE");
            wrt.WriteLine("Key, 19, IT");
            wrt.WriteLine("Onew, 21, IT");
            wrt.WriteLine("Taemin, 19, CSE");
            wrt.Close();
            Console.WriteLine("student data entered into the file");
        }
        private static void ReadLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            //lets declare array for names here
            string[] names = new string[6];
            if (File.Exists(filename))
            {
                int j = 0;
                Console.WriteLine("File exists");
                string[] contents = File.ReadAllLines(filename);
                foreach (var content in contents)
                {
                    string[] parts = content.Split(", ");
                    names[j] = parts[0];
                    j++;
                }
                BubbleSort(names);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
            public static void BubbleSort(string[] names)
            {
                string temp;
            Console.WriteLine("Before sorting names: ");
                Print(names);
                for (int i = 0; i < names.Length ; i++)
                {
                    //Console.WriteLine("\n\nStarting Pass " + i.ToString());
                    //Print(names);
                    for (int j = 0; j < names.Length-i-1  ; j++)
                    {
                        if (names[j + 1].CompareTo(names[j]) < 0)
                        {
                            temp = names[j];
                            names[j] = names[j + 1];
                            names[j + 1] = temp;
                            //Console.WriteLine("\nSwapped");
                            //Print(names);
                        }
                    }
                }
            Console.WriteLine("After sorting names : ");
                Print(names);
            LinearSearch(names);
        }

            private static void Print(string[] names)
            {
               // Console.WriteLine("");
                foreach (string name in names)
                {
                    Console.Write(name + " ");
                }
            Console.WriteLine("");
           
            }
        private static void LinearSearch(string[] names)
        {
            Console.WriteLine("\n\nEnter name to search");
            string input = Console.ReadLine();
            bool fg = false;
            for(int i=0; i< names.Length; i++)
            {
                if (input == names[i])
                {
                    fg = true;
                    Console.WriteLine("search name is found at " + i);

                }
            }
            if (!fg)
            {
                Console.WriteLine("Does not exist");
            }
        }

    }
}
