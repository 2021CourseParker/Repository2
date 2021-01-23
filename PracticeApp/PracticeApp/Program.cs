using System;
using System.Collections.Generic;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // VAR
            // METHODS
            // ARRAYS
            // LIST
            // CLASS


            int[] someArray = new int[5];
                            
            
            int counter = 0;

            for (int i = 0; i < someArray.Length; i++)
            {
                someArray[i] = i;                
            }


            for (int i = 0; i < someArray.Length; i++)
            {
                Console.WriteLine(someArray[i]);
            }

            List<int> someData = new List<int>();



            for (int i = 0; i < 5; i++)
            {
                someData.Add(i);
            }


            foreach (var item in someData)
            {
                Console.WriteLine(item.ToString());
            }


            Console.Read();
        }
    }
}
