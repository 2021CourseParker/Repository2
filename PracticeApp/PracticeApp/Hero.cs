using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp
{
    class Hero
    {
        public int Damage { get; set; }             
        public int Experience { get; set; }         
        public int NewLevelExperience { get; set; } // How much experience Hero needs for next level
        public int Level { get; set; } = 1;         // Current level of a hero

        public string HeroName { get; set; }
        public string Class { get; set; }           // Type of hero
        public List<string> Skills { get; set; }
        public List<string> KilledMonsters { get; set; }    // Killed monsters name list


        public Hero()       // Defining Hero data in constructor
        {
            this.HeroName = "Jojo";
            this.Class = "Saber";
            this.Damage = 5;
            this.Experience = 0;
            this.NewLevelExperience = 10;
            this.Skills = new List<string>();
            this.KilledMonsters = new List<string>();
            this.AddSkill("star burst stream");
            this.AddSkill("water ball");
        }



        public void ShowInformation()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hero info: ");
            Console.WriteLine("Hero Name: " + HeroName);
            Console.WriteLine("class: " + Class);
            this.ShowSkills();
            Console.WriteLine("Damage: " + Damage);
            Console.WriteLine("Experience/NewLevel: " + Experience + "/" + NewLevelExperience);            
            Console.WriteLine("-------------------------------------");
        }

        public void Attack(Monster monster)
        {         
            int initialMonsterHealth = monster.Health;          // Monster health before attack
            Console.WriteLine("Hero attacks monster");
            monster.Health = monster.Health - this.Damage;          // set monster health after attack
            Console.WriteLine("monster health: " + monster.Health + "/" + initialMonsterHealth);
                        
            if (monster.Health <= 0)    // check after attack if the the monster is dead 
            {
                this.Experience = this.Experience + monster.Experience; // since monster is dead increase experience
                Console.WriteLine("Monster is dead. You gained " + monster.Experience + " experience");

                this.UpdateKilledMonsters(monster);         // add this monster to the list of killed monsters
                

                if (this.Experience >= this.NewLevelExperience)     // if monster is dead and experience is enough - level UP
                {
                    this.LevelUp();
                    this.Experience = 0;
                    this.NewLevelExperience = this.NewLevelExperience + 1;      // on next Level we will need more experience to Level Up
                }
            }
            
        }

        public void Move()
        {
            Console.WriteLine("Hero is moving");
        }

        public void LevelUp()
        {
            this.Level++;
            this.Experience = 0;                // When you Level UP your experience needs to be back to zero  (10/10) ==> (0/11)
            Console.WriteLine("Hero level UP!");
        }


        public void ShowSkills()
        {
            Console.WriteLine("Hero Skills:");
            foreach (var skill in this.Skills)      // Go through the list one by one
            {
                Console.WriteLine("- " + skill);    // show each element of the list
            }
        }

        public void ShowKilledMonsters()
        {
            Console.WriteLine("Killed monsters:");
            foreach (var killedMonster in this.KilledMonsters)  // Go through the list one by one
            {                
                Console.WriteLine("- " + killedMonster);        // show each element of the list
            }              
        }

        public void ShowLevel()
        {           
            Console.WriteLine("Level: " + this.Level);
        }

        public void AddSkill(string skillName)
        {
            this.Skills.Add(skillName);
        }

        public void UpdateKilledMonsters(Monster monster)
        {
            this.KilledMonsters.Add(monster.Name);
        }
    }
}
