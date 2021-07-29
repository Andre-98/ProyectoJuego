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
    public partial class Game : Form
    {
        public string Name;
        public int Modo;
        Functions.Methods M = new Functions.Methods();
        public Game()
        {
            InitializeComponent();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            this.Hide();
            H.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {


        }
    }
}
