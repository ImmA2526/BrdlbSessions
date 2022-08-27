using System;
using System.Collections.Generic;
using System.Text;

namespace Basic__AllSession
{
    class S10__ParamsAndIndexer
    {
        public void Params_Operation(params int[] number)
        {
            int sum = 0;

            foreach (int i in number)
                sum = sum + i;

            Console.Write("Addition is: " + sum);
        }

        public void Params_Array(params string[] names)
        {
            Console.Write("\n\nThe Names Are: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + "  ");
            }
        }

        public void Params_MultipleValue(int no1, int no2, int no3, char a, char b, params string[] names)
        {
            int sum = 0;
            sum = no1 + no2 + no3;
            Console.Write("\nAddition is: " + sum);
            Console.WriteLine($"\nCharacter Are : {a}\t {b}");

            Console.Write("\nThe Names Are: ");
            foreach (string name in names)
                Console.Write(name + "  ");
        }
    }

    //****************** Indexer ******************/
    class Indexer
    {
        private string[] name = new string[4];
        public string this[int index]
        {
            set
            {
                name[index] = value;
            }
            get
            {
                return name[index];
            }
        }
    }

    class IndexerAccept
    {
        public static void Indexer_Accept()
        {
            Indexer index = new Indexer();
            index[0] = "Imran";
            index[1] = "Shaikh";
            index[2] = "Pune";
            index[3] = "IPune";
            Console.WriteLine("\nFull Name: " +index[0]+" "+index[1]+" "+index[2]);
        }
    }
}

