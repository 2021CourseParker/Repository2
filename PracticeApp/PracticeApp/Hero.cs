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

        public void Attack(Monster monster)
        {
            int initailMonsterHealth = monster.Health;
            Console.WriteLine("Hero attacks monster");
            monster.Health = monster.Health - this.Damage;          // remove health from monster
            Console.WriteLine("monster health: " + monster.Health + "/" + initailMonsterHealth);
            
            if (monster.Health <= 0)    // is the monster dead
            {
                this.Experience = this.Experience + monster.Experience;
                Console.WriteLine("Monster is dead. You gained " + monster.Experience + " experience");

                if (this.Experience >= this.NewLevelExperience)     // if monster is dead and experience is enough - level UP
                {
                    this.LevelUp();
                    this.Experience = 0;
                    this.NewLevelExperience = this.NewLevelExperience + 1;
                }
            }
            
        }

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
