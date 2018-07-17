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
            int hp1 = m1.UseSteamPack(2);
            
            Marine m2 = new Marine();
            // m2가 스팀팩 사용
            int hp2 = m2.UseSteamPack(1);

            m1.Heal(30);
            m2.GetDamaged(3);
            
            Firebat f1 = new Firebat();
            f1.UseSteamPack(1);
            f1.GetDamaged(3);

            //f1.UseSteamPackCore(); // 은닉 불가
            //f1.HP -= 100; // 은닉 불가
            //m1.HP -= 100; // 은닉 불가

        }
    }
}
