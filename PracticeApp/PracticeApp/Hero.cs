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
        public int Level { get; set; } = 1;

        public string HeroName { get; set; }
        public string Class { get; set; }
        public List<string> Skills { get; set; }       
        public List<string> KilledMonsters { get; set; }


        public Hero()
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
            int initailMonsterHealth = monster.Health;
            Console.WriteLine("Hero attacks monster");
            monster.Health = monster.Health - this.Damage;          // remove health from monster
            Console.WriteLine("monster health: " + monster.Health + "/" + initailMonsterHealth);
            
            if (monster.Health <= 0)    // is the monster dead
            {
                this.Experience = this.Experience + monster.Experience;
                Console.WriteLine("Monster is dead. You gained " + monster.Experience + " experience");

                this.UpdateKilledMonsters(monster);
                

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
            this.Level++;
            this.Experience = 0;
            Console.WriteLine("Hero level UP!");
        }


        public void ShowSkills()
        {
            Console.WriteLine("Hero Skills:");
            foreach (var skill in this.Skills)
            {
                Console.WriteLine("- " + skill);
            }
        }

        public void ShowKilledMonsters()
        {
            Console.WriteLine("Killed monsters:");
            foreach (var killedMonster in this.KilledMonsters)
            {                
                Console.WriteLine("- " + killedMonster);
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
