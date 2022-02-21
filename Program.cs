using System;
using RPG.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja hero_1 = new Ninja("Raizou", 34, "Ninja", 300, 250);
            Bruxo hero_2 = new Bruxo("Gandalf", 298, "Bruxo", 300, 500);

            Console.WriteLine("=====Jogador 1=====");
            Console.WriteLine(hero_1);
            Console.WriteLine("=====Jogador 2=====");
            Console.WriteLine(hero_2);
            Console.WriteLine("===================================");
            Console.WriteLine(hero_1.Attack());
            Console.WriteLine(hero_2.Attack(13));
        }
    }
}