using System;
using System.Collections.Generic;
using System.Text;

namespace Basic__AllSession
{
    class S8__CallBy_ValuesAndRefrenceProgram
    {
        //Call By Value 
        public void PassByValue_Addition(int num)
        {
            num = num + 10;
            Console.WriteLine("Value is:" + num);
        }

        public void PassByValue()
        {
            int numMul = 20;
            PassByValue_Addition(numMul);
            Console.WriteLine("Inside PasssByValue " + numMul +"\n\n");
        }

        //Refrence Type
        public void PassByRefrence_Substraction(ref int value)
        {
            value = value - 10;
            Console.WriteLine("Substraction value is : "+value);
        }
        public void PassByRefrence()
        {
            int numDiv = 30;
            PassByRefrence_Substraction(ref numDiv);
            Console.Write("Inside PasssByRefrecne: "+ numDiv+"\n");
        }

        //PassBy Out : Out Keyword
        public void PassByOut_Devide(out int value)
        {
            value = 60;
            Console.WriteLine("\nOutValue  is : " + value);
        }
        public void PassByOut()
        {
            int numDivide;
            PassByOut_Devide(out numDivide);
            Console.Write("Inside PasssByOut: " + numDivide + "\n");
        }
    }
}
