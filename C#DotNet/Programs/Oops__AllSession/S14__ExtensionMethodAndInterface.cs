using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS__AllSession
{
    class S14__ExtensionMethodAndInterface
    {
        public void DisplayCity() //S7 Single Array
        {
            string[] city = { "Pune", "AbuDabi", "Mumbai", "Dubai", "Jermany", "America", "Nashik", "Amrawati", "London", "UK", "US", "Japan", };
            Console.Write("\nCities Are: ");
            foreach (string cities in city)
                Console.Write(cities);
        }

        public void MultiDimensionalArray() //S7
        {
            int[][] numericalValues = new int[3][];
            numericalValues[0] = new[] { 12, 24, 36, 48, 99, 88, 77 };
            numericalValues[1] = new[] { 60, 72, 84, 96, 00 };
            numericalValues[2] = new[] { 10, 20, 30, 44 };

            Console.WriteLine("\n******** ForeachLoop **********");
            foreach (int[] number in numericalValues)
            {
                foreach (int i in number)
                {
                    Console.Write(i + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nValue of JaggedArray is: {numericalValues[1][2]}");
        }

        public void PrintMonths()
        {
            string[] month = { "Jan", "Feb", "March", "April", "May", "June", "July", "August", "Sepetember", "Octobor", "November", "December" };
            Console.Write("\nMonths Are: \n");
            foreach (string months in month)
                Console.Write($"{months}"+"  " + "\n");
        }
    }

    static class Extension_Methods
    {
        static string firstName { get; set; } //S11Partial Class
        static int age { get; set; }
        static char gender { get; set; }
        static long phoneNumber { get; set; }

        enum Months { Jan, Feb, March, April, May, June, July, August, Sepetember, Octobor, November, December };

        public static void StudentDetails(this S14__ExtensionMethodAndInterface extensionMethod)
        {
            Console.Write("Enter Student Name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Gender: ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Student PhoneNumber: ");
            phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($"\n********Student Detail Are:**********\n Student Name : {firstName}\n Student Age: {age}\n Student Gender: {gender}\n Student Phone: {phoneNumber}");
        }

        public static void PrintMonth(this S14__ExtensionMethodAndInterface extensionMethods) //S2
        {
            foreach (int month in Enum.GetValues(typeof(Months)))
            {
                Console.Write($"{Enum.GetName(typeof(Months), month)}");
                Console.WriteLine($" {month}");
            }
        }

        //Binding With Struct 
        public static int[] PrintArrayNumber(this int[] num)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("\nNumbers Are: " + "\n");
            foreach (int number in numbers)
                Console.Write($" {number}" + "  ");

            return numbers;
        }
    }

    //Interface
    interface ISampleData
    {
        void MarkChecker();
    }
    class SampleData_Interface
    {
        public void MarkChecker() //S5
        {
            //IF...IF Then IF...else if
            Console.Write("Enter Percentage value \t");
            int percentage = int.Parse(Console.ReadLine());
            if (percentage >= 80)
                Console.WriteLine("Congrats!  You Pass the Exam");
            // Console.WriteLine("Wish You best Luck");        // Error 
            else if (percentage >= 60)
                Console.WriteLine("Good! You Are Eligible For Commerce");
            else if (percentage >= 50)
                Console.WriteLine("All The Best");
            else if (percentage < 35)
                Console.WriteLine("Failed");
            else
                Console.WriteLine("Sorry! \tTry Next Time");
        }
    }

}
