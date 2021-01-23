using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp
{
    class Hero
    {
        public int Damage { get; set; }
        public int Experience { get; set; }
        public int NewLevelExperience { get; set; }

        public void ShowInformation()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hero info: ");
            Console.WriteLine("Damage: " + Damage);
            Console.WriteLine("Experience/NewLevel: " + Experience + "/" + NewLevelExperience);            
            Console.WriteLine("-------------------------------------");
        }

        //public void Attack(Monster monster)
        //{
        //    if (monster.Health <= 0)
        //    {
        //        this.Experience = this.Experience + monster.Experience;
        //        Console.WriteLine("Monster is dead. You gained " + monster.Experence + " experience");
        //    }
        //    monster.Health = monster.Health - this.Damage;
        //}

        public void Move()
        {
            Console.WriteLine("Hero is moving");
        }

        public void LevelUp()
        {
            Console.WriteLine("Hero level UP!");
        }
        
    }
}
