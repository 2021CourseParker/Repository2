using System;
using System.Collections.Generic;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster monster = new Monster();
            monster.Health = 10;
            monster.Experience = 5;
            monster.ShowInformation();


            Console.Read();
        }
    }
}
