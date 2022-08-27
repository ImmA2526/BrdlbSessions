using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Advanced__Session
{
    //List
    public class PersonContactClass
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public PersonContactClass(string ssn, string name, string address, int age)
        {
            SSN = ssn;
            Name = name;
            Address = address;
            Age = age;
        }
    }

    //Stack Que + LinkedList
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }



    //SortedLinkedList
    //public class SortedNode
    //{
    //    public int data;
    //    public SortedNode next;
    //    public SortedNode(int data)
    //    {
    //        this.data = data;
    //    }
    //}
}
