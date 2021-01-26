using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp
{
    class Hero_Methods
    {
       public void UpdateSkill()
        {

        }

        public void UpdateKilledMonsters()
        {

        }

        public void ShowSkill()
        {
            Hero_Properties properties = new Hero_Properties();
            var skills = new List<string>()
            {
                "star burst stream"
            };
            properties.Skills = skills;
            Console.WriteLine(properties.Skills);
        }

        public void ShowKilledMonsters()
        {
            Monster moster = new Monster();
            int KilledMosters = 0;
            if (moster.Health <= 0)
            {
                KilledMosters = KilledMosters + 1;
            }
            Console.WriteLine("KilledMosters " + KilledMosters) ;
       
        }

        public void ShowLevel()
        {
            Hero hero = new Hero();
            Console.WriteLine("Level: " + hero.Experience);

        }

       

    }
}
