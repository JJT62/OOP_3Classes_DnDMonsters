using System;
using System.Collections.Generic;
using System.Text;

namespace DnDMonsters
{
    class Goblin
    {
        public int hp = 7;
        public int ac = 15;
        public int damage = 5;
        public int toHit = 4;
        public string CR = "1/4";
        private int hitDiceNum = 2;
        private int hitDiceValue = 6;
        private int hitDiceBonus = 0;
        private int damageDiceNum = 1;
        private int damageDiceValue = 6;
        private int damageBonus = 2;
        public string speed = "30 ft.";
        public string size = "Small";
        public string attack = "Scimitar";

        public void RollForHP()
        {
            Random random = new Random();
            var n = random.Next(1, (hitDiceValue + 1));
            hp = (hitDiceNum * (n)) + hitDiceBonus;
        }

        public void RollForDamage()
        {
            Random random = new Random();
            var n = random.Next(1, (damageDiceValue + 1));
            damage = (damageDiceNum * (n)) + damageBonus;
        }

        public void resetDefaultDamage()
        {
            damage = 5;
        }

        public void ShowStats()
        {
            Console.WriteLine("Size: {0}", size);
            Console.WriteLine("Armor Class {0}", ac);
            Console.WriteLine("Hit Points {0}", hp);
            Console.WriteLine("Speed {0}", speed);
            Console.WriteLine("Challenge {0}", CR);
        }

        public void doAttack()
        {
            Random random = new Random();
            var n = random.Next(1, 21);
            int rolledToHit = n + toHit;
            Console.WriteLine("Doing {0} Attack", attack);
            Console.WriteLine("To Hit: {0}", rolledToHit);
            Console.WriteLine("Damage: {0} slashing damage.", damage);
        }
    }
}
