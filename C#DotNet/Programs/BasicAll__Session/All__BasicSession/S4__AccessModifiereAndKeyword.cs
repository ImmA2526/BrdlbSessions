using System;
using System.Collections.Generic;
using System.Text;

namespace Basic__AllSession
{
    public class S4__AccessModifiereAndKeyword
    {
        public int no1;
        int no11;

        //Public 
        public void PublicArithmaticOperation()  //Non Static Method
        {
            int no1 = 60, no2 = 20, sum;
            Console.WriteLine($"Addition is: {no1 + no2}");
            Console.WriteLine($"Substractino is : {no1 - no2}");
            Console.WriteLine($"Multiplicaton is: {no1 * no2} \n");

            Console.WriteLine("************ ProgramAssignment Called :- ******* \n");
            PrivateAssignmentOperator();
            //ProtectedOperation();
        }

        //Private
        private void PrivateAssignmentOperator()   //PrivateMethod bydefault
        {
            string name = "Program";
            Console.WriteLine("ProgramName: " + name + "\n");
            //S4_AccessModifiereAndKeyword core = new S4_AccessModifiereAndKeyword();
            //core.PublicArithmaticOperation();
        }

        //Protected
        protected void ProtectedOperation()
        {
            Console.WriteLine("********** Protected Method *******");
            double num = 12.55;
            int num2 = 10;
            Console.WriteLine($"Addition is : {num + num2}");
        }

        //Internal
        internal void InternalMethod()
        {
            Console.WriteLine("********** Internal Method ************");
            string firstName = "Imran", lastName = "Shaikh", final;
            final = firstName + lastName;
            Console.WriteLine("After Joining String " + final);
        }
    }

    class ChildClass : S4__AccessModifiereAndKeyword //Child Class OR Derived Class  : Inheritance
    {
        public void PublicLogicalOperation()  //Non Static Method
        {
            //no11 = 20;  // PrivateVariable
            no1 = 100;
            int no12 = 200;
            Console.WriteLine(no1 == no12);
            Console.WriteLine(no1 > no12);
            Console.WriteLine();

            Console.WriteLine("********** Method Called **********");
            ChildClass child = new ChildClass();
            //child.PublicArithmaticOperation();

            //child.PublicAssignmentOperator();   cannot accept
            //S4_AccessModifiereAndKeyword core = new S4_AccessModifiereAndKeyword();
            //core.PublicAssignmentOperator();

            child.ProtectedOperation();
            child.InternalMethod();
        }
    }
}
