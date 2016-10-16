using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Ship : Hero
    {
        public Ship(int maxhp, int hp, int maxap, int ap, int dmg, int ex, bool team, string contr)
        {
            this.Maxhp = maxhp;
            this.Hp = hp;
            this.Maxap = maxap;
            this.Ap = ap;
            this.Dmg = dmg;
            this.Ex = ex;
            this.Maxap = maxap;
            this.Team = team;
            this.Maxhp = maxhp;
            this.Contr = contr;
        }
    }
}
