using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace OOPS__AllSession
{
    class S19__GenericAndReflections
    {
        public void CalledGenericMethod()
        {
            S19__GenericAndReflections generic = new S19__GenericAndReflections();

            int[] number = new int[5];
            number[0] = 1;
            number[1] = 11;
            number[2] = 110;
            number[3] = 'C';
            number[4] = 'D';

            string[] city = { "Panvel", "Pune", "Nanded", "Latur", "Beed", "Mumbai", "Dubai" };
            string[] fruits = { "Orange", "Mango", "PineApple", "Apple", "Strawberry", "Muskmelon", "Gauva" };
            string[] names = { "Amit", "Amir", "Sahiba", "Arif", "Kanak", "Prakash","Akhil", "Shubham" };

            generic.GenericMethod(number);
            generic.GenericMethod(city);
            generic.GenericMethod_MultipleParameter(fruits,names);

            GenericClass<int>.PrintData();
            GenericClass<string>.Reflections();
        }
        public void GenericMethod<placeholder>(placeholder[] data)
        {
            for (int i = 0; i < data.Length; i++)
                Console.Write(data[i]+" , ");

            Console.WriteLine();
        }
        public void GenericMethod_MultipleParameter<placeholder>(placeholder[] fruits, placeholder[] names)
        {
            Console.Write($"\nLength of Array is : {fruits.Length}\nFruits Are:-- ");
            for (int i = 0; i < fruits.Length; i++)
                Console.Write(fruits[i]+" , ");
           
            Console.Write($"\n\nLength of Array is : {names.Length} \nNames Are: \t");
            foreach (placeholder name in names)
                Console.Write(name + ", ");

            Console.WriteLine(typeof(placeholder));
        }
    }
    class GenericClass<placeholderData>
    {
         placeholderData no { get; set; }
         placeholderData no1 { get; set; }
        public static void PrintData()
        {
            GenericClass<string> genericClass = new GenericClass<string>();
            genericClass.no = "Imran";
            Console.WriteLine("My Name is : "+genericClass.no);
            //genericClass.no1 = 100;   only define data type support
        }

        //Reflections******************
        public static void Reflections()
        {
            Type typeCheking = typeof(String);   /// Detail of Class String
            Console.WriteLine("Type of : "+typeCheking.Name);

            MethodInfo[] methodsInfo = typeCheking.GetMethods();
            foreach (var methods in methodsInfo) 
            {
                Console.WriteLine("Method Info:- "+methods.Name);
                ParameterInfo[] parameter = methods.GetParameters();
                foreach(var parameters in parameter)
                    Console.WriteLine("Parameter Info:- "+parameters.Name+" : "+parameters.ParameterType);
            }

            Console.WriteLine("\n\nYou Are In The Property Reflections**********");
            PropertyInfo[] propertyInfo = typeCheking.GetProperties();
            foreach(var property in propertyInfo)
                Console.WriteLine("\tProperty Info: "+property);
        }
    }
}
