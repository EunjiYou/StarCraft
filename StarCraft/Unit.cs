using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarCraft
{
    abstract class Unit
    {
        protected int HP = 60;
        protected int Speed = 1;

        // getter
        public int GetHP()
        {
            return HP;
        }

        public virtual void GetDamaged(int enemyAttack)
        {
            HP -= enemyAttack;
        }
        
        public int UseSteamPack(int count)
        {
            for (int i = 0; i < count; i++)
            {
                UseSteamPackCore();
            }

            return HP;
        }

        private void UseSteamPackCore()
        {
            HP -= 5;
            Speed += 1;
        }

        public void Heal(int hpToAdd)
        {
            HP += hpToAdd;
        }
    }
}
