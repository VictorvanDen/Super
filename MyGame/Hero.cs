using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Hero
    {
        public int hp;
        public int maxhp;
        public int maxap;
        public int ex;
        public int ap;
        public int dmg;
        public bool team;
        public Hero target;
        public string contr;
        public void Attack()
        {
            target.hp = target.hp - this.dmg;
        }

    }
}
