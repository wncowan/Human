using System;

namespace human{
    public class Human{
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }
        public Human(){
            name = "bub";
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string my_name, int my_strength, int my_intelligence, int my_dexterity, int my_health){
            name = my_name;
            strength = my_strength;
            intelligence = my_intelligence;
            dexterity = my_dexterity;
            health = my_health;
        }
        public void Attack(object victim){
            
            if (victim is Human){
                Console.WriteLine("is human");
                Human ExplicitVictim = victim as Human;
                ExplicitVictim.health -= strength * 2;
            }
        }
    }
}