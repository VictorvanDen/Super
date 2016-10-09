using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{

    class Magic : Hero
    {
            public Magic(int hp, int ap, int dmg, int ex, int maxap, bool team, int maxhp, string contr)
            {
                this.hp = hp;
                this.ap = ap;
                this.dmg = dmg;
                this.ex = ex;
                this.maxap = maxap;
                this.team = team;
                this.maxhp = maxhp;
                this.contr = contr;
            }
        }
    }

