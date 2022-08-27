using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS__AllSession
{
    class S11__ClassAndTypes
    {
        //********** Nested Class ***********
        public abstract class BasicDetail   // Base Class
        {
            public string firstName;
            public int age { get; set; }
            public char gender;
            public long phoneNumber;
            public abstract void AbstractClassAndDisplayDetail();   // Abstract Method
        }
        public class StudentDetail : BasicDetail   //Hirarchical Inheritace. more than one child class.
        {
            public int rollNo;
            public int fess;

            public override void AbstractClassAndDisplayDetail()
            {
                Console.Write("Enter Student Name: ");
                this.firstName = Console.ReadLine();

                Console.Write("Enter Student Age: ");
                this.age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Student Gender: ");
                this.gender = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter Student PhoneNumber: ");
                this.phoneNumber = Convert.ToInt64(Console.ReadLine());

                Console.Write("Enter Student RollNo: ");
                this.rollNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Student Fess: ");
                this.fess = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\n********Student Detail Are:**********\n Student Name : {this.firstName}\n Student Age: {this.age}\n Student Gender: {this.gender}\n Student Phone: {this.phoneNumber}\n Student RollNo: {this.rollNo}\n Student Fees: {this.fess}");
            }
        }

        //************* Partial Class *****************
        public partial class PartialDetail
        {
            public string firstName { get; set; }
            public int age { get; set; }
            public char gender { get; set; }
            public long phoneNumber { get; set; }
        }

        public partial class PartialDetail
        {
            public void PartialClass()
            {
                Console.Write("Enter Student Name: ");
                this.firstName = Console.ReadLine();

                Console.Write("Enter Student Age: ");
                this.age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Student Gender: ");
                this.gender = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter Student PhoneNumber: ");
                this.phoneNumber = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine($"\n********Student Detail Are:**********\n Student Name : {this.firstName}\n Student Age: {this.age}\n Student Gender: {this.gender}\n Student Phone: {this.phoneNumber}");
            }
        }

    }

    //************** Sealed Class *************
    sealed class BaseClass //Parent Class
    {
        static int num1, num2;
        public static void Sealed_Data()
        {
            Console.Write($"Addition Is: {num1 + num2}");
        }
    }
    class DerrivedClass //: BaseClass(Inheritance is not allowed in sealed class)    //Derived ==> Child Class
    {
        public void Sealed_DerrivedData()
        {
            BaseClass.Sealed_Data();
        }
    }

    //******************* Static Class ************************
    static class StaticClass
    {
        //int number = 20;   //Error
        //public int numb = 40; // Error
        //internal int num = 60; //Error
        //static const int nums= 60; //Error
        static int numbers = 30;

        //public void Instance__NonStatic_Method()
        //{
        //    this.number = 40;
        //}

        public static void Static_Method()
        {
            int numss = StaticClass.numbers;
            Console.WriteLine("Value is :" + numss);
        }
    }
}
