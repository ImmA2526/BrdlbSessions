using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS__AllSession
{
    class S13__MethodsAndTypes_MthdOverlod_Override
    {
        //Private Method************
        void Addition()
        {
            int num1, num2;
            Console.Write("Enter Number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write($"Addition is: {num1 + num2}");
        }

        //Return Type Int With PArameterise --------------
        public int Substraction(int num1, int num2)
        {
            int sub = num1 - num2;
            Console.WriteLine("\n\nAddition Method Called************");
            this.Addition();
            Console.WriteLine("\nReturn Value  " + sub);
            return sub;
        }

        //Non Static With PArameterised------------
        public void StringManupulation(string name = "Imran")
        {
            Console.Write("\nName is: " + name);
            S13__MethodsAndTypes_MthdOverlod_Override.PrinitingName("Pune", 23);
            S13__MethodsAndTypes_MthdOverlod_Override.PrinitingName(age: 28, address: "Address"); //Named Argument
            // S13__MethodsAndTypes_MthdOverlod_Override.PrinitingName(23,"Address");  Error
        }

        //Static Method------------
        public static void PrinitingName(string address, int age)
        {
            Console.Write("\n\nAddress Is: " + address + "\nAge is: " + age);
        }
    }

    //Abstract Method

    //public class BasicDetails   // Base Class
    //{
    //    public string firstName;
    //    public int age { get; set; }
    //    public char gender;
    //    public long phoneNumber;
    //    public abstract void AbstractClassAndDisplayDetail() 
    //    {

    //    }
    //    // Abstract Method
    //}

    //Method Overloading And Overriding
    class MethodOverLoading
    {
        public void MethodOverloading()
        {
            MethodOverLoading methodOverloading = new MethodOverLoading();
            methodOverloading.Addition();
            methodOverloading.Addition(30, 30);
        }

        public void Addition()
        {
            int num1 = 40, num2 = 40;
            Console.WriteLine($"Addition is For Non Parameter Method: {num1 + num2}");
        }
        public void Addition(int num1, int num2)
        {
            Console.WriteLine($"Addition is For Parameter Int Method: {num1 + num2}");
        }

        public virtual void Addition_MethodOverride() /// Method Overriding 
        {
            Console.Write("Enter 1st No: ");
            int no1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd No: ");
            int no2 = int.Parse(Console.ReadLine());

            Console.Write($"Addition is : {no1 + no2} \n\n");
        }
    }

    class MethodOverRiding : MethodOverLoading
    {
        public override void Addition_MethodOverride() /// Method Overriding 
        {
            Console.Write("Enter 1st No: ");
            int no3 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd No: ");
            int no4 = int.Parse(Console.ReadLine());

            Console.Write($"Multiplication is : {no3 * no4}\n\n");

            Console.WriteLine("Calling Parent Method");
            base.Addition_MethodOverride(); 
                
        }
    }

}
