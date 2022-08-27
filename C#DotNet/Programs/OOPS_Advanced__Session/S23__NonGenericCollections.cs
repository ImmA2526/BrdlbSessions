using System;
using System.Collections;

namespace AdvancedTopic__Session
{
    class S23__NonGenericCollections
    {
        void ArrayData()
        {
            string[] city = { "Panvel", "Pune", "Nanded", "Latur", "Beed", "Mumbai", "Dubai", 122.ToString(), 2.89.ToString() };
            Console.Write($"Length of Array is : {city.Length} \n\nCities Are: \t");
            foreach (string cities in city)
                Console.Write(cities + " , ");
        }
        public static void PrintArrayList()
        {
            S23__NonGenericCollections array = new S23__NonGenericCollections();
            ArrayList arrayList = new ArrayList()
            {102,"Imran","Shaikh",9000998877,8.33};
            Console.WriteLine(arrayList.Capacity);
            arrayList.Insert(2, "Pune");
            arrayList.Add("Maharashtra");

            Console.WriteLine("Array List are: --");
            foreach (var arrayData in arrayList)
                Console.Write(arrayData + "   ");

            array.PrintArrayLists();
            array.ArrayData();
        }
        void PrintArrayLists()
        {
            ArrayList privateArray = new ArrayList()
            { 1, "Sahiba", "9899889900", 80.90, 400,2,"Abhilasha","9899889988", 89.90, 40000,3,"Amit","989985988", 89.99, 4000 };
            Console.WriteLine("\n\nArray Data Is:- ");
            foreach (object privateData in privateArray)
                Console.Write(privateData + "   ");
        }

        public void PrintSortedList()
        {
            SortedList sortedList = new SortedList()
            {
                {0, "Sahiba" } ,{ 1, "Rohan"},{ 2, "Keshav"},{3, "Santoshi" },{4, "Venkata" },{5, "Akhil" }
            };
            sortedList.Add(6, "");
            sortedList.Add(7, 333);
            sortedList.Add(8, "Imran");
            //sortedList.Add("ee", "Abhilasha"); Error
            //Accessing Specific Value

            var value = sortedList[5];
            Console.WriteLine("\nValue is : " + value);

            Console.WriteLine("\n------Sorted List-----");
            for (int i = 0; i < sortedList.Count; i++)
                Console.WriteLine($"Key: {sortedList.GetKey(i)}, Value:- {sortedList.GetByIndex(i)}");

            foreach (DictionaryEntry data in sortedList)
                Console.WriteLine($"Key: {data.Key}, Value:- {data.Value}");
        }
        public void HashTable()
        {
            Hashtable hashTable = new Hashtable()
            {
                { "Id", 1123}, { "Name", "Imran" },{"Roll Number", 100 } , { "Address", "Pune"},{ "City", "Pune"},
            };

            hashTable.Add(102, 1123);
            hashTable.Add(100.3, 1123.99);

            if (hashTable.ContainsValue("Imran"))
                Console.WriteLine("This Student is Alredy Exist");
            else
                Console.WriteLine("Not Present Please Add");

            //Accessing Particular Value
            var value = hashTable[102];
            Console.WriteLine("\nValue is : " + value);

            Console.WriteLine("------ Hashtable Data:- ");
            foreach (object key in hashTable.Keys)
            {
                Console.WriteLine(key + ": " + hashTable[key]);
                Console.WriteLine("HashCode is: " + key.GetHashCode());
            }
        }

        public void Stack_Queue_Program()
        {
            Stack stack = new Stack();
            stack.Push("Imran");
            stack.Push("Amit");
            stack.Push("Akansha");
            stack.Push("Anirudh");
            stack.Push("Shubham");
            stack.Push("Imran");
            stack.Push(112);
            stack.Push(33.55);
            stack.Push(true);

            Console.WriteLine("Top Stack Element is:--" + stack.Peek() + "\n");

            if (stack.Contains("Simran"))
                Console.WriteLine("Present");
            else
                Console.WriteLine("Not Present");

            Console.WriteLine("Stack Values Are:********");
            foreach (var stackData in stack)
                Console.WriteLine(stackData);

            Console.WriteLine("\nQue Data is :----");
            Queue queue = new Queue();
            queue.Enqueue("Anikesh");
            queue.Enqueue("Pune");
            queue.Enqueue(55);
            queue.Enqueue(false);
            queue.Enqueue(null);
            queue.Enqueue("Anikesh");
            queue.Enqueue(45.55);
            
            foreach (object queData in queue)
                Console.WriteLine(queData);

            Console.WriteLine("\nDeQue Data:---");
            Console.WriteLine(queue.Dequeue());

             foreach (object queData in queue)
                Console.WriteLine(queData);
        }
    }
}
