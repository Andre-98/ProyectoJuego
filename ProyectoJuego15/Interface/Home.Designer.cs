
namespace ProyectoJuego15
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.BtnInsert = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnH = new System.Windows.Forms.Button();
            this.BtnV = new System.Windows.Forms.Button();
            this.BtnRanking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.Location = new System.Drawing.Point(166, 62);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(156, 41);
            this.BtnInsert.TabIndex = 0;
            this.BtnInsert.Text = "Insertar";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(123, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(239, 35);
            this.TxtName.TabIndex = 1;
            // 
            // BtnH
            // 
            this.BtnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnH.Location = new System.Drawing.Point(27, 174);
            this.BtnH.Name = "BtnH";
            this.BtnH.Size = new System.Drawing.Size(197, 41);
            this.BtnH.TabIndex = 0;
            this.BtnH.Text = "Izquierda-Derecha";
            this.BtnH.UseVisualStyleBackColor = true;
            this.BtnH.Click += new System.EventHandler(this.BtnH_Click);
            // 
            // BtnV
            // 
            this.BtnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnV.Location = new System.Drawing.Point(257, 174);
            this.BtnV.Name = "BtnV";
            this.BtnV.Size = new System.Drawing.Size(197, 41);
            this.BtnV.TabIndex = 0;
            this.BtnV.Text = "Arriba-Abajo";
            this.BtnV.UseVisualStyleBackColor = true;
            this.BtnV.Click += new System.EventHandler(this.BtnV_Click);
            // 
            // BtnRanking
            // 
            this.BtnRanking.AutoSize = true;
            this.BtnRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRanking.Location = new System.Drawing.Point(123, 247);
            this.BtnRanking.Name = "BtnRanking";
            this.BtnRanking.Size = new System.Drawing.Size(229, 41);
            this.BtnRanking.TabIndex = 0;
            this.BtnRanking.Text = "Ver Ranking";
            this.BtnRanking.UseVisualStyleBackColor = true;
            this.BtnRanking.Click += new System.EventHandler(this.BtnRanking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modos de Juego";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ProyectoJuego15.Properties.Resources.Fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnRanking);
            this.Controls.Add(this.BtnV);
            this.Controls.Add(this.BtnH);
            this.Controls.Add(this.BtnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnH;
        private System.Windows.Forms.Button BtnV;
        private System.Windows.Forms.Button BtnRanking;
        private System.Windows.Forms.Label label1;
    }
}

