using System;
using Projeto_2.SRC.Entities;

namespace segundoprojeto
{
    class program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Warrior warrior = new Warrior("James", 45, "Warrior");
            Orc orc = new Orc("Azog", 50, "Orc");

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(warrior.Attack(6));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(warrior.Attack(3));
            Console.WriteLine(arus.Attack(10));
            Console.WriteLine(orc.Attack(12));
        }
    }
}