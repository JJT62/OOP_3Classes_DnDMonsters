using System;
using System.Collections.Generic;
using System.Text;

namespace DnDMonsters
{
    class Dragon
    {
        public int hp = 178;
        public int ac = 18;
        public int damage = 17;
        public int fireDamage = 3;
        private int toHit = 10;
        public string CR = "10";
        private int hitDiceNum = 17;
        private int hitDiceValue = 10;
        private int hitDiceBonus = 85;
        private int damageDiceNum = 2;
        private int damageDiceValue = 10;
        private int damageBonus = 6;
        private int fireDamageDiceNum = 1;
        private int fireDamageDiceValue = 6;
        public string speed = "40 ft., climb 40 ft., fly 80 ft.";
        public string size = "Large";
        public string attack = "Bite";


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
            n = random.Next(1, (fireDamageDiceValue));
            fireDamage = (fireDamageDiceNum * (n));
        }

        public void resetDefaultDamage()
        {
            damage = 17;
            fireDamage = 3;
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
            Console.WriteLine("Damage: {0} piercing damage plus {1} fire damage.", damage, fireDamage);
        }
    }
}
