using System;
using System.Collections.Generic;
using System.Text;

//Session 1 Introduction and NameSpace
namespace Basic__AllSession
{
    class S1__NestedNamespace
    {
        int a = 0, b = 0, c =0;
        public void Addition()
        {
            this.a = 20;
            this.b = 30;
            this.c = a + b;
            Console.WriteLine("Hello Namespace 1 & Addition is " +this.c);
        }
    }
  
    namespace nestedNamespace 
    {
        class NestedName
        {
            int x = 0, y = 0, z = 0;
            public void Multiplication()
            {
                this.x = 20;
                this.y = 30;
                this.z = x * y;
                Console.WriteLine("Hello Namespace 2 & Multiplication is " + this.z);
            }
        }
    }
}

