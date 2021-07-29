using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

