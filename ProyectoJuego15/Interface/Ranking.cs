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

namespace ProyectoJuego15.Interface
{
    public partial class Ranking : Form
    {
        Functions.Methods M = new Functions.Methods();
        public Ranking()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            this.Hide();
            H.Show();
        }
    }
}
