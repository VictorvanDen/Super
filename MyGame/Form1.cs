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


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
