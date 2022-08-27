using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS__AllSession
{
    class S15__ConstructorAndTypes //: PrivateConstructor   Error
    {
        int id;
        string name;
        int age;
        string address;

        //Default Constructor
        public S15__ConstructorAndTypes()
        {
            int rollNo = 30;
            string className = "Avengers";
            Console.WriteLine($"Roll No is: {rollNo}\nClassName: {className}");
            //Console.ReadLine();
        }

        //Destructors
        ~S15__ConstructorAndTypes()
        {
            Console.WriteLine("Destructor Calle...");
        }

        //Parameterised Constructor
        public S15__ConstructorAndTypes(int empId, string empName, int empAge, string empAddress)
        {
            this.id = empId;
            this.name = empName;
            this.age = empAge;
            this.address = empAddress;
            this.ParameterizedConstructor();
        }

        //Copy Constructor
        public S15__ConstructorAndTypes(S15__ConstructorAndTypes copyConstructor)
        {
            this.id = copyConstructor.id;
            this.name = copyConstructor.name;
            this.age = copyConstructor.age;
            this.address = copyConstructor.address;
        }
        public void ParameterizedConstructor()
        {
            Console.WriteLine("\n\nYou Are in Construcotr\n  Employee ID: {0}\n  Employee Name :{1}\n  Employee Age: {2}\n  Employee Address: {3}", id, name, age, address);

            Console.WriteLine("Message is: " + PrivateConstructor.msg);

            PrivateConstructor.PrivateConstructors();
        }
    }

    //Private and Static
    class PrivateConstructor
    {
        public static string msg = "Hello Imran...";
        public static string gender;
        public static int age;
        private PrivateConstructor() //Private
        {

        }
        public static void PrivateConstructors()
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine("\n\nYou Are in Private Constructor\n");
            Console.Write("\nFull Date Is : " + DateTime.Now);
        }

        static PrivateConstructor() //Static
        {
            gender = "Male";
            age = 44;
        }
        public static void GetData()
        {
            Console.Write($"Gendr is {gender}\nAge is {age}");
        }

    }
}
