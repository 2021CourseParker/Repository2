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

            Console.Read();
        }
    }
}
