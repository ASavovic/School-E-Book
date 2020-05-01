namespace Skola
{
    partial class DrugeSkoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugeSkoleForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaSkola = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dodaj = new System.Windows.Forms.GroupBox();
            this.txbNazivDodaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.izmeni = new System.Windows.Forms.GroupBox();
            this.txbNazivIzmeni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zaposleni = new System.Windows.Forms.GroupBox();
            this.listaZaposlenih = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.dodaj.SuspendLayout();
            this.izmeni.SuspendLayout();
            this.zaposleni.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaSkola);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Druge Obrazovne Ustanove";
            // 
            // listaSkola
            // 
            this.listaSkola.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listaSkola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaSkola.FullRowSelect = true;
            this.listaSkola.GridLines = true;
            this.listaSkola.Location = new System.Drawing.Point(3, 16);
            this.listaSkola.Name = "listaSkola";
            this.listaSkola.Size = new System.Drawing.Size(369, 154);
            this.listaSkola.TabIndex = 0;
            this.listaSkola.UseCompatibleStateImageBehavior = false;
            this.listaSkola.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Naziv";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // dodaj
            // 
            this.dodaj.Controls.Add(this.txbNazivDodaj);
            this.dodaj.Controls.Add(this.label1);
            this.dodaj.Enabled = false;
            this.dodaj.Location = new System.Drawing.Point(11, 188);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(222, 56);
            this.dodaj.TabIndex = 1;
            this.dodaj.TabStop = false;
            this.dodaj.Text = "Dodaj Skolu";
            // 
            // txbNazivDodaj
            // 
            this.txbNazivDodaj.Location = new System.Drawing.Point(57, 19);
            this.txbNazivDodaj.Name = "txbNazivDodaj";
            this.txbNazivDodaj.Size = new System.Drawing.Size(159, 20);
            this.txbNazivDodaj.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // izmeni
            // 
            this.izmeni.Controls.Add(this.txbNazivIzmeni);
            this.izmeni.Controls.Add(this.label2);
            this.izmeni.Enabled = false;
            this.izmeni.Location = new System.Drawing.Point(11, 250);
            this.izmeni.Name = "izmeni";
            this.izmeni.Size = new System.Drawing.Size(222, 55);
            this.izmeni.TabIndex = 2;
            this.izmeni.TabStop = false;
            this.izmeni.Text = "Izmeni Skolu";
            // 
            // txbNazivIzmeni
            // 
            this.txbNazivIzmeni.Location = new System.Drawing.Point(57, 19);
            this.txbNazivIzmeni.Name = "txbNazivIzmeni";
            this.txbNazivIzmeni.Size = new System.Drawing.Size(159, 20);
            this.txbNazivIzmeni.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv:";
            // 
            // zaposleni
            // 
            this.zaposleni.Controls.Add(this.listaZaposlenih);
            this.zaposleni.Enabled = false;
            this.zaposleni.Location = new System.Drawing.Point(12, 311);
            this.zaposleni.Name = "zaposleni";
            this.zaposleni.Size = new System.Drawing.Size(222, 139);
            this.zaposleni.TabIndex = 3;
            this.zaposleni.TabStop = false;
            this.zaposleni.Text = "Lista Zaposlenih";
            this.zaposleni.Enter += new System.EventHandler(this.zaposleni_Enter);
            // 
            // listaZaposlenih
            // 
            this.listaZaposlenih.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.listaZaposlenih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaZaposlenih.FullRowSelect = true;
            this.listaZaposlenih.GridLines = true;
            this.listaZaposlenih.Location = new System.Drawing.Point(3, 16);
            this.listaZaposlenih.Name = "listaZaposlenih";
            this.listaZaposlenih.Size = new System.Drawing.Size(216, 120);
            this.listaZaposlenih.TabIndex = 0;
            this.listaZaposlenih.UseCompatibleStateImageBehavior = false;
            this.listaZaposlenih.View = System.Windows.Forms.View.Details;
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
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prezime";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(254, 190);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(129, 37);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(254, 233);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(129, 37);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Obrisi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Zaposleni";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DrugeSkoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(395, 462);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.zaposleni);
            this.Controls.Add(this.izmeni);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DrugeSkoleForm";
            this.Text = "DRUGE SKOLE";
            this.Load += new System.EventHandler(this.DrugeSkoleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.dodaj.ResumeLayout(false);
            this.dodaj.PerformLayout();
            this.izmeni.ResumeLayout(false);
            this.izmeni.PerformLayout();
            this.zaposleni.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaSkola;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox dodaj;
        private System.Windows.Forms.TextBox txbNazivDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox izmeni;
        private System.Windows.Forms.TextBox txbNazivIzmeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox zaposleni;
        private System.Windows.Forms.ListView listaZaposlenih;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}