using System;
using System.Collections.Generic;
using System.Text;

namespace DnDMonsters
{
    class Ogre
    {
        public int hp = 59;
        public int ac = 11;
        public int damage = 13;
        private int toHit = 6;
        public string CR = "2";
        private int hitDiceNum = 7;
        private int hitDiceValue = 10;
        private int hitDiceBonus = 21;
        private int damageDiceNum = 2;
        private int damageDiceValue = 8;
        private int damageBonus = 4;
        public string speed = "40 ft.";
        public string size = "Large";
        public string attack = "Greatclub";

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
            damage = 13;
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
            Console.WriteLine("Damage: {0} bludgeoning damage.", damage);
        }
    }
}
