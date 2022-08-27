using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;   //checking execution time

namespace OOPS__AllSession
{
    class S18__StringAndStrinBuilder
    {
        public void StringManupulation()
        {
            string names = "Abhilasha";
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
                names = names + names;
                Console.WriteLine("Names Are: " + names);
            }

            timer.Stop();
            Console.Write("\nTime For String is : " + 
                timer.ElapsedMilliseconds+ "\n\n");
        }

        public void StringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder("Amit Kumar");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.Append("Deshmukh");
                Console.WriteLine("\tNames Are: " + stringBuilder);
            }
            timer.Stop();
            Console.Write("\nTime For StringBuilder is : " + timer.ElapsedMilliseconds);
        }

        public void StringBuilder_Methods()
        {
            StringBuilder stringBuilder = new StringBuilder("Amit Kumar Deshmukh");

            stringBuilder.Insert(4, "ee");
            Console.WriteLine("After Insertion: "+stringBuilder);
            stringBuilder.AppendLine("Patil");
            Console.WriteLine("After Append Line: " + stringBuilder);
            stringBuilder.Remove(6, 3);
            Console.WriteLine("After Remove: " + stringBuilder);
            stringBuilder.AppendFormat("{0:X}", 25);

            Console.WriteLine("Names Are: " + stringBuilder);
        }
    }
}
