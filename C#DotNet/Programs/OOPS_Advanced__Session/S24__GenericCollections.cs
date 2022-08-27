using OOPS_Advanced__Session;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedTopic__Session
{
    class S24__GenericCollections<int_Data, string_Data>
    {
        List<int_Data> integerData;
        List<string_Data> stringData;
        public S24__GenericCollections()
        {
            integerData = new List<int_Data>();
            stringData = new List<string_Data>();
        }

        public void AllMethods()
        {
            S24__GenericCollections<int, string> string_Integer = new S24__GenericCollections<int, string>();

            string_Integer.AddToList(1, "Imran");
            string_Integer.AddToList(2, "Amit");
            string_Integer.AddToList(3, "Nijam");
            string_Integer.DisplayList();
            Console.WriteLine("\nAftr Removing ");
            string_Integer.RemoveFromList(1, "Imran");
            //stringdata.Remove("Shaikh");
            string_Integer.DisplayList();
            Console.WriteLine("\n Inside Person Contact Method*************");
            PersonContactManagement.CallingMethod();

            Console.WriteLine("********** Inside the Que and Stack Problem ***********");
            Dictionary__StackQue dictionary__StackQue = new Dictionary__StackQue();
            dictionary__StackQue.Push(56);
            dictionary__StackQue.Push(30);
            dictionary__StackQue.Push(70);
            //dictionary__StackQue.Push("Imran");
            Console.WriteLine("Inserted Elements Are ");
            dictionary__StackQue.DisplayElements();

            dictionary__StackQue.Pop();
            Console.WriteLine("After Pop.. ");

            dictionary__StackQue.DisplayElements();
            dictionary__StackQue.Peek();
            Console.WriteLine();

            Console.WriteLine("******* Executing Que *******\n");
            dictionary__StackQue.EndedQueue(56);
            dictionary__StackQue.EndedQueue(30);
            dictionary__StackQue.EndedQueue(70);

            Console.WriteLine();
            Console.WriteLine("Ended Que Elements Are: ");
            dictionary__StackQue.DisplayElements();
            dictionary__StackQue.DoubleQue();

            Console.WriteLine();
            Console.WriteLine("Doubled Que Elements Are:");
            dictionary__StackQue.DisplayElements();

        }

        void AddToList(int_Data int_Data, string_Data string__Data)
        {
            integerData.Add(int_Data);
            stringData.Add(string__Data);
        }

        void RemoveFromList(int_Data int_Data, string_Data string__Data)
        {
            integerData.Remove(int_Data);
            stringData.Remove(string__Data);
        }
        void DisplayList()
        {
            Console.WriteLine("\nInteger List Element:- ");
            foreach (var element in this.integerData)
                Console.WriteLine("\t{0}", element);

            Console.WriteLine("\nString List Element:- ");
            foreach (var element in this.stringData)
                Console.WriteLine("\t{0}", element);
        }
    }

    //object base list 
    class PersonContactManagement
    {
        public static void CallingMethod()
        {
            List<PersonContactClass> listPersonCity = new List<PersonContactClass>();
            AddRecord(listPersonCity);
            RetriveRecord(listPersonCity);
            CheckTeenage(listPersonCity);
        }
        private static void AddRecord(List<PersonContactClass> listPersonCity)
        {
            listPersonCity.Add(new PersonContactClass("22223", "Amar", "Adarsh Nagar Pune", 8));
            listPersonCity.Add(new PersonContactClass("44453", "Aniket", "Manipura Colony Mumbai", 8));
            listPersonCity.Add(new PersonContactClass("45553", "Arti", "Kondhwa Khurd Latur", 44));
            listPersonCity.Add(new PersonContactClass("88987", "Pratibha", "Pratibha Villa Mumbai", 18));
            listPersonCity.Add(new PersonContactClass("22223", "Soham", "12 main strt Pune", 10));
            listPersonCity.Add(new PersonContactClass("44453", "Vidyadhar", "120 main strt Beed", 19));
            listPersonCity.Add(new PersonContactClass("45553", "Rehan", "Warali Mumbai", 22));
            listPersonCity.Add(new PersonContactClass("88987", "Sumit", "112 main street Latur", 18));
            Console.WriteLine();
        }
        public static void RetriveRecord(List<PersonContactClass> listPersonCity)
        {
            foreach (PersonContactClass Person in listPersonCity.FindAll(e => (e.Age < 10)).Take(2).ToList())
                Console.WriteLine("Name:" + Person.Name + "\tAge:" + Person.Age);
        }
        public static void CheckTeenage(List<PersonContactClass> listPersonCity)
        {
            if (listPersonCity.Any(e => (e.Age >= 13 && e.Age <= 19)))
                Console.WriteLine("Yes, We Have Some Tenneger ");
        }
    }

    class Dictionary__StackQue
    {
        public void Dictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Number One", "This is Number 1");
            dictionary.Add("Number Two", "This is Number 2");
            dictionary.Add("Number Three", "This is Number 3");
            dictionary.Add("Number Four", "This is Number 4");
            dictionary.Add("Number Five", "This is Number 5");
            //dictionary.Add(1, "This is Number 1");
            //dictionary.Add(1,11); 
            //dictionary.Add("1",4); 

            //Accessing Particular Value
            Console.WriteLine("Value of :-- " + dictionary["Number One"]);
            //Console.WriteLine("Value of :-- " + dictionary[1]);

            foreach (KeyValuePair<string, string> items in dictionary)
                Console.WriteLine("Keys are: " + items.Key + "\tValues Are: " + items.Value);

            if (dictionary.ContainsKey("Number One"))
                Console.WriteLine("****** You Win ****** ");
            else
                Console.WriteLine("******* You Loose *****");

            //TryGetValue
            string outValue;
            dictionary.TryGetValue("Number Two", out outValue);
            Console.WriteLine("Out Value is :" + outValue);
        }

        //QUE STACK

        internal Node head;
        internal void EndedQueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;

                temp.next = node;
                Console.WriteLine("\n{0} Inserted in Q", node.data);
            }
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\n Que is Empty");
                return;
            }
            Console.WriteLine("Data is : ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
        //Creating DeQ
        internal void DoubleQue()
        {
            if (head == null)
                Console.WriteLine("Que Empty");
            else
                Console.WriteLine("{0} Deque ", head.data);
            head = head.next;
        }

        //STACK

        private Node top;
        public Dictionary__StackQue()
        {
            this.top = null;
        }
        //Creating Stack
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;

            this.top = node;
            Console.WriteLine("{0} push to stack", value);
        }

        internal void DisplayElements()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        //Pop And Peek
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("{0} is top of stack", this.top.data);
        }

        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("value Pop {0}", this.top.data);
            this.top = this.top.next;
        }

        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}