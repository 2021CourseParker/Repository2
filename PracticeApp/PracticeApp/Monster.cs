using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp
{
    class Monster
    {
        public string Name { get; set; }    // Monster's name
        public int Health { get; set; }
        public int Experience { get; set; } // how much experience this monster gives when killed

        public Monster()    // You will have to give name to monster in main program
        {
            this.Health = 10;
            this.Experience = 5;
        }

        public void ShowInformation()       // Print on the screen all important information about monster
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Monster info: ");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Experience: " + Experience);
            Console.WriteLine("-------------------------------------");            
        }
    }
}
