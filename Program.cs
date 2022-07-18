using System;
using dio_heroes.Entities;

namespace dio_heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do heroi: ");
            string title = Console.ReadLine();
            Console.Write("Digite a profissão: ");
            string profession = Console.ReadLine();
            Hero hero = new Hero(title, profession);
            Console.WriteLine();

            Console.Write("Digite o nome do heroi: ");
            title = Console.ReadLine();
            Console.Write("Digite a profissão: ");
            profession = Console.ReadLine();
            Mage mage = new Mage(title, profession);
            Console.WriteLine();

            Console.Write("Digite o nome do inimigo: ");
            title = Console.ReadLine();
            Console.Write("Digite a profissão: ");
            profession = Console.ReadLine();
            Enemy enemy = new Enemy(title, profession);
            Console.WriteLine();

            Console.WriteLine(hero.Attack());
            Console.WriteLine();
            Console.WriteLine(enemy.Attack());
            Console.WriteLine();


            if (hero.LastAttackPower == enemy.LastAttackPower)
            {
                Console.WriteLine("Empate, ambos emitiram " + hero.LastAttackPower + "de dano!");
            }
            else if (hero.LastAttackPower > enemy.LastAttackPower)
            {
                enemy.ReceiveDamage(hero.LastAttackPower - enemy.LastAttackPower);
                Console.WriteLine(hero.Title + " venceu esta batalha.");
            }
            else
            {
                hero.ReceiveDamage(enemy.LastAttackPower - hero.LastAttackPower);
                Console.WriteLine(enemy.Title + " venceu esta batalha.");
            }

        }
    }
}