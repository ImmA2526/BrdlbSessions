using System;
using System.Collections.Generic;
using System.Text;

namespace Basic__AllSession
{
    class S2__VaribaleAndDatatypes
    {
        enum Months
        { Jan, Feb, March, April, May, June, July, August, Sepetember,Octobor, November, December};

        // Instance variabel or Non static variabel
        int[] numbers = { 1, 2, 3, 4, 5 };

        //Static Variable
        static string[] studentName = { "Abhilasha", "Amit", "Eqbal", "Faheem", "Prakash", "Akhil", "Ganesh", "Faisal", "Asad", "Sonu" };

        public void VariablesAndUses()
        {
            //Local Variable...
            int digit = 10;
            Console.WriteLine("Integer Digit " + digit);

            string helloMsg = "Hello Team";
            Console.WriteLine("Message:--  " + helloMsg);

            //Constant varibale
            const string game = "Holyball";
            //game = "Cricket";
            Console.WriteLine("Event :-- " + game);

            for (var i = 0; i < studentName.Length; i++)
            {
                Console.Write(studentName[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            //Console.WriteLine("\nNumbers Array " +numbers);
            Console.WriteLine();

            foreach (int month in  Enum.GetValues(typeof(Months)))
            {
                Console.Write($"{Enum.GetName(typeof(Months), month)}");
                Console.WriteLine($" {month}");
            }
            //ESCAPE SEQUNCE AND VERBATRIM
            string path = " "; //Escape Sequence \t \b \n \' \"" \?
            path = @"D:\Resume\ImranResume"; // Verbatim
            Console.WriteLine(path);

            Console.ReadLine();
        }
       
    }
}
