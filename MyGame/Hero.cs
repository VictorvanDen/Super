﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public abstract class Hero
    {
        private int hp;
        public int Hp
        {
            get
            {
                return hp;
            }

            set
            {

                if (value < 0)
                {
                    hp = 0;
                }
                else if (value > Maxhp)
                {
                    hp = Maxhp;
                }
                else
                {
                    hp = value;
                }
            }
        }
        private int maxhp;
        public int Maxhp
        {
            get
            {
                return maxhp;
            }

            set
            {
                maxhp = value;
            }
        }

        public int Maxap
        {
            get
            {
                return maxap;
            }

            set
            {
                maxap = value;
            }
        }

        public int Ex
        {
            get
            {
                return ex;
            }

            set
            {
                ex = value;
            }
        }

        public int Ap
        {
            get
            {
                return ap;
            }

            set
            {
                ap = value;
            }
        }

        public int Dmg
        {
            get
            {
                return dmg;
            }

            set
            {
                dmg = value;
            }
        }

        public string Contr
        {
            get
            {
                return contr;
            }

            set
            {
                contr = value;
            }
        }

        public Hero Target
        {
            get
            {
                return target;
            }

            set
            {
                target = value;
            }
        }

        public bool Team
        {
            get
            {
                return team;
            }

            set
            {
                team = value;
            }
        }

        private int maxap;
        private int ex;
        private int ap;
        private int dmg;
        private bool team;
        private Hero target;
        private string contr;

        public abstract void Skill1();

        public void Attack()
        {
            Target.Hp = Target.Hp - this.Dmg;
        }

    }
}
