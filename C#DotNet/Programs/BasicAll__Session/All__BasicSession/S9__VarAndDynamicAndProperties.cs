using System;
using System.Collections.Generic;
using System.Text;

namespace Basic__AllSession
{
    class S9__VarAndDynamicAndProperties
    {
        public void VarAndDynamic()
        {
            Console.WriteLine("*********You are in Var ****** \n");
            var data = "Program One";
            //data = 100;  //Error value cannot change
            foreach (char program in data)
                Console.Write(program);

            Console.WriteLine("\nDatatype of Var is: "+ data.GetType()+"\n");

            Console.WriteLine("*******You Are in Dynamic *********\n");
            dynamic name = "This is The Program of Imran";
            //name = 100;
            Console.Write("Value is : "+name + "\n");

            Console.Write("Message is :");
            foreach(dynamic message in name)
                Console.Write(message);

            Console.WriteLine("\nDatatype of Dynamic is: " + name.GetType() + "\n");
        }

        //Properties 
        public void PropertiesMethod()
        {
            Properties properties = new Properties();

            Console.Write("Enter Student Id: ");
            properties.studentId = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            properties.studentName = Console.ReadLine();

            Console.Write("Enter Student Phone: ");
            properties.studentPhone = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student City: ");
            properties.student_City = Console.ReadLine();

            Console.Write("Enter Student Add: ");
            properties.student_Add = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter StudentMark : "); //Read Only Properties;
            //properties.studentMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Student ID:{properties.studentId} \nStudentAdd: {properties.student_Add} \nStudent Name: {properties.studentName} \nStudent Phone: {properties.studentPhone} \nStudent City: {properties.student_City}");

        }

        //Static Property
        public void StaticProperty()
        {
            Console.Write("Enter School Name : ");
            Properties.school_Name = Console.ReadLine();
            Console.Write("Schol Name is: "+Properties.school_Name);
        }

    }
    class Properties
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public string student_City { get; set; }
        public dynamic studentPhone { get; set; }
        //public var studentGender { get; set; }
        public int studentMarks {get;} // Read Only 

        private int studentAdd;
        public int student_Add
        {
            set 
            {
                if (value <= 0)
                    Console.WriteLine("Not allowed");
                else
                    this.studentAdd = value;
            }
            get { return this.studentAdd; }
        }

        //Static Property
        static string schoolName;
        static string schoolAdd;

        public static string school_Name
        {
            get 
            {return schoolName;}
            set
            {
                if(string.IsNullOrEmpty(value))
                    Console.WriteLine("Empty String Not Allowed");
                else
                    schoolName = value;
            }
        }
        public static string school_Add { get; set; }
    }
}
