using System;
using System.Collections.Generic;
using System.Text;

namespace Basic__AllSession
{
    class S3__OperatorAndTypeConversion
    {
        static int no1 = 10, no2 = 10, no3 = 21, no4=22, sum;
        public void OperatorAndConversion()
        {
            int num = 0; int[] num1 = { };

            //Console.WriteLine("*********Arithmatic Operation****** \n");
            sum = no1 + no2;
            Console.WriteLine("Addition: \t" + sum);
            Console.WriteLine($"Substraction: \t {no3 - no2}");
            Console.WriteLine($"Multiplication:\t {no3 * no1}");
            Console.WriteLine($"Division is: \t {no3 / no2} \n");

            Console.WriteLine("*********Assignment Operation****** \n");
            Console.WriteLine($"Assign Value \t {no1 = no3}");
            Console.WriteLine($"Add Equal \t {sum += no3}");
            Console.WriteLine($"Sub Equal \t {sum -= no3} \n");

            Console.WriteLine("*******Prefix PostFix Operation******* \n");
            //EG: a = 1; >>  b = a++;  >> b = 1 then a will incremenet .: a = 2 and b = 1  // Postfix 
            Console.WriteLine($"Postfix -- :\t {sum = no3--} ");
            Console.WriteLine($"Postfix ++ : \t {sum = no3++} \n");

            //EG: a = 1; >>  b = ++a;  >> 1st a will incremenet .: a = 2 then b = a and b = 2  // Prefix 
            Console.WriteLine($"--Prefix  : \t {sum = --no3}");
            Console.WriteLine($"++ Prefix  :\t {sum = ++no3} \n");


            Console.WriteLine("*********Logical & Relational****** \n");
            if (no1 == no2 || no3 == no4)
            {
                //Console.WriteLine("The Number is Equal");
                Console.WriteLine(">>>>>>>>>>The Number is Greater");
            }
            else
            {
                Console.Write(">>>>>>>>>>>>>>Less Number \n");
                //Console.Write("Not Equal");
            }
            Console.WriteLine();

            Console.WriteLine("*********Misslenius Operation****** \n");
            Console.WriteLine("Size of DataType int is: " + sizeof(int));
            Console.WriteLine("Size of DataType int is: " + sizeof(float));
            Console.WriteLine("Type of : "+ typeof(S3__OperatorAndTypeConversion));
            Console.WriteLine("Type of ArrayDataType : " + typeof(int[]));
            Console.WriteLine("Type of integer Data : " + typeof(int));
            //Console.WriteLine("sizeof Array : " + sizeof(string[]));
            Console.WriteLine();

            Console.WriteLine("*********Ternary or Condition Operator ****** \n");
            sum = no2 > no3 ? no2 : no3;
            Console.WriteLine("Conditional Operator " +sum+ "\n");

            Console.WriteLine("*********TYPE CONVERSION : Implicit ****** \n");
            int number = 66;
            long dataNo = number;
            float value = dataNo;
            Console.WriteLine($"Value of Number : {number} \t value of Data : {dataNo} \t value : {value}");

            Console.WriteLine("*********TYPE CONVERSION : Explicit ****** \n");
            double decimalValue = 1122.880F;
            int a;
            a = Convert.ToInt32(decimalValue);
            //a = (int)decimalValue;
            //a = Convert.ToInt32(decimalValue);
            Console.WriteLine("Value of A after Convertion: " +a );

            Console.WriteLine("*********Boxing Unboxing ****** \n");
            //Boxing
            string name = "Imran";
            object fName = name;
            name = "Aniket";
            Console.WriteLine("Hello : " +name);
            Console.WriteLine("Hello Boxer Object : " + fName);

            //Unboxing
            string lName = Convert.ToString(fName);
            Console.WriteLine("Hello Unboxer Object : " + lName);
        }
    }
}
