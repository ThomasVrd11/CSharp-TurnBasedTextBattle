using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using textbattle;

namespace textbattle
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Text Battle!");
            System.Console.WriteLine("You will be fighting a series of enemies.");
            System.Console.WriteLine("You will have the option to attack or heal.");
            System.Console.WriteLine("Good luck!");
            System.Console.WriteLine("Enter your name: ");
            string playerName = Console.ReadLine();
            System.Console.WriteLine("Enter the enemy's name: ");
            string enemyName = Console.ReadLine();
            Thread.Sleep(3000);
            System.Console.Clear();
            Unit player = new Unit(100, 100, 10, 10, "Player");
            Unit enemy1 = new Unit(100, 100, 10, 10, "Enemy 1");
            System.Console.WriteLine("You are fighting " + enemy1.Unitname + "!");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
            System.Console.Clear();
            while (!player.IsDead() && !enemy1.IsDead())
            {
                player.printStats();
                enemy1.printStats();
                System.Console.WriteLine("Press a to attack or h to heal.");
                string input = System.Console.ReadLine();
                if (input == "a")
                {
                    player.Attack(enemy1);
                }
                else if (input == "h")
                {
                    player.Heal(player);
                }
                else
                {
                    System.Console.WriteLine("Invalid input!");
                }
                if (!enemy1.IsDead())
                {
                    enemy1.ennemyMove(player, enemy1);
                }

                System.Console.WriteLine("Player health: " + player.currentHp);
                System.Console.WriteLine("Enemy health " + enemy1.currentHp);
                System.Console.WriteLine("Press any key to continue...");
                System.Console.ReadKey();
                System.Console.Clear();
            }
        }
    }
}