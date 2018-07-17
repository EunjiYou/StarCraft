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
            m1.HP = m1.HP - 5;
            m1.Speed = m1.Speed + 1;

            Marine m2 = new Marine();

            // m2가 스팀팩 사용
            m2.HP = m2.HP - 5;
            m2.Speed = m2.Speed + 1;

            // m1이 스팀팩 사용
            m1.HP = m1.HP - 5;
            m1.Speed = m1.Speed + 1;
        }
    }
}
