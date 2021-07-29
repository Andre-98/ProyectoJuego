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

        private void Ranking_Load(object sender, EventArgs e)
        {
            int P = 1;
            M.ShowDatagrid(dataGridView1);
            this.dataGridView1.Sort(this.dataGridView1.Columns["PuntosTotales"], ListSortDirection.Descending);
            for (int row = 0; row < 10; row++)
            {
                dataGridView1.Rows[row].Cells[0].Value = P;
                P++;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            this.Hide();
            H.Show();
        }
    }
}
