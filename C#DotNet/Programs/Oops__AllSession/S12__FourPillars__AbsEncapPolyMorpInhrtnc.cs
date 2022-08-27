using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS__AllSession
{
    class S12__FourPillars__AbsEncapPolyMorpInhrtnc
    {
        int age;
        private string employeeName;
        public string address;

        //************* Abstraction ***********
        void Abstraction_Method()
        {
            double salary;
            const double tax = 0.1;
            double netSalary;

            Console.Write("\nEnter Employee Name: ");
            employeeName = Console.ReadLine();

            Console.Write("Enter Employee Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter Net Pay: ");
            netSalary = double.Parse(Console.ReadLine());

            //Calling Encapsulation Method//
            Encapsulation encap = new Encapsulation();
            encap.AccessingEncapsulatedData();

            if (netSalary >= 30000)
            {
                salary = netSalary - (tax * netSalary);
                Console.Write($"*********Employee Detail is ********\nEmployee Name: {employeeName}\nEmployee Age: {age}\nEmployee Address: {address}\nSalary: {salary} \n");
            }
            else
                Console.Write($"*********Employee Detail is ********\nEmployee Name: {employeeName}\nEmployee Age: {age}\nEmployee Address: {address}\nSalary: {netSalary} \n");
        }
        public void NonAbstraction_Method()
        {
            //    this.Abstraction_Method();
            }
        }

    //************* Encapsulation ***********
    class Encapsulation
    {
        public void AccessingEncapsulatedData()
        {
            S12__FourPillars__AbsEncapPolyMorpInhrtnc accessEncapData = new S12__FourPillars__AbsEncapPolyMorpInhrtnc();

            Console.Write("Enter Employee Address: ");
            accessEncapData.address = Console.ReadLine();

            //Console.Write("\nEnter Employee Age: "); //Error
            //accessEncapData.age = int.Parse(Console.ReadLine());
        }

        //******************** Polymorphism ***************
        public void PolyMorphism()
        {
            Encapsulation polymorPhism = new Encapsulation();
            polymorPhism.Addition();
            polymorPhism.Addition(30, 30);
            //polymorPhism.Addition();
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
        //public int Addition(int num1,int num2)   Error 
        //{
        //    int sum = num1 + num2;
        //    return sum;
        //}
    }

    //*************** Inheritance **************
    class Parent_Inheritance
    {
        public string name = "Imran";
        public int age = 88;
        public int workingHours = 12;
        int salary = 450000;

        public void Parent_InheritanceMethod()
        {
            Console.WriteLine($"The Person Detail is:**********\nName: {name}\nAge: {age}\nSalary: {salary}\nWork Hour: {workingHours}");
        }
    }

    class Single_Inheritance : Parent_Inheritance   // Single
    {
        long contactNo = 9988776655;
        string address = "Mumbai Pune Highway...";

        public void Single_InheritanceMethod()
        {
            Single_Inheritance baseInherit = new Single_Inheritance();
            baseInherit.Parent_InheritanceMethod();
            Console.Write($"Contat Number: {contactNo}\nAddress: {address}\n");
        }
    }

    class Hirarchical_Inheritance : Parent_Inheritance  // Hirarchical Inheritance
    {
        string[] city = { "Pune", "Latur", "Mumbai", "Dubai", "Jermany", "America", "Nashik", "Amrawati", "London", "UK", "US", "Japan", };
        public void Hirarchical_InheritanceMethod()
        {
            Console.Write("\nCities Are: ");
            foreach(string cities in city)
                Console.Write(cities);
        }
    }

    class Multilevel_Inheritance : Hirarchical_Inheritance  // Multilevel
    {
        int[] number = { 0, 11, 110, 1100, 11000, 1100000 };
        public void Multilevel_InheritanceMethod()
        {
            Console.Write("\nNumbers Are: ");
            for(int i=0;i<number.Length;i++)
                Console.Write(number[i]+"   ");
        }
    }

    //************Multiple Inheritance *****************
    interface MultipleInheritance
    {
         void Multiple_InheritanceAccess();
    }
    class Multiple_Inheritance : Multilevel_Inheritance, MultipleInheritance
    {
        public void Multiple_InheritanceAccess()
        {
            int no1 = 20, no2 = 40;
            Console.WriteLine($"Addition is :{no1+no2}\nSubstraction is: {no2-no1}");
        }

    }

}
