using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp
{
    class Monster
    {
        public int Health { get; set; }
        public int Experience { get; set; } // how much experience this monster gives when killed

        public void ShowInformation()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Monster info: ");
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Experience: " + Experience);
            Console.WriteLine("-------------------------------------");            
        }
    }
}
