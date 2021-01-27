using System;
using System.Collections.Generic;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Monster monster = new Monster();
            monster.Name = "Orc";
            monster.ShowInformation();

            Hero hero = new Hero();
            hero.ShowInformation();

            hero.Move();
            hero.Attack(monster);
            hero.Attack(monster);
            hero.ShowInformation();

            Monster monster2 = new Monster();
            monster2.Name = "Ghoul";
            
            hero.Attack(monster2);
            hero.Attack(monster2);

            Console.WriteLine("*****************************");
            monster.ShowInformation();
            hero.ShowInformation();
            hero.ShowSkills();
            hero.ShowKilledMonsters();

            Console.Read();
        }
    }
}
