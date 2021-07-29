using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Andreina Alfaro Obando, Joel Steven Valerio Mora

namespace ProyectoJuego15
{
    public partial class Home : Form
    {
        Interface.Game G = new Interface.Game();
        Interface.Ranking R = new Interface.Ranking();

        public Home()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            G.Name=TxtName.Text;
            TxtName.Clear();

        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            G.modo = 1;
            this.Hide();
            G.Show();
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            G.modo = 2;
            this.Hide();
            G.Show();
        }

        private void BtnRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            R.Show();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
