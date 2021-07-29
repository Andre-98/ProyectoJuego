﻿
namespace ProyectoJuego15.Interface
{
    partial class Ranking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranking));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invalidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntosTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posicion,
            this.Jugador,
            this.Tiempo,
            this.Validos,
            this.Invalidos,
            this.PuntosTotales});
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            // 
            // Jugador
            // 
            this.Jugador.HeaderText = "Jugador";
            this.Jugador.Name = "Jugador";
            this.Jugador.ReadOnly = true;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.ReadOnly = true;
            // 
            // Validos
            // 
            this.Validos.HeaderText = "Validos";
            this.Validos.Name = "Validos";
            this.Validos.ReadOnly = true;
            // 
            // Invalidos
            // 
            this.Invalidos.HeaderText = "Invalidos";
            this.Invalidos.Name = "Invalidos";
            this.Invalidos.ReadOnly = true;
            // 
            // PuntosTotales
            // 
            this.PuntosTotales.HeaderText = "PuntosTotales";
            this.PuntosTotales.Name = "PuntosTotales";
            this.PuntosTotales.ReadOnly = true;
            // 
            // BtnBack
            // 
            this.BtnBack.AutoSize = true;
            this.BtnBack.BackColor = System.Drawing.Color.Green;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.BtnBack.Location = new System.Drawing.Point(259, 339);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(164, 55);
            this.BtnBack.TabIndex = 12;
            this.BtnBack.Text = "Atrás";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoJuego15.Properties.Resources.Fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 406);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ranking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.Ranking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invalidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosTotales;
    }
}