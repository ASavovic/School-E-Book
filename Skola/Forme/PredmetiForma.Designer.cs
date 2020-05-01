namespace Skola
{
    partial class PredmetiForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredmetiForma));
            this.listaOcena = new System.Windows.Forms.GroupBox();
            this.listaPredmeta = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiPredmet = new System.Windows.Forms.Button();
            this.btnIzmeniPredmet = new System.Windows.Forms.Button();
            this.btnDodajPremet = new System.Windows.Forms.Button();
            this.btnAngazman = new System.Windows.Forms.Button();
            this.grbAngazman = new System.Windows.Forms.GroupBox();
            this.chbDatumDo = new System.Windows.Forms.CheckBox();
            this.btnAngazujNastavnika = new System.Windows.Forms.Button();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.datumOd = new System.Windows.Forms.DateTimePicker();
            this.listaNastavnika = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaOcena.SuspendLayout();
            this.grbAngazman.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaOcena
            // 
            this.listaOcena.Controls.Add(this.listaPredmeta);
            this.listaOcena.Location = new System.Drawing.Point(12, 9);
            this.listaOcena.Name = "listaOcena";
            this.listaOcena.Size = new System.Drawing.Size(412, 420);
            this.listaOcena.TabIndex = 24;
            this.listaOcena.TabStop = false;
            this.listaOcena.Text = "Lista Predmeta";
            // 
            // listaPredmeta
            // 
            this.listaPredmeta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2});
            this.listaPredmeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaPredmeta.FullRowSelect = true;
            this.listaPredmeta.GridLines = true;
            this.listaPredmeta.Location = new System.Drawing.Point(3, 16);
            this.listaPredmeta.MultiSelect = false;
            this.listaPredmeta.Name = "listaPredmeta";
            this.listaPredmeta.Size = new System.Drawing.Size(406, 401);
            this.listaPredmeta.TabIndex = 4;
            this.listaPredmeta.UseCompatibleStateImageBehavior = false;
            this.listaPredmeta.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            this.columnHeader7.Width = 41;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Naziv";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 119;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Godina";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Smer";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Podaci prikazani u tabeli su\r\nosnovni podaci o predmetima.";
            // 
            // btnObrisiPredmet
            // 
            this.btnObrisiPredmet.Location = new System.Drawing.Point(431, 114);
            this.btnObrisiPredmet.Name = "btnObrisiPredmet";
            this.btnObrisiPredmet.Size = new System.Drawing.Size(231, 37);
            this.btnObrisiPredmet.TabIndex = 27;
            this.btnObrisiPredmet.Text = "Obrisi Predmet";
            this.btnObrisiPredmet.UseVisualStyleBackColor = true;
            this.btnObrisiPredmet.Click += new System.EventHandler(this.BtnObrisiPredmet_Click);
            // 
            // btnIzmeniPredmet
            // 
            this.btnIzmeniPredmet.Location = new System.Drawing.Point(431, 72);
            this.btnIzmeniPredmet.Name = "btnIzmeniPredmet";
            this.btnIzmeniPredmet.Size = new System.Drawing.Size(231, 36);
            this.btnIzmeniPredmet.TabIndex = 26;
            this.btnIzmeniPredmet.Text = "Izmeni Predmet";
            this.btnIzmeniPredmet.UseVisualStyleBackColor = true;
            this.btnIzmeniPredmet.Click += new System.EventHandler(this.BtnIzmeniPredmet_Click);
            // 
            // btnDodajPremet
            // 
            this.btnDodajPremet.Location = new System.Drawing.Point(431, 25);
            this.btnDodajPremet.Name = "btnDodajPremet";
            this.btnDodajPremet.Size = new System.Drawing.Size(231, 38);
            this.btnDodajPremet.TabIndex = 25;
            this.btnDodajPremet.Text = "Dodaj Predmet";
            this.btnDodajPremet.UseVisualStyleBackColor = true;
            this.btnDodajPremet.Click += new System.EventHandler(this.BtnDodajPremet_Click);
            // 
            // btnAngazman
            // 
            this.btnAngazman.Location = new System.Drawing.Point(431, 157);
            this.btnAngazman.Name = "btnAngazman";
            this.btnAngazman.Size = new System.Drawing.Size(231, 38);
            this.btnAngazman.TabIndex = 29;
            this.btnAngazman.Text = "Angazuj Nastavnika";
            this.btnAngazman.UseVisualStyleBackColor = true;
            this.btnAngazman.Click += new System.EventHandler(this.btnAngazman_Click);
            // 
            // grbAngazman
            // 
            this.grbAngazman.Controls.Add(this.chbDatumDo);
            this.grbAngazman.Controls.Add(this.btnAngazujNastavnika);
            this.grbAngazman.Controls.Add(this.datumDo);
            this.grbAngazman.Controls.Add(this.datumOd);
            this.grbAngazman.Controls.Add(this.listaNastavnika);
            this.grbAngazman.Controls.Add(this.label4);
            this.grbAngazman.Controls.Add(this.label3);
            this.grbAngazman.Controls.Add(this.label2);
            this.grbAngazman.Enabled = false;
            this.grbAngazman.Location = new System.Drawing.Point(431, 210);
            this.grbAngazman.Name = "grbAngazman";
            this.grbAngazman.Size = new System.Drawing.Size(231, 181);
            this.grbAngazman.TabIndex = 30;
            this.grbAngazman.TabStop = false;
            this.grbAngazman.Text = "Angazman";
            // 
            // chbDatumDo
            // 
            this.chbDatumDo.AutoSize = true;
            this.chbDatumDo.Checked = true;
            this.chbDatumDo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDatumDo.Location = new System.Drawing.Point(74, 119);
            this.chbDatumDo.Name = "chbDatumDo";
            this.chbDatumDo.Size = new System.Drawing.Size(128, 17);
            this.chbDatumDo.TabIndex = 7;
            this.chbDatumDo.Text = "Datum Do nije poznat";
            this.chbDatumDo.UseVisualStyleBackColor = true;
            // 
            // btnAngazujNastavnika
            // 
            this.btnAngazujNastavnika.Location = new System.Drawing.Point(95, 152);
            this.btnAngazujNastavnika.Name = "btnAngazujNastavnika";
            this.btnAngazujNastavnika.Size = new System.Drawing.Size(130, 23);
            this.btnAngazujNastavnika.TabIndex = 6;
            this.btnAngazujNastavnika.Text = "Sacuvaj";
            this.btnAngazujNastavnika.UseVisualStyleBackColor = true;
            this.btnAngazujNastavnika.Click += new System.EventHandler(this.btnAngazujNastavnika_Click);
            // 
            // datumDo
            // 
            this.datumDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDo.Location = new System.Drawing.Point(74, 93);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(151, 20);
            this.datumDo.TabIndex = 5;
            // 
            // datumOd
            // 
            this.datumOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumOd.Location = new System.Drawing.Point(74, 58);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(151, 20);
            this.datumOd.TabIndex = 4;
            // 
            // listaNastavnika
            // 
            this.listaNastavnika.FormattingEnabled = true;
            this.listaNastavnika.Location = new System.Drawing.Point(74, 26);
            this.listaNastavnika.Name = "listaNastavnika";
            this.listaNastavnika.Size = new System.Drawing.Size(151, 21);
            this.listaNastavnika.TabIndex = 3;
            this.listaNastavnika.SelectedIndexChanged += new System.EventHandler(this.listaNastavnika_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Datum Do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Datum Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nastavnik:";
            // 
            // PredmetiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(674, 441);
            this.Controls.Add(this.grbAngazman);
            this.Controls.Add(this.btnAngazman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisiPredmet);
            this.Controls.Add(this.btnIzmeniPredmet);
            this.Controls.Add(this.btnDodajPremet);
            this.Controls.Add(this.listaOcena);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(690, 480);
            this.Name = "PredmetiForma";
            this.Text = "PREDMETI";
            this.Load += new System.EventHandler(this.PredmetiForma_Load);
            this.listaOcena.ResumeLayout(false);
            this.grbAngazman.ResumeLayout(false);
            this.grbAngazman.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox listaOcena;
        private System.Windows.Forms.ListView listaPredmeta;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiPredmet;
        private System.Windows.Forms.Button btnIzmeniPredmet;
        private System.Windows.Forms.Button btnDodajPremet;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAngazman;
        private System.Windows.Forms.GroupBox grbAngazman;
        private System.Windows.Forms.Button btnAngazujNastavnika;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.DateTimePicker datumOd;
        private System.Windows.Forms.ComboBox listaNastavnika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbDatumDo;
    }
}