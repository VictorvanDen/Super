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
        Hero Magic1 = new Magic(110, 200, 10, 0, 100, true, 110, "ship");
        Hero Plane1 = new Plane(300, 100, 70, 0, 100, true, 300, "tank");
        Hero Tank1 = new Tank(600, 100, 20, 0, 100, true, 600, "Magic");
        Hero Ship1 = new Ship(500, 100, 50, 0, 100, true, 500, "Plane");
        Hero Magic2 = new Magic(110, 200, 10, 0, 100, false, 110, "ship");
        Hero Plane2 = new Plane(300, 100, 70, 0, 100, false, 300, "tank");
        Hero Tank2 = new Tank(600, 100, 20, 0, 100, false, 600, "Magic");
        Hero Ship2 = new Ship(500, 100, 50, 0, 100, false, 500, "Plane");
        public Form1()
        {
            InitializeComponent();
        }

        public void LabelUpdade ()
        {
            label5.Text = Plane1.hp.ToString(); // для команды 1 Самолёт
            label7.Text = Plane1.ap.ToString(); // для команды 1 Самолёт

            label12.Text = Tank1.hp.ToString(); // для команды 1 Танк
            label13.Text = Tank1.ap.ToString(); // для команды 1 Танк

            label14.Text = Magic1.hp.ToString(); // для команды 1 Маг
            label15.Text = Magic1.ap.ToString(); // для команды 1 Маг

            label18.Text = Ship1.hp.ToString(); // для команды 1 Маг
            label19.Text = Ship1.ap.ToString();    // для команды 1 Маг



            label34.Text = Plane2.hp.ToString(); // для команды 2 Самолёт
            label32.Text = Plane2.ap.ToString(); // для команды 2 Самолёт

            label27.Text = Tank2.hp.ToString(); // для команды 2 Танк
            label26.Text = Tank2.ap.ToString(); // для команды 2 Танк

            label25.Text = Magic2.hp.ToString(); // для команды 2 Маг
            label24.Text = Magic2.ap.ToString(); // для команды 2 Маг

            label21.Text = Ship2.hp.ToString(); // для команды 2 Корабль
            label20.Text = Ship2.ap.ToString(); // для команды 2 Корабль

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelUpdade();
        }
    }
}
