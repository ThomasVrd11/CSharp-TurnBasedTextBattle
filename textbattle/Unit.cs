using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbattle
{
    internal class Unit
    {
        public int currentHp;
        private int maxHp;
        private int attackPower;
        private int healPower;
        public string Unitname;

        Random random = new Random();
        public Unit(int currentHp, int maxHp, int attackPower, int healPower, string Unitname)
        {
            this.currentHp = currentHp;
            this.maxHp = maxHp;
            this.attackPower = attackPower;
            this.healPower = healPower;
            this.Unitname = Unitname;
        }
        public void TakeDamage(int damage)
        {
            currentHp -= damage;
            if (currentHp < 0)
            {
                currentHp = 0;
            }
        }
        public void Attack(Unit unitToAttack)
        {
            int damage = attackPower;
            unitToAttack.TakeDamage(damage);
            Console.WriteLine(Unitname + " attacked " + unitToAttack.Unitname + " for " + damage + " damage!");
        }
        public void Heal(Unit unitToHeal)
        {
            int heal = healPower;
            unitToHeal.currentHp += heal;
            if (unitToHeal.currentHp > unitToHeal.maxHp)
            {
                unitToHeal.currentHp = unitToHeal.maxHp;
            }
            Console.WriteLine(Unitname + " healed " + unitToHeal.Unitname + " for " + heal + " health!");
        }
        public bool IsDead()
        {
            return currentHp == 0;
        }
        public void printStats()
        {
            Console.WriteLine(Unitname + " has " + currentHp + " health and " + attackPower + " attack power!");
        }
        public void getPlayerName()
        {
            Console.WriteLine("Enter your name: ");
            Unitname = Console.ReadLine();
        }
        public void getEnemyName()
        {
            Console.WriteLine("Enter the enemy's name: ");
            Unitname = Console.ReadLine();
        }
        public void remainingHealth()
        {
            Console.WriteLine(Unitname + " has " + currentHp + " health remaining!");
        }
        public void ennemyMove(Unit unitToAttack, Unit unitToHeal)
        {
            int move = random.Next(1, 3);
            if (move == 1)
            {
                Attack(unitToAttack);
            }
            else
            {
                Heal(unitToHeal);
            }
        }
    }

}