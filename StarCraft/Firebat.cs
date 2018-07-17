using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarCraft
{
    class Firebat
    {
        private int HP = 60;
        private int Speed = 1;

        public void GetDamaged(int enemyAttack)
        {
            HP -= (enemyAttack * 3);
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
    }
}
