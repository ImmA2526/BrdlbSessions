using System;
using System.Collections.Generic;
using System.Text;

namespace Basic__AllSession
{
    class S7__ArraysAndTypes
    {
        //***********Defining Array****|| Single Dimensioanl Array******              
        //dataType[] variable0 = new dataType[5];         
        //dataType[] variable1 = new dataType[] { "abc","abc","abc"};
        //dataType[] variable2 = { 1.0, 2.0, 3.0, 4.0, 5.0 };

        //dataType[] variabel1, variable2;
        public void SingleDimensionalArray()
        {
            int[] number = new int[5];
            Console.WriteLine($"Numbers Are: {number[0] = 1} , {number[1] = 11},  {number[2] = 110},{number[3] = 'C'} ,{number[4] = 'D'} \n");
            //Console.WriteLine($"Char is: {number[5] = 'Z'}");  //Out of  Range
            //Console.WriteLine($"{number[4] = "C"}");   //Having Error 

            //Using ForEach
            string[] city = { "Panvel", "Pune", "Nanded", "Latur", "Beed", "Mumbai", "Dubai" };
            Console.Write($"Length of Array is : {city.Length} \n\nCities Are: \t");
            foreach (string cities in city)
                Console.Write(cities +", ");

            //User Accepted Array
            Console.Write("\n\nHow Many Numbers you want: ");
            int userArray = Convert.ToInt32(Console.ReadLine());
            
            int[] arrays = new int[userArray];
            for (int i = 0; i < userArray; i++)
            {
                Console.Write("Enter Data Value:  ");
                int finalyArray = Convert.ToInt32(Console.ReadLine());
                arrays[i] = finalyArray;
            }
            Console.WriteLine("\n****** Your Final Array is: ************");
            Console.Write("Final Array is: ");
            foreach(int data in arrays)
                Console.Write(data +"  ");
        }

        ////***MultiDimensioanl Dimensioanl Array******
        ///                 Rectanuglar Array
        //  dataTtype[Row, Clm] variable = new dataType[Row, Clm];
        //  dataTtype[Row, Clm] variable = new dataType[Row, Clm]{  { {1,2,3},{4,5,6},{7,8,9} }  };
        //  dataTtype[Row, Clm] variable = {  { {1,2,3},{4,5,6},{7,8,9} }  };
        //  dataTtype[Row, Clm] variable = new dataType[Row, Clm];
        
        //                  Jagged Array

        //dataTyoe[Row][Colm] variable = new dataType[Row][Colum]  JaggedArray

        //            0  1   2  3  <<Col
        //   Row>> 0 {12,24,36,48 },
        //         1 {60,72,84,96 },
        //         2 {10,20,20,40 },
        public void MultiDimensionalArray()
        {
            int[,] numbers = new int[3, 4]
            {
                {12,24,36,48 }, // Rectangular Array.
                {60,72,84,96 },
                {10,20,30,40 },
            };
            Console.WriteLine($"\nElements of Array is: {numbers[1,2]} \n");
            Console.WriteLine($"Dimension Array is: { numbers.GetLength(0)} \t Size of Dimension {numbers.Rank} "  +"\n");

            Console.WriteLine("*********** For Loop ******** \n");
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.Write(numbers[i,j]+"  ");
            //    }
            //    Console.WriteLine();
            //}

            foreach (int number in numbers)
                Console.Write(number + "  ");

            // Jagged Array
            int[][] numericalValues = new int[3][];
            numericalValues[0] = new[] { 12, 24, 36, 48,99,88,77 }; // Rectangular Array.
            numericalValues[1] = new[] { 60, 72, 84, 96,00 };
            numericalValues[2] = new[] { 10, 20, 30,44 };

            Console.WriteLine("\n******** ForeachLoop **********");
            foreach (int[] number in numericalValues)
            {
                foreach (int i in number) 
                {
                    Console.Write(i + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nValue of JaggedArray is: {numericalValues[1][2]}");
        }
    }
}
