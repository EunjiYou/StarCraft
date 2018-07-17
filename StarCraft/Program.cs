using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            Marine m1 = new Marine();

            // m1이 스팀팩 사용
            int hp1 = UseSteamPack(m1, 2);
            
            Marine m2 = new Marine();

            // m2가 스팀팩 사용
            int hp2 = UseSteamPack(m2, 1);

            Heal(m1, 30);

            GetDamaged(m2, 3);
        }

        private static void GetDamaged(Marine m, int enemyAttack)
        {
            m.HP -= (enemyAttack * 2);
        }

        //static int UseSteamPack(Marine m, int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        m.HP = m.HP - 5;
        //        m.Speed = m.Speed + 1;
        //    }

        //    return m.HP;
        //}

        static int UseSteamPack(Marine m, int count)
        {
            for (int i = 0; i < count; i++)
            {
                UseSteamPackCore(m);
            }

            return m.HP;
        }

        static void UseSteamPackCore(Marine m)
        {
            m.HP = m.HP - 5;
            m.Speed = m.Speed + 1;
        }

        static void Heal(Marine m, int hpToAdd)
        {
            //m.HP = m.HP + hpToAdd;
            m.HP += hpToAdd;
        }
    }
}
