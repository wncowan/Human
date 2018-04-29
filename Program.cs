using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human my_human = new Human("steve", 10, 5, 5, 78);
            Human your_human = new Human();
            my_human.Attack(your_human);
            Console.WriteLine("my human name " + my_human.name);
            Console.WriteLine("MH strength " + my_human.strength);
            Console.WriteLine("MH intelligence " + my_human.intelligence);
            Console.WriteLine("MH dexterity " + my_human.dexterity);
            Console.WriteLine("MH health " + my_human.health);

            Console.WriteLine("YH human name " + your_human.name);
            Console.WriteLine("YH strength " + your_human.strength);
            Console.WriteLine("YH intelligence " + your_human.intelligence);
            Console.WriteLine("YH dexterity " + your_human.dexterity);
            Console.WriteLine("YH health " + your_human.health);
        }
    }
}
