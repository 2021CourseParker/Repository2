using System;
using System.Collections.Generic;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Damage = 5;
            hero.Experience = 0;
            hero.NewLevelExperience = 10;

            hero.ShowInformation();
            hero.Move();

            if (hero.Experience >= hero.NewLevelExperience)
            {
                hero.LevelUp();
                hero.Experience = 0;
                hero.NewLevelExperience = hero.NewLevelExperience + 1;
            }

            Console.Read();
        }
    }
}
