namespace Skola
{
    partial class DodajStarateljaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajStarateljaForma));
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.chBClanRodSaveta = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnPrikaziTelefone = new System.Windows.Forms.Button();
            this.listaStaratelja = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDodajTelefon = new System.Windows.Forms.Button();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txbTelefon = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.listaTelefona = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbDodatniPodaci = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.grbDodatniPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(219, 91);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(112, 23);
            this.btnSacuvaj.TabIndex = 31;
            this.btnSacuvaj.Text = "Dodaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ime:";
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(186, 13);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(143, 20);
            this.txbIme.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prezime:";
            // 
            // txbPrezime
            // 
            this.txbPrezime.Location = new System.Drawing.Point(186, 42);
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(143, 20);
            this.txbPrezime.TabIndex = 26;
            // 
            // chBClanRodSaveta
            // 
            this.chBClanRodSaveta.AutoSize = true;
            this.chBClanRodSaveta.Location = new System.Drawing.Point(184, 68);
            this.chBClanRodSaveta.Name = "chBClanRodSaveta";
            this.chBClanRodSaveta.Size = new System.Drawing.Size(145, 17);
            this.chBClanRodSaveta.TabIndex = 32;
            this.chBClanRodSaveta.Text = "Clan Roditeljskog Saveta";
            this.chBClanRodSaveta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisi);
            this.groupBox1.Controls.Add(this.btnIzmeni);
            this.groupBox1.Controls.Add(this.btnPrikaziTelefone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.chBClanRodSaveta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbIme);
            this.groupBox1.Controls.Add(this.txbPrezime);
            this.groupBox1.Location = new System.Drawing.Point(344, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 208);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o staratelju";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(219, 149);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(112, 23);
            this.btnObrisi.TabIndex = 38;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click_1);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(219, 120);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(112, 23);
            this.btnIzmeni.TabIndex = 33;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnPrikaziTelefone
            // 
            this.btnPrikaziTelefone.Location = new System.Drawing.Point(219, 178);
            this.btnPrikaziTelefone.Name = "btnPrikaziTelefone";
            this.btnPrikaziTelefone.Size = new System.Drawing.Size(112, 23);
            this.btnPrikaziTelefone.TabIndex = 37;
            this.btnPrikaziTelefone.Text = "Prikazi Telefone";
            this.btnPrikaziTelefone.UseVisualStyleBackColor = true;
            this.btnPrikaziTelefone.Click += new System.EventHandler(this.btnPrikaziTelefone_Click);
            // 
            // listaStaratelja
            // 
            this.listaStaratelja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listaStaratelja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaStaratelja.FullRowSelect = true;
            this.listaStaratelja.GridLines = true;
            this.listaStaratelja.Location = new System.Drawing.Point(3, 16);
            this.listaStaratelja.Name = "listaStaratelja";
            this.listaStaratelja.Size = new System.Drawing.Size(320, 386);
            this.listaStaratelja.TabIndex = 35;
            this.listaStaratelja.UseCompatibleStateImageBehavior = false;
            this.listaStaratelja.View = System.Windows.Forms.View.Details;
            this.listaStaratelja.SelectedIndexChanged += new System.EventHandler(this.onemoguciDodavanje);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Clan Saveta";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listaStaratelja);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 405);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o Starateljima";
            // 
            // btnDodajTelefon
            // 
            this.btnDodajTelefon.Location = new System.Drawing.Point(235, 58);
            this.btnDodajTelefon.Name = "btnDodajTelefon";
            this.btnDodajTelefon.Size = new System.Drawing.Size(106, 23);
            this.btnDodajTelefon.TabIndex = 34;
            this.btnDodajTelefon.Text = "Dodaj Telefon";
            this.btnDodajTelefon.UseVisualStyleBackColor = true;
            this.btnDodajTelefon.Click += new System.EventHandler(this.btnDodajTelefon_Click);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(183, 35);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 35;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txbTelefon
            // 
            this.txbTelefon.Location = new System.Drawing.Point(235, 32);
            this.txbTelefon.Name = "txbTelefon";
            this.txbTelefon.Size = new System.Drawing.Size(106, 20);
            this.txbTelefon.TabIndex = 36;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.listaTelefona);
            this.groupBox.Location = new System.Drawing.Point(6, 19);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(171, 135);
            this.groupBox.TabIndex = 39;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Brojevi Telefona";
            // 
            // listaTelefona
            // 
            this.listaTelefona.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listaTelefona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaTelefona.FullRowSelect = true;
            this.listaTelefona.GridLines = true;
            this.listaTelefona.Location = new System.Drawing.Point(3, 16);
            this.listaTelefona.Name = "listaTelefona";
            this.listaTelefona.Size = new System.Drawing.Size(165, 116);
            this.listaTelefona.TabIndex = 0;
            this.listaTelefona.UseCompatibleStateImageBehavior = false;
            this.listaTelefona.View = System.Windows.Forms.View.Details;
            this.listaTelefona.SelectedIndexChanged += new System.EventHandler(this.listaTelefona_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Broj Telefona";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // grbDodatniPodaci
            // 
            this.grbDodatniPodaci.Controls.Add(this.button1);
            this.grbDodatniPodaci.Controls.Add(this.txbTelefon);
            this.grbDodatniPodaci.Controls.Add(this.groupBox);
            this.grbDodatniPodaci.Controls.Add(this.lblTelefon);
            this.grbDodatniPodaci.Controls.Add(this.btnDodajTelefon);
            this.grbDodatniPodaci.Location = new System.Drawing.Point(344, 226);
            this.grbDodatniPodaci.Name = "grbDodatniPodaci";
            this.grbDodatniPodaci.Size = new System.Drawing.Size(353, 188);
            this.grbDodatniPodaci.TabIndex = 40;
            this.grbDodatniPodaci.TabStop = false;
            this.grbDodatniPodaci.Text = "Dodatni Podaci";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Obrisi Telefon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajStarateljaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(712, 429);
            this.Controls.Add(this.grbDodatniPodaci);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(728, 468);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(728, 468);
            this.Name = "DodajStarateljaForma";
            this.Text = "DODAVANJE STARATELJA";
            this.Load += new System.EventHandler(this.DodajStarateljaForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.grbDodatniPodaci.ResumeLayout(false);
            this.grbDodatniPodaci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.CheckBox chBClanRodSaveta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaStaratelja;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox txbTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Button btnDodajTelefon;
        private System.Windows.Forms.Button btnPrikaziTelefone;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ListView listaTelefona;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox grbDodatniPodaci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnObrisi;
    }
}