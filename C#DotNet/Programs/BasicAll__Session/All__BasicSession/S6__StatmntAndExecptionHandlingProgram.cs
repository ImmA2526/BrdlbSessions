using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Basic__AllSession
{
    class S6__StatmntAndExecptionHandlingProgram
    {
        string[] name = { "Amit", "Navyatha", "Eqbal", "Sayali", "Prakash", "Imran", "Abhilasha", "Aniket", "Arnav", "Ganesh" };

        //ForLoop + Nested For
        public void LoopThroughName()
        {
            Console.Write("Names Are:  ");
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i] + " ");
            }
            Console.WriteLine();
        }

        //While Loop
        public void WhileLoopTable()
        {
            int number, i = 1;
            Console.Write("********You Are in While Loop******** \n    Enter Number:\t ");
            number = Convert.ToInt32(Console.ReadLine());

            while (i <= 10)
            {
                Console.WriteLine($"{number} X {i} = " + number * i);
                i++;
            }
        }

        //DoWhile Loop
        public void DoWhileLoopTable()
        {
            int number, i = 1; // i== counter variable
            Console.Write("********You Are in DoWhile Loop******** \n    Enter Number:\t ");
            number = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine($"{number} X {i} = " + number * i);
                i++;
            } while (i < 0);
        }

        //Continue Break Goto
        public void ContinueBreakGoTo()
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i == 8)
                    goto terminateProgram;
                //continue;
                //if (i == 17)
                //break;

                Console.WriteLine(i);
            }

        terminateProgram:  // GotO
            Console.WriteLine("This is End of The Program:: ");
        }

        //TRY CATCH BLOCK AND MULTIPLE CATCH
        public void TryCatchBlockWithMultipleCatch()
        {
            Console.WriteLine("*******You are in TryCatch MultipleBlock!*****");
            try
            {
                //string name = null;
                //Console.WriteLine(name.Length);

                double a = 100;
                double b = 0;
                double c = a / b;
                Console.WriteLine("C will be" + c);
            }

            catch (DivideByZeroException ex)
            {
                //Console.WriteLine(ex.Message);
                throw;
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)   // Global Exception or Parent Exception of Other Cathc Block 
            {
                Console.WriteLine(ex.Message);
            }
        }

        //User Define Exception
        public void UserException()
        {
            float num = 20;
            float num1 = 0;
            if (num1 == 0)
            {
                throw new S6__CustomExceptionOrUserException(S6__CustomExceptionOrUserException.UserException.INVALID_DATA, "Data is Not Valid");
            }
        }
    }
}
