using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;

namespace OOPS__AllSession
{
    public delegate void PrintNumbers();
    public delegate void PrintNames(string[] names);
    class S16__DelegatesAndEvents
    {
        public static void PrintPositiveNumbers()
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
        }
        public void PrintCityName(string[] city)
        {
            Console.Write($"Length of Array is : {city.Length} \n\nCities Are: \t");
            foreach (string cities in city)
                Console.Write(cities + ", ");
            Console.WriteLine();
        }
        public static void PrintPersonName(string[] name)
        {
            Console.Write($"Length of Array is : {name.Length} \nNames Are: \t");
            foreach (string names in name)
                Console.Write(names + ", ");
            Console.WriteLine();
        }
        public static void PrintName(string[] fullName)
        {
            Console.Write($"Length of Array is : {fullName.Length} \nFull Name is: ");
            foreach (string name in fullName)
                Console.Write(name + ", ");
            Console.WriteLine();
        }
    }

    //Events
    class EventNotifications
    {
        public event PrintNumbers notificationEvent;
        public void NotificationMethod()
        {
            if (notificationEvent != null)
                notificationEvent();
        }
    }

    class User1
    {
        public static void User1_Message()
        {
            Console.WriteLine("Hello This is Sample Message For User 1...");
            //Console.ReadLine();
        }
    }

    class User2
    {
        public static void User2_Message()
        {
            Console.WriteLine("Hello This is Sample Message For User 2...");
        }
    }
}
