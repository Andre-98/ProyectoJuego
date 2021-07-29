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

        private void Game_Load(object sender, EventArgs e)
        {
            LblName.Text = "Jugador: " + Name;
            M.nombre = Name;
            M.Juego();

            Btn1.Text = M.B1;
            Btn2.Text = M.B2;
            Btn3.Text = M.B3;
            Btn4.Text = M.B4;
            Btn5.Text = M.B5;
            Btn6.Text = M.B6;
            Btn7.Text = M.B7;
            Btn8.Text = M.B8;
            Btn9.Text = M.B9;
            Btn10.Text = M.B10;
            Btn11.Text = M.B11;
            Btn12.Text = M.B12;
            Btn13.Text = M.B13;
            Btn14.Text = M.B14;
            Btn15.Text = M.B15;
            Btn16.Text = M.B16;
        }
    }
}
