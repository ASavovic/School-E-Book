namespace Skola
{
    partial class UceniciForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UceniciForma));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaUcenika = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.obrisiUcenika = new System.Windows.Forms.Button();
            this.btnIzmeniUcenika = new System.Windows.Forms.Button();
            this.btnUnesiPodatkeNovogUcenika = new System.Windows.Forms.Button();
            this.btnPrikaziOceneUcenika = new System.Windows.Forms.Button();
            this.btnDodajStaratelja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Podaci prikazani u tabeli su\r\nosnovni podaci ucenika skole.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaUcenika);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 423);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Ucenika";
            // 
            // listaUcenika
            // 
            this.listaUcenika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader1});
            this.listaUcenika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaUcenika.FullRowSelect = true;
            this.listaUcenika.GridLines = true;
            this.listaUcenika.Location = new System.Drawing.Point(3, 16);
            this.listaUcenika.MultiSelect = false;
            this.listaUcenika.Name = "listaUcenika";
            this.listaUcenika.Size = new System.Drawing.Size(517, 404);
            this.listaUcenika.TabIndex = 4;
            this.listaUcenika.UseCompatibleStateImageBehavior = false;
            this.listaUcenika.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            this.columnHeader7.Width = 41;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ime";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 86;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Prezime";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 111;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Razred";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 103;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Adresa";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 121;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "SmerUcenika";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 149;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DatumUpisa";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 160;
            // 
            // obrisiUcenika
            // 
            this.obrisiUcenika.Location = new System.Drawing.Point(552, 114);
            this.obrisiUcenika.Name = "obrisiUcenika";
            this.obrisiUcenika.Size = new System.Drawing.Size(151, 37);
            this.obrisiUcenika.TabIndex = 11;
            this.obrisiUcenika.Text = "Obrisi Ucenika";
            this.obrisiUcenika.UseVisualStyleBackColor = true;
            this.obrisiUcenika.Click += new System.EventHandler(this.ObrisiUcenika_Click);
            // 
            // btnIzmeniUcenika
            // 
            this.btnIzmeniUcenika.Location = new System.Drawing.Point(552, 72);
            this.btnIzmeniUcenika.Name = "btnIzmeniUcenika";
            this.btnIzmeniUcenika.Size = new System.Drawing.Size(151, 36);
            this.btnIzmeniUcenika.TabIndex = 10;
            this.btnIzmeniUcenika.Text = "Izmeni Ucenika";
            this.btnIzmeniUcenika.UseVisualStyleBackColor = true;
            this.btnIzmeniUcenika.Click += new System.EventHandler(this.BtnIzmeniUcenika_Click);
            // 
            // btnUnesiPodatkeNovogUcenika
            // 
            this.btnUnesiPodatkeNovogUcenika.Location = new System.Drawing.Point(552, 28);
            this.btnUnesiPodatkeNovogUcenika.Name = "btnUnesiPodatkeNovogUcenika";
            this.btnUnesiPodatkeNovogUcenika.Size = new System.Drawing.Size(151, 38);
            this.btnUnesiPodatkeNovogUcenika.TabIndex = 9;
            this.btnUnesiPodatkeNovogUcenika.Text = "Dodaj Ucenika";
            this.btnUnesiPodatkeNovogUcenika.UseVisualStyleBackColor = true;
            this.btnUnesiPodatkeNovogUcenika.Click += new System.EventHandler(this.BtnUnesiPodatkeNovogUcenika_Click);
            // 
            // btnPrikaziOceneUcenika
            // 
            this.btnPrikaziOceneUcenika.Location = new System.Drawing.Point(553, 157);
            this.btnPrikaziOceneUcenika.Name = "btnPrikaziOceneUcenika";
            this.btnPrikaziOceneUcenika.Size = new System.Drawing.Size(150, 37);
            this.btnPrikaziOceneUcenika.TabIndex = 14;
            this.btnPrikaziOceneUcenika.Text = "Prikazi Ocene Ucenika";
            this.btnPrikaziOceneUcenika.UseVisualStyleBackColor = true;
            this.btnPrikaziOceneUcenika.Click += new System.EventHandler(this.BtnPrikaziOceneUcenika_Click);
            // 
            // btnDodajStaratelja
            // 
            this.btnDodajStaratelja.Location = new System.Drawing.Point(553, 200);
            this.btnDodajStaratelja.Name = "btnDodajStaratelja";
            this.btnDodajStaratelja.Size = new System.Drawing.Size(150, 37);
            this.btnDodajStaratelja.TabIndex = 15;
            this.btnDodajStaratelja.Text = "Prikazi Staratelje Uceniku";
            this.btnDodajStaratelja.UseVisualStyleBackColor = true;
            this.btnDodajStaratelja.Click += new System.EventHandler(this.BtnDodajStaratelja_Click);
            // 
            // UceniciForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(749, 446);
            this.Controls.Add(this.btnDodajStaratelja);
            this.Controls.Add(this.btnPrikaziOceneUcenika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.obrisiUcenika);
            this.Controls.Add(this.btnIzmeniUcenika);
            this.Controls.Add(this.btnUnesiPodatkeNovogUcenika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(765, 485);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(765, 485);
            this.Name = "UceniciForma";
            this.Text = "UCENICI";
            this.Load += new System.EventHandler(this.UceniciForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaUcenika;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button obrisiUcenika;
        private System.Windows.Forms.Button btnIzmeniUcenika;
        private System.Windows.Forms.Button btnUnesiPodatkeNovogUcenika;
        private System.Windows.Forms.Button btnPrikaziOceneUcenika;
        private System.Windows.Forms.Button btnDodajStaratelja;
    }
}