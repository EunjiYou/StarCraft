using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarCraft
{
    class Marine : Unit
    {
        public override void GetDamaged(int enemyAttack)
        {
            HP -= (enemyAttack * 2);
        }
    }
}
