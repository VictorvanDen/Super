using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Tank : Hero
    {

        public override void Skill1()
        {
            if(this.Ap <= 20)
                {
                Target.Hp = Target.Hp - this.Dmg - 140;
                this.Ap -= 20;
            }
        }

        public Tank(int maxhp, int hp, int maxap, int ap, int dmg, int ex,  bool team,  string contr)
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
