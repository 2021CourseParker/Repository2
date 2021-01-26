using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp
{
    class Hero_Properties​
    {
        public string HeroName { get; set; }
        public string Class { get; set; }
        public List<string> Skills { get; set; }
        //public Array<string> KilledMonsters { get; set; }
       
        public void ShowInformation()
        {
            Console.WriteLine("Hero Name: " + HeroName);
            Console.WriteLine("class: " + Class);
            Console.WriteLine("skill:" + Skills);
            

        }

    }
}
