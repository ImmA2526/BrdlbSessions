using System;
using System.Collections.Generic;
using System.Text;

namespace Basic__AllSession
{
    class S5__StatmntAndSelectionStmntProgram
    {
        public void MarkChecker()
        {
            //IF...IF Then IF...else if
            Console.Write("Enter Percentage value \t");
            int percentage = int.Parse(Console.ReadLine());
            if (percentage >= 80)
                Console.WriteLine("Congrats!  You Pass the Exam");
            // Console.WriteLine("Wish You best Luck");        // Error 
            else if (percentage >= 60)
                Console.WriteLine("Good! You Are Eligible For Commerce");
            else if (percentage >= 50)
                Console.WriteLine("All The Best");
            else if (percentage < 35)
                Console.WriteLine("Failed");
            else
                Console.WriteLine("Sorry! \tTry Next Time");
        }

        //Nested If OR If...If OR else...IF
        public void NestedIf()
        {
            int no1 = 52;
            if (no1 > 50)
            {
                if (no1 < 40)
                    Console.Write("Less");
                else
                    Console.Write("Big");
            }
            else
            {
                if (no1 == 52)
                    Console.WriteLine("Value is Eqaul");
                else
                    Console.WriteLine("Value is NotEqual");
            }
        }

        //switchCase
        public void SwitchCase()
        {
            Console.WriteLine("Enter Week Number \t");
            int weekNo = int.Parse(Console.ReadLine());
            switch (weekNo)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednsday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Enter Valid Number");
                    break;
            }
        }

        public void SwitchGroup()
        {
            Console.Write("Enter Character\t ");
            char alpha = Convert.ToChar(Console.ReadLine());
            switch (alpha)
            {
                case 'a':
                case 'e':
                case 'o':
                case 'u':
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'A':
                    Console.Write("**********You Are in Capital Alphabate :-- \n Enter Capital Character:  ******* \t");
                    char cap = Convert.ToChar(Console.ReadLine());
                    switch (cap) //Nested Case
                    {
                        case 'A':
                        case 'E':
                        case 'O':
                        case 'U':
                        case 'I':
                            Console.Write($"{cap} is Vowel");
                            break;
                        default:
                            Console.WriteLine($"{cap} Not Vowel");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Not Vowel");
                    break;
            }
        }
        //Program For Even Odd Prime , Fibonnaci Series
        public void MultipleProgram()
        {
            int mainNo, switchNumber, number, fibNo1 = 0, fibNo2 = 1, i, sum = 0, rem, temp;
            Console.WriteLine("1.Even Odd \n 2.Prime Not Prime \n 3.Nested Switch :\n \t 1.Armstrong No \n \t 2.Palindrome No \n \t 3.Fibonacci Seires");
            Console.Write("Enter Choice: ");
            switchNumber = Convert.ToInt32(Console.ReadLine());

            switch (switchNumber)
            {
                case 1:
                    Console.WriteLine("*******You Are in EvenOdd Number*********");
                    Console.Write("Enter Number: \t");
                    mainNo = Convert.ToInt32(Console.ReadLine());
                    if (mainNo % 2 == 0)
                        Console.WriteLine($"{mainNo} is Even Number");
                    else
                        Console.WriteLine($"{mainNo} is Odd Number");
                    break;

                case 2:
                    Console.WriteLine("*********You Are in Prime NotPrime*********");
                    Console.Write("Enter Number: \t");
                    mainNo = Convert.ToInt32(Console.ReadLine());
                    for (i = 2; i <= mainNo / 2; i++)
                    {
                        if (mainNo % i == 0)
                        {
                            Console.WriteLine($"{mainNo} is NotPrime Number");
                            sum++;
                            break;
                        }
                    }
                    if (sum == 0)
                        Console.WriteLine($"{mainNo} is Prime Number");
                    break;

                case 3:
                    Console.WriteLine("\t 1.Armstrong \n \t 2.Palindrome No \n\t 3.FibonacciSeries\n\t 4.PerfectNumber 1 to 100\n\t 5.Palindrome 1 to 100");
                    Console.Write("Enter Choice: ");
                    switchNumber = Convert.ToInt32(Console.ReadLine());

                    switch (switchNumber)
                    {
                        case 1:
                            Console.Write("********* Armstrong Number ********* \nEnter Number:\t");
                            mainNo = Convert.ToInt32(Console.ReadLine());
                            temp = mainNo;
                            while (mainNo > 0)
                            {
                                rem = mainNo % 10;
                                sum = sum + (rem * rem * rem);
                                mainNo = mainNo / 10;
                            }
                            if (temp == sum)
                                Console.WriteLine("Armstrong Number");
                            else
                                Console.WriteLine("Not Armstrong Number");
                            break;

                        case 2:
                            Console.Write("*********You Are Palindrome ********* \nEnter Number:\t");
                            mainNo = Convert.ToInt32(Console.ReadLine());
                            temp = mainNo;
                            while (mainNo > 0)
                            {
                                rem = mainNo % 10;
                                sum = sum * 10 + rem;
                                mainNo = mainNo / 10;
                            }
                            if (temp == sum)
                                Console.WriteLine("Palindrome Number");
                            else
                                Console.WriteLine("Not Palindrome Number");
                            break;

                        case 3:
                            Console.Write("*********You Are Fib ********* \nEnter Number:\t");
                            number = Convert.ToInt32(Console.ReadLine());

                            Console.Write(fibNo1 + " " + fibNo2);
                            for (i = 2; i < number; ++i)
                            {
                                sum = fibNo1 + fibNo2;
                                Console.Write(sum + " ");
                                fibNo1 = fibNo2;
                                fibNo2 = sum;
                            }
                            break;

                        case 4:
                            int no = 100;
                            Console.Write("Perfect Number: ");
                            for (i = 1; i < no; i++)
                            {
                                sum = 0;
                                for (int j = 1; j < i; j++)
                                {
                                    if (i % j == 0)
                                        sum = sum + j;
                                }
                                if (sum == i)
                                    Console.Write(i + " ");
                            }
                            break;
                        case 5:
                            Console.WriteLine("*********You Are Palindrome *********");
                            //int num, temp, sum, rem;
                            Console.Write("Palindrome Number: ");
                            for (int num = 1; num < 100; num++)
                            {
                                sum = 0;
                                temp = num;
                                while (temp > 0)
                                {
                                    rem = temp % 10;
                                    sum = sum * 10 + rem;
                                    temp = temp / 10;
                                }
                                if (num == sum)
                                    Console.Write(num + "  ");
                            }
                            break;

                        default:
                            Console.WriteLine("Enter Valid Choice");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;
            }
        }
    }
}
