using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS__AllSession
{
    public delegate int CubeNumbers(int numbers);

    public delegate void PrintPositiveNumbers();
    public delegate void PrintPersonNames();

    public delegate void PrintCityNames(string[] cities);

    class S17__AnonymousMethodAndLambdaExpression
    {
        public static void AnonymousMethod()
        {
            PrintPositiveNumbers anonymousMethod = delegate ()
            {
                Console.Write("\n\nHow Many Numbers you want: ");
                int userArray = Convert.ToInt32(Console.ReadLine());

                int[] arrays = new int[userArray];
                for (int i = 0; i < userArray; i++)
                {
                    Console.Write("Enter Data Value:  ");
                    int finalyArray = Convert.ToInt32(Console.ReadLine());
                    arrays[i] = finalyArray;
                }
                Console.WriteLine("\n****** Your Final Array is: ************");
                Console.Write("Final Array is: ");
                foreach (int data in arrays)
                    Console.Write(data + "  ");
            };
            anonymousMethod.Invoke();

            //Lambda Expression 1. Expression Lambda 
            Console.WriteLine("\n\n************ Under the Expression Lambda Expression");

            CubeNumbers expressionLambda = (numbers) => numbers * numbers * numbers;
            Console.Write("Cube of Numbers: \t");
            Console.Write(expressionLambda.Invoke(2));

            //2. Statment Lambda 
            Console.WriteLine("\n\n************ Under the Lambda Expression");

            PrintPersonNames lambdaExpression = () =>
            {
                string[] names = { "Sahiba", "Abhilasha", "Amit", "Amir", "Kanak", "Prakash", "Sayali", "Akhil", "Shubham", "Ameeja", "Amit", "Ekbal", "Prakash", "Imran" };
                Console.Write($"Length of Array is : {names.Length} \n\nNames Are:  ");
                foreach (string name in names)
                    Console.Write(name + ", ");
                Console.WriteLine();
            };
            lambdaExpression.Invoke();

            Console.WriteLine("\n\n************ Under the PArameterised Lambda Expression");
            PrintCityNames parameters_LambdaExpression = (cities) =>
            {
                Console.Write($"Length of Array is : {cities.Length} \n\nCities Are: \t");
                foreach (string city in cities)
                    Console.Write(city + ", ");
                Console.WriteLine();
            };
            string[] city = { "Panvel", "Pune", "Nanded", "Latur", "Beed", "Mumbai", "Dubai", "Goa", "Africa", "America" };
            parameters_LambdaExpression.Invoke(city);
        }

    }
}