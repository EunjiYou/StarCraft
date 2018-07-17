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
            int hp1 = Marine_UseSteamPack(m1, 2);
            
            Marine m2 = new Marine();
            // m2가 스팀팩 사용
            int hp2 = Marine_UseSteamPack(m2, 1);
            Heal(m1, 30);
            Marine_GetDamaged(m2, 3);

            Firebat f1 = new Firebat();
            Firebat_UseSteamPack(f1, 1);
            Firebat_GetDamaged(f1, 3);
        }

        private static void Firebat_GetDamaged(Firebat f, int enemyAttack)
        {
            f.HP -= (enemyAttack * 3);
        }

        private static void Marine_GetDamaged(Marine m, int enemyAttack)
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

        static int Marine_UseSteamPack(Marine m, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Marine_UseSteamPackCore(m);
            }

            return m.HP;
        }

        static int Firebat_UseSteamPack(Firebat f, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Firebat_UseSteamPackCore(f);
            }

            return f.HP;
        }

        static void Marine_UseSteamPackCore(Marine m)
        {
            m.HP = m.HP - 5;
            m.Speed = m.Speed + 1;
        }
        // Ctrl + D (duplicate)

        static void Firebat_UseSteamPackCore(Firebat f)
        {
            f.HP = f.HP - 5;
            f.Speed = f.Speed + 1;
        }

        static void Heal(Marine m, int hpToAdd)
        {
            //m.HP = m.HP + hpToAdd;
            m.HP += hpToAdd;
        }
    }
}
