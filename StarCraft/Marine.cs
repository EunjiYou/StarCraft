using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarCraft
{
    class Marine
    {
        private int HP = 50;
        private int Speed = 1;

        public void GetDamaged(int enemyAttack)
        {
            HP -= (enemyAttack * 2);
        }

        public int UseSteamPack(int count)
        {
            for (int i = 0; i < count; i++)
            {
                UseSteamPackCore();
            }

            return HP;
        }

        public void UseSteamPackCore()
        {
            HP = HP - 5;
            Speed = Speed + 1;
        }

        public void Heal(int hpToAdd)
        {
            HP += hpToAdd;
        }
    }
}
