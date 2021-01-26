using System;
using System.Collections.Generic;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Hero_Properties properties = new Hero_Properties();

            properties.HeroName = "Jojo";
            properties.Class = "Saber";

            properties.ShowInformation();

            Hero_Methods methods = new Hero_Methods();
            methods.ShowSkill();
            methods.ShowLevel();
            methods.ShowKilledMonsters();



            Monster monster = new Monster();
            monster.Health = 10;
            monster.Experience = 5;
            monster.ShowInformation();
            
			Hero hero = new Hero();
            hero.Damage = 5;
            hero.Experience = 0;
            hero.NewLevelExperience = 10;

            hero.ShowInformation();
            hero.Move();
            hero.Attack(monster);
            hero.Attack(monster);
            hero.ShowInformation();

            monster.Health = 10; // instead of creating new monster, same monster will be alive again
            hero.Attack(monster);
            hero.Attack(monster);

            Console.WriteLine("*****************************");
            monster.ShowInformation();
            hero.ShowInformation();
            methods.ShowKilledMonsters();

            Console.Read();
        }
    }
}
