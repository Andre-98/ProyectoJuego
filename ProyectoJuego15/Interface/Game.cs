﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
//Andreina Alfaro Obando, Joel Steven Valerio Mora

namespace ProyectoJuego15.Interface
{
    public partial class Game : Form
    {
        public string Name, h, m, s;
        public int modo;
        Functions.Methods M = new Functions.Methods();
        Stopwatch SW = new Stopwatch();
        
        public Game()
        {
            InitializeComponent();
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

        public void ModoVerification()
        {
            if (modo == 1)
            {
                SolutionValidationH();
            }
            else
            {
                SolutionValidationV();
            }
        }

        public void SolutionValidationH()
        {
            if (Btn1.Text == "1" && Btn2.Text == "2" && Btn3.Text == "3" &&
                Btn4.Text == "4" && Btn5.Text == "5" && Btn6.Text == "6" &&
                Btn7.Text == "7" && Btn8.Text == "8" && Btn9.Text == "9" &&
                Btn10.Text == "10" && Btn11.Text == "11" && Btn12.Text == "12" &&
                Btn13.Text == "13" && Btn14.Text == "14" && Btn15.Text == "15")
            {
                Btn1.Enabled = false;
                Btn2.Enabled = false;
                Btn3.Enabled = false;
                Btn4.Enabled = false;
                Btn5.Enabled = false;
                Btn6.Enabled = false;
                Btn7.Enabled = false;
                Btn8.Enabled = false;
                Btn9.Enabled = false;
                Btn10.Enabled = false;
                Btn11.Enabled = false;
                Btn12.Enabled = false;
                Btn13.Enabled = false;
                Btn14.Enabled = false;
                Btn15.Enabled = false;
                Btn16.Enabled = false;

                SW.Stop();

                M.Insert1();

                MessageBox.Show("Felicidades, has ganado", "Rompecabezas numérico en orden Izquierda-Derecha",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void SolutionValidationV()
        {
            if (Btn1.Text == "1" && Btn2.Text == "5" && Btn3.Text == "9" &&
                Btn4.Text == "13" && Btn5.Text == "2" && Btn6.Text == "6" &&
                Btn7.Text == "10" && Btn8.Text == "14" && Btn9.Text == "3" &&
                Btn10.Text == "7" && Btn11.Text == "11" && Btn12.Text == "15" &&
                Btn13.Text == "4" && Btn14.Text == "8" && Btn15.Text == "12")
            {
                Btn1.Enabled = false;
                Btn2.Enabled = false;
                Btn3.Enabled = false;
                Btn4.Enabled = false;
                Btn5.Enabled = false;
                Btn6.Enabled = false;
                Btn7.Enabled = false;
                Btn8.Enabled = false;
                Btn9.Enabled = false;
                Btn10.Enabled = false;
                Btn11.Enabled = false;
                Btn12.Enabled = false;
                Btn13.Enabled = false;
                Btn14.Enabled = false;
                Btn15.Enabled = false;
                Btn16.Enabled = false;

                SW.Stop();

                M.Insert1();

                MessageBox.Show("Felicidades, has ganado", "Rompecabezas numérico en orden Arriba-Abajo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AsignarT()
        {
            M.tiempo = h + m + s;
            M.h = h;
            M.m = m;
            M.s = s;
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (modo == 1)
            {
                Btn1.Text = "1";
                Btn2.Text = "2";
                Btn3.Text = "3";
                Btn4.Text = "4";
                Btn5.Text = "5";
                Btn6.Text = "6";
                Btn7.Text = "7";
                Btn8.Text = "8";
                Btn9.Text = "9";
                Btn10.Text = "10";
                Btn11.Text = "11";
                Btn12.Text = "12";
                Btn13.Text = "13";
                Btn14.Text = "14";
                Btn15.Text = "15";
                Btn16.Text = "";

                SW.Stop();
                AsignarT();

                Btn1.Enabled = false;
                Btn2.Enabled = false;
                Btn3.Enabled = false;
                Btn4.Enabled = false;
                Btn5.Enabled = false;
                Btn6.Enabled = false;
                Btn7.Enabled = false;
                Btn8.Enabled = false;
                Btn9.Enabled = false;
                Btn10.Enabled = false;
                Btn11.Enabled = false;
                Btn12.Enabled = false;
                Btn13.Enabled = false;
                Btn14.Enabled = false;
                Btn15.Enabled = false;
                Btn16.Enabled = false;

                MessageBox.Show("Usted ha perdido :'(", "Rompecabezas numérico en orden Izquierda-Derecha",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                M.Rendirse = true;

                M.Insert1();
            }

            else
            {
                Btn1.Text = "1";
                Btn2.Text = "5";
                Btn3.Text = "9";
                Btn4.Text = "13";
                Btn5.Text = "2";
                Btn6.Text = "6";
                Btn7.Text = "10";
                Btn8.Text = "14";
                Btn9.Text = "3";
                Btn10.Text = "7";
                Btn11.Text = "11";
                Btn12.Text = "15";
                Btn13.Text = "4";
                Btn14.Text = "8";
                Btn15.Text = "12";
                Btn16.Text = "";

                Btn1.Enabled = false;
                Btn2.Enabled = false;
                Btn3.Enabled = false;
                Btn4.Enabled = false;
                Btn5.Enabled = false;
                Btn6.Enabled = false;
                Btn7.Enabled = false;
                Btn8.Enabled = false;
                Btn9.Enabled = false;
                Btn10.Enabled = false;
                Btn11.Enabled = false;
                Btn12.Enabled = false;
                Btn13.Enabled = false;
                Btn14.Enabled = false;
                Btn15.Enabled = false;
                Btn16.Enabled = false;

                SW.Stop();
                AsignarT();

                MessageBox.Show("Usted ha perdido :'(", "Rompecabezas numérico en orden Arriba-Abajo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                M.Rendirse = true;

                M.Insert1();

            }
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

        private void Btn1_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn1, Btn2);
            M.EmptySpaceValidation(Btn1, Btn5);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn2, Btn1);
            M.EmptySpaceValidation(Btn2, Btn6);
            M.EmptySpaceValidation(Btn2, Btn3);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn3, Btn2);
            M.EmptySpaceValidation(Btn3, Btn4);
            M.EmptySpaceValidation(Btn3, Btn7);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn4, Btn3);
            M.EmptySpaceValidation(Btn4, Btn8);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;

        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn5, Btn1);
            M.EmptySpaceValidation(Btn5, Btn6);
            M.EmptySpaceValidation(Btn5, Btn9);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;

        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn6, Btn2);
            M.EmptySpaceValidation(Btn6, Btn5);
            M.EmptySpaceValidation(Btn6, Btn7);
            M.EmptySpaceValidation(Btn6, Btn10);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn7, Btn3);
            M.EmptySpaceValidation(Btn7, Btn6);
            M.EmptySpaceValidation(Btn7, Btn8);
            M.EmptySpaceValidation(Btn7, Btn11);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn8, Btn4);
            M.EmptySpaceValidation(Btn8, Btn7);
            M.EmptySpaceValidation(Btn8, Btn12);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn9, Btn5);
            M.EmptySpaceValidation(Btn9, Btn10);
            M.EmptySpaceValidation(Btn9, Btn13);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn10, Btn6);
            M.EmptySpaceValidation(Btn10, Btn9);
            M.EmptySpaceValidation(Btn10, Btn11);
            M.EmptySpaceValidation(Btn10, Btn14);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;

        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn11, Btn7);
            M.EmptySpaceValidation(Btn11, Btn10);
            M.EmptySpaceValidation(Btn11, Btn12);
            M.EmptySpaceValidation(Btn11, Btn15);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;

        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn12, Btn8);
            M.EmptySpaceValidation(Btn12, Btn11);
            M.EmptySpaceValidation(Btn12, Btn16);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;

        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn13, Btn9);
            M.EmptySpaceValidation(Btn13, Btn14);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn14, Btn10);
            M.EmptySpaceValidation(Btn14, Btn13);
            M.EmptySpaceValidation(Btn14, Btn15);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;
        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn15, Btn11);
            M.EmptySpaceValidation(Btn15, Btn14);
            M.EmptySpaceValidation(Btn15, Btn16);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;

        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            SW.Start();
            timer1.Enabled = true;
            AsignarT();
            M.EmptySpaceValidation(Btn16, Btn12);
            M.EmptySpaceValidation(Btn16, Btn15);
            LblMV.Text = M.validos.ToString();
            LblMI.Text = M.invalidos.ToString();
            ModoVerification();
            M.I = 0;
            M.Paso = false;
            M.Paso2 = false;
            M.Paso3 = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)SW.ElapsedMilliseconds);
            h = ts.Hours.ToString().Length < 2 ? "0" + ts.Hours.ToString() : ts.Hours.ToString();
            m = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            s = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            LblTime.Text = "Tiempo: " + h + ":" + m + ":" + s;
        }
    }
}
