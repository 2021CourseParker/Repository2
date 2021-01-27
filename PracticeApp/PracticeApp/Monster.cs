using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp
{
    class Monster
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Experience { get; set; } // how much experience this monster gives when killed

        public Monster()
        {
            this.Health = 10;
            this.Experience = 5;
        }

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
