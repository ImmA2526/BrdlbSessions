using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;

namespace OOPS__AllSession
{
    class S20__MultiThreading
    {
        public void PrintNumberList()
        {
            int i = 1;
            do
            {
                Console.Write(i+", \t");
                i++;
                if (i == 30)
                {
                    Console.WriteLine("\n\t\t----Going in Thread for Some Time----");
                    Thread.Sleep(700);
                }
            } while (i <= 40);
        }
        public void PrintMultiplication()
        {
            int number = 2, i = 1;
            do
            {
                Console.WriteLine($"{number} X {i} = " + number * i);
                i++;
            } while (i <= 10);
        }
        public void PrintNamesArray()
        {
            string[] name = { "Amit", "Navyatha", "Eqbal", "Sayali", "\t\t", "Prakash", "Imran", "Abhilasha", "Aniket", "Arnav", "Ganesh" };
            Console.Write("Names Are:  ");
            for (int i = 0; i < name.Length; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("\n\t\t----Going in Thread for Some Time----");
                    Thread.Sleep(800);
                }
                Console.Write(name[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
