using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form1 : Form
    {
        int attacktype;
        Hero agressor;
        int stage = 0;
        Hero Magic1 = new Magic(110, 110, 200, 200, 10, 0, true, "Ship");
        Hero Plane1 = new Plane(300, 300, 100, 100, 70, 0, true, "Tank");
        Hero Tank1 = new Tank(800, 800, 100, 100, 20, 0, true, "Magic");
        Hero Ship1 = new Ship(500, 500, 150, 150, 50, 0, true, "Plane");
        Hero Magic2 = new Magic(110, 110, 200, 200, 10, 0, false, "Ship");
        Hero Plane2 = new Plane(300, 300, 100, 100, 70, 0, false, "Tank");
        Hero Tank2 = new Tank(800, 800, 100, 100, 20, 0, false, "Magic");
        Hero Ship2 = new Ship(500, 500, 150, 150, 50, 0, false, "Plane");
        public Form1()
        {
            InitializeComponent();
        }
        public void DeathCheck()
        {
            if (Plane1.Hp == 0)
            {
                this.Controls.Remove(Attack1);
                Attack1.Dispose();
               
            }

            if (Plane2.Hp == 0)
            {
                this.Controls.Remove(button4);
                button4.Dispose();
                pictureBox5.Visible = true;
                Plane1.Target = Tank2;
            }
            if (Tank1.Hp == 0)
            {
                this.Controls.Remove(Attack2);
                Attack2.Dispose();
            }
            if (Magic1.Hp == 0)
            {
                this.Controls.Remove(Attack3);
                Attack3.Dispose();
            }
            if (Ship1.Hp == 0)
            {
                this.Controls.Remove(Attack4);
                Attack4.Dispose();
            }
            if (Tank2.Hp == 0)
            {
                this.Controls.Remove(button3);
                button3.Dispose();
                pictureBox6.Visible = true;
                Plane1.Target = Magic2;
            }
            if (Magic2.Hp == 0)
            {
                this.Controls.Remove(button2);
                button2.Dispose();
                pictureBox7.Visible = true;
                Plane1.Target = Ship2;
            }
            if (Ship2.Hp == 0)
            {
                this.Controls.Remove(button1);
                button1.Dispose();
                pictureBox8.Visible = true;
            }
        }
        public void ProgressBarUpdate()
        {
            progressBar1.BackColor = Color.Aqua;
            progressBar1.Value = Plane1.Hp;
            progressBar2.Value = Plane1.Ap;
            progressBar3.Value = Tank1.Hp;
            progressBar4.Value = Tank1.Ap;
            progressBar5.Value = Magic1.Hp;
            progressBar6.Value = Magic1.Ap;
            progressBar7.Value = Ship1.Hp;
            progressBar8.Value = Ship1.Ap;

            progressBar9.BackColor = Color.Aqua;
            progressBar9.Value = Plane2.Hp;
            progressBar10.Value = Plane2.Ap;
            progressBar11.Value = Tank2.Hp;
            progressBar12.Value = Tank2.Ap;
            progressBar13.Value = Magic2.Hp;
            progressBar14.Value = Magic2.Ap;
            progressBar15.Value = Ship2.Hp;
            progressBar16.Value = Ship2.Ap;

        }
        public void LabelUpdade ()
        {
            label39.Text = Plane1.Ex.ToString();
            label5.Text = Plane1.Hp.ToString(); // для команды 1 Самолёт
            label7.Text = Plane1.Ap.ToString(); // для команды 1 Самолёт

            label39.Text = Plane1.Ex.ToString();
            label12.Text = Tank1.Hp.ToString(); // для команды 1 Танк
            label13.Text = Tank1.Ap.ToString(); // для команды 1 Танк

            label39.Text = Plane1.Ex.ToString();
            label14.Text = Magic1.Hp.ToString(); // для команды 1 Маг
            label15.Text = Magic1.Ap.ToString(); // для команды 1 Маг

            label39.Text = Plane1.Ex.ToString();
            label18.Text = Ship1.Hp.ToString(); // для команды 1 Маг
            label19.Text = Ship1.Ap.ToString();    // для команды 1 Маг


            
            label34.Text = Plane2.Hp.ToString(); // для команды 2 Самолёт
            label32.Text = Plane2.Ap.ToString(); // для команды 2 Самолёт

            label27.Text = Tank2.Hp.ToString(); // для команды 2 Танк
            label26.Text = Tank2.Ap.ToString(); // для команды 2 Танк

            label25.Text = Magic2.Hp.ToString(); // для команды 2 Маг
            label24.Text = Magic2.Ap.ToString(); // для команды 2 Маг

            label21.Text = Ship2.Hp.ToString(); // для команды 2 Корабль
            label20.Text = Ship2.Ap.ToString(); // для команды 2 Корабль
            ProgressBarUpdate();
            DeathCheck();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelUpdade();
            ProgressBarUpdate();
            Stage0();
        }

        private void Attack1_Click(object sender, EventArgs e)
        {
            //Plane1.Target = Plane1.Target;
            //if (Plane1.Target.Hp == 1)
            //{
            //    Plane1.Ex += 10;
            //}
            //Plane1.Ex = Plane1.Ex + 1;
            //Plane1.Attack();
            //if (Plane1.Target.Hp == 0)
            //{
            //    Plane1.Hp = Plane1.Hp + 10;
            //}
            attacktype = 0;
            agressor = Plane1;
            LabelUpdade();
            Stage1();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (attacktype == 12)
            {
                agressor.Target = Plane2;
                agressor.Skill1();
                Stage2();
            }
            else if(attacktype == 0)
            {
                agressor.Target = Plane2;
                agressor.Attack();
                Stage2();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (attacktype == 0)
            {
                agressor.Target = Tank2;
                agressor.Attack();
                Stage2();
            }
            else if (attacktype == 12)
            {
                agressor.Target = Tank2;
                agressor.Skill1();
                Stage2();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (attacktype == 0)
            {
                agressor.Target = Magic2;
                agressor.Attack();
                Stage2();
            }
            else if (attacktype == 12)
            {
                agressor.Target = Magic2;
                agressor.Skill1();
                Stage2();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (attacktype == 0)
            {
                agressor.Target = Ship2;
                agressor.Attack();
                Stage2();
            }
        }

        private void progressBar6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Attack2_Click(object sender, EventArgs e)
        {
            //Tank1.Target = Plane1.Target;
            //if (Tank1.Target.Hp == 1)
            //{
            //    Tank1.Ex += 10;
            //}
            //Tank1.Ex = Tank1.Ex + 1;
            //Plane1.Attack();
            attacktype = 0;
            agressor = Tank1;
            LabelUpdade();
            Stage1();
        }

        private void Attack3_Click(object sender, EventArgs e)
        {
            //Magic2.Target = Plane1.Target;
            //if (Plane1.Target.Hp == 1)
            //{
            //    Plane1.Ex += 10;
            //}
            //Magic2.Ex = Magic2.Ex + 1;
            //Magic2.Attack();
            //if (Plane1.Target.Hp == 0)
            //{
            //    Plane1.Hp = Plane1.Hp + 10;
            //}
            attacktype = 0;
            agressor = Magic1;
            LabelUpdade();
            Stage1();
        }

        private void Attack4_Click(object sender, EventArgs e)
        {
            //Ship1.Target = Plane1.Target;
            //if (Plane1.Target.Hp == 1)
            //{
            //    Plane1.Ex += 10;
            //}
            //Ship1.Ex = Ship1.Ex + 1;
            //Ship1.Attack();
            //if (Plane1.Target.Hp == 0)
            //{
            //    Plane1.Hp = Plane1.Hp + 10;
            //}
            attacktype = 0;
            agressor = Ship1;
            LabelUpdade();
            Stage1();
        }

        private void Plane_Click(object sender, EventArgs e)
        {
            //    Plane2.Target = Plane1;
            Plane1.Hp = Plane1.Hp - agressor.Dmg;
            Stage0();
        }

        private void Tank_Click(object sender, EventArgs e)
        {
            //  Plane2.Target = Tank1;
            Tank1.Hp = Tank1.Hp - agressor.Dmg;
            Stage0();
        }

        private void Magic_Click(object sender, EventArgs e)
        {
            //Plane2.Target = Magic1;
            Magic1.Hp = Magic1.Hp - agressor.Dmg;
            Stage0();
        }

        private void Ship_Click(object sender, EventArgs e)
        {
            // Plane2.Target = Ship1;
            Ship1.Hp = Ship1.Hp - agressor.Dmg;
            Stage0();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Plane2.Target = Plane2.Target;

            //Plane2.Ex = Plane2.Ex + 1;
            //Plane2.Attack();
            //if (Plane1.Target.Hp == 0)
            //{
            //    Plane1.Hp = Plane1.Hp + 10;
            //}
            attacktype = 0;
            agressor = Plane2;
            LabelUpdade();
            Stage3();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Tank2.Target = Plane2.Target;

            //Tank2.Ex = Tank2.Ex + 1;
            //Tank2.Attack();
            attacktype = 0;
            agressor = Tank2;
            LabelUpdade();
            Stage3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Magic2.Target = Plane2.Target;
            //if (Plane1.Target.Hp == 1)
            //{
            //    Plane1.Ex += 10;
            //}
            //Magic2.Ex = Magic2.Ex + 1;
            //Magic2.Attack();
            //if (Plane1.Target.Hp == 0)
            //{
            //    Plane1.Hp = Plane1.Hp + 10;
            //}
            attacktype = 0;
            agressor = Magic2;
            LabelUpdade();
            Stage3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ship2.Target = Plane2.Target;
            //if (Plane1.Target.Hp == 1)
            //{
            //    Plane1.Ex += 10;
            //}
            //Ship2.Ex = Ship2.Ex + 1;
            //Ship2.Attack();
            //if (Plane1.Target.Hp == 0)
            //{
            //    Plane1.Hp = Plane1.Hp + 10;
            //}
            attacktype = 0;
            agressor = Ship2;
            LabelUpdade();
            Stage3();
        }
        public void Stage0()
        {

            panel2.Enabled = false;
            Plane.Enabled = false;
            Tank.Enabled = false;
            Magic.Enabled = false;
            Ship.Enabled = false;
            stage = 0;

            Attack1.Enabled = true;
            Attack2.Enabled = true;
            Attack3.Enabled = true;
            Attack4.Enabled = true;

            label49.Text = "1";
            label47.Text = "Выбирите атакуещего";

        }
        public void Stage1()
        {
            panel2.Enabled = true;
            panel1.Enabled = false;
            panel2.Visible = true;
            stage = 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            label49.Text = "1";
            label47.Text = "Выбирите цель";
            LabelUpdade();
        }
        public void Stage2()
        {
            LabelUpdade();
            panel2.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;

            panel1.Enabled = false;

            label49.Text = "2";
            label47.Text = "Выбирите атакуещего";
        }
        public void Stage3()
        {
            LabelUpdade();
            panel2.Enabled = false;
            panel1.Enabled = true;

            Plane.Enabled = true;
            Tank.Enabled = true;
            Magic.Enabled = true;
            Ship.Enabled = true;


            Attack1.Enabled = false;
            Attack2.Enabled = false;
            Attack3.Enabled = false;
            Attack4.Enabled = false;
            label49.Text = "2";
            label47.Text = "Выбирите цель";
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SkillAttack1_Click(object sender, EventArgs e)
        {
            attacktype = 12;
            agressor = Plane1;
            LabelUpdade();
            Stage1();
        }
    }
}
