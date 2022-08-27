//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace OOPS_Advanced__Session
//{
//    public class S25__LikedListAndTypes
//    {
//        internal Node head;

//        public static void LinkedList()
//        {
//            S25__LikedListAndTypes linklist = new S25__LikedListAndTypes();
//            linklist.Add(56);
//            linklist.Add(30);
//            linklist.Add(70);
//            linklist.Add(400);
//            linklist.Add(50);
//            linklist.Add(4500); linklist.Add(70);
//            linklist.Add(40550);
//            Console.Write("list Elements Are : ");
//            //linklist.Display();
//            //linklist.FindElemnt(100);
//            linklist.Display();
//            linklist.InsertPositon(4, 1000);
//            Console.Write("After Insertion ");
//            linklist.Display();
//            //linklist.DeleteNode(40);
//            linklist.RemoveFirstElement();
//            linklist.RemoveLastElement();
//            linklist.DeleteAtFirst();
//            Console.Write("After Deletion ");
//            linklist.Display();
//            linklist.SortedList(40); linklist.SortedList(80); linklist.SortedList(20); linklist.SortedList(5); linklist.SortedList(40); linklist.SortedList(10);
//            linklist.SortedList(40);
//            linklist.Add(400);
//            linklist.Add(50);
//            linklist.Add(4500); linklist.Add(70);
//            linklist.Add(10);
//            Console.Write("Sorted List is :");
//            linklist.Display();
//            Console.WriteLine("Linkelist Size " + linklist.Count());
//        }

//        //Creation of LinkedList
//        public void Add(int data)
//        {
//            Node node = new Node(data);
//            if (this.head == null)
//                this.head = node;
//            else
//            {
//                Node temp = head;
//                while (temp.next != null)
//                    temp = temp.next;

//                temp.next = node;
//            }
//            Console.WriteLine("{0} Inserted Element in list ", node.data);
//        }

//        //Display LinkedList
//        internal void Display()
//        {
//            Node temp = this.head;
//            if (temp == null)
//            {
//                Console.Write("LinkedList is Emplty...");
//                return;
//            }
//            while (temp != null)
//            {
//                Console.Write(temp.data + " -> ");
//                temp = temp.next;
//            }
//            Console.Write("\n");
//        }

//        /// Inserts the Element
//        public void InsertPositon(int Position, int data)
//        {
//            if (Position < 1)
//                Console.WriteLine("...Invalid...");

//            if (Position == 1)
//            {
//                var newNode = new Node(data);
//                newNode.next = this.head;
//                head = newNode;
//            }
//            else
//            {
//                Node temp = head;
//                while (Position-- != 0)
//                {
//                    if (Position == 1)
//                    {
//                        Node node = new Node(data);
//                        node.next = temp.next;
//                        temp.next = node;
//                        break;
//                    }
//                    temp = temp.next;
//                }
//                if (Position != 1)
//                    Console.WriteLine("Positon is not valid...");
//            }
//        }

//        /// Remove the First Element
//        internal void RemoveFirstElement()
//        {
//            if (this.head == null)
//                Console.WriteLine("Linklist Empty");

//            head = head.next;
//        }

//        /// Remove the Last Element.
//        internal void RemoveLastElement()
//        {
//            if (head.next == null)
//                Console.WriteLine("Empty");

//            Node SecondNode = head;
//            while (SecondNode.next.next != null)
//                SecondNode = SecondNode.next;
//            SecondNode.next = null;
//        }

//        ///Finds the elemnt.
//        public Node FindElemnt(int Number)
//        {
//            while (this.head != null)
//            {
//                if (this.head.data == Number)
//                    return this.head;

//                this.head = this.head.next;
//                Console.WriteLine("Element {0} Found in list...", this.head.data);
//            }
//            return null;
//        }

//        //Delete the node And Return Size of list.
//        public void DeleteNode(int Value)
//        {
//            Node temp = head, prev = null;
//            if (temp != null && temp.data == Value)
//            {
//                head = temp.next;
//                return;
//            }
//            while (temp != null && temp.data != Value)
//            {
//                prev = temp;
//                temp = temp.next;
//            }
//            if (temp == null)
//                return;
//            prev.next = temp.next;
//        }

//        public int Count()
//        {
//            Node temp = head;
//            int count = 0;
//            while (temp != null)
//            {
//                count++;
//                temp = temp.next;
//            }
//            return count;
//        }

//        /// Sort List And Display  the list Element.

//        public void SortedList(int data)
//        {
//            Node newNode = new Node(data);
//            Node Current;
//            if (head == null || head.data >= newNode.data)
//            {
//                newNode.next = head;
//                head = newNode;
//            }
//            else
//            {
//                Current = head;
//                while (Current.next != null && Current.next.data < newNode.data)
//                    Current = Current.next;

//                newNode.next = Current.next;
//                Current.next = newNode;
//            }
//        }

//        //Delete First Element 
//        public void DeleteAtFirst()
//        {
//            if (head != null)
//            {
//                if (head.next == null)
//                    head = null;

//                else
//                {
//                    Node temp = head;
//                    temp = head;
//                    while (temp.next.next != null)
//                    {
//                        temp = temp.next;

//                    }
//                    Node lastNode = temp.next;
//                    lastNode = null;
//                    temp.next = null;
//                    Console.WriteLine("Remove");

//                }
//            }
//        }
//    }
//}
