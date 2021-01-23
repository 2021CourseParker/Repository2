using System;

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
          
            

            Console.Read();
        }
    }
}
