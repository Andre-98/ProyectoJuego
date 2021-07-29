using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Andreina Alfaro Obando, Joel Steven Valerio Mora

namespace ProyectoJuego15.Functions
{
    class Methods
    {
        public string B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, B11, B12, B13, B14, B15, B16, nombre, tiempo, h, m, s;
        public int validos, invalidos, acumulados, ptsTotales;
        public int I = 0;
        public bool Paso, Paso2, Paso3, Rendirse;
        public static string[,] rankingmatrix = new string[10, 7];

        public void Insert1()
        {
            //RPoints();

            for (int row = 0; row < 10; row++)
            {
                if (rankingmatrix[row, 1] == null)
                {
                    if (Rendirse == true)
                    {
                        rankingmatrix[row, 1] = nombre + " (Se rindió)";
                    }
                    else
                    {
                        rankingmatrix[row, 1] = nombre;
                    }
                    rankingmatrix[row, 2] = h + ":" + m + ":" + s;
                    rankingmatrix[row, 3] = validos.ToString();
                    rankingmatrix[row, 4] = invalidos.ToString();
                    rankingmatrix[row, 5] = acumulados.ToString();
                    if (Rendirse == true)
                    {
                        ptsTotales = 0;
                        rankingmatrix[row, 6] = ptsTotales.ToString();

                    }
                    else
                    {
                        rankingmatrix[row, 6] = ptsTotales.ToString();
                    }

                    break;
                }
            }
        }

        public void EmptySpaceValidation(Button btn1, Button btn2)
        {
            if (btn2.Text == "")
            {
                btn2.Text = btn1.Text;
                btn1.Text = "";
                validos = validos + 1;
                Paso = true;
            }
            else
            {
                I++;
            }
            if (I == 1 && Paso2 == false && Paso == false)
            {
                invalidos = invalidos + 1;
                Paso2 = true;

            }
            if (Paso == true && Paso2 == true && Paso3 == false)
            {
                invalidos = invalidos - 1;
                Paso3 = true;
            }

            acumulados = validos + invalidos;
        }

        public void Juego()
        {
            int[] Numeros = new int[16];
            int i, j, check;
            Boolean Repetido = false;

            i = 1;
            do
            {
                Random N = new Random();
                check = N.Next(0, 15) + 1;


                for (j = 1; j <= i; j++)
                {
                    if (Numeros[j] == check)
                    {
                        Repetido = true;
                        break;

                    }

                }
                if (Repetido == true)
                {
                    Repetido = false;

                }
                else
                {
                    Numeros[i] = check;
                    i++;

                }
            }
            while (i <= 15);

            B1 = Convert.ToString(Numeros[1]);
            B2 = Convert.ToString(Numeros[2]);
            B3 = Convert.ToString(Numeros[3]);
            B4 = Convert.ToString(Numeros[4]);
            B5 = Convert.ToString(Numeros[5]);
            B6 = Convert.ToString(Numeros[6]);
            B7 = Convert.ToString(Numeros[7]);
            B8 = Convert.ToString(Numeros[8]);
            B9 = Convert.ToString(Numeros[9]);
            B10 = Convert.ToString(Numeros[10]);
            B11 = Convert.ToString(Numeros[11]);
            B12 = Convert.ToString(Numeros[12]);
            B13 = Convert.ToString(Numeros[13]);
            B14 = Convert.ToString(Numeros[14]);
            B15 = Convert.ToString(Numeros[15]);
            B16 = "";
        }
    }
}

