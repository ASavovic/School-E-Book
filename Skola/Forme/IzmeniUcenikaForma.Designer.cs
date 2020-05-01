namespace Skola
{
    partial class IzmeniUcenikaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniUcenikaForma));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listaSmerova = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSmer = new System.Windows.Forms.Label();
            this.lblSmer = new System.Windows.Forms.Label();
            this.comboBoxRazred = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.datumUpisa = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAdresa = new System.Windows.Forms.TextBox();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listaSmerova);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 390);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Smerova";
            // 
            // listaSmerova
            // 
            this.listaSmerova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listaSmerova.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaSmerova.FullRowSelect = true;
            this.listaSmerova.GridLines = true;
            this.listaSmerova.Location = new System.Drawing.Point(3, 16);
            this.listaSmerova.MultiSelect = false;
            this.listaSmerova.Name = "listaSmerova";
            this.listaSmerova.Size = new System.Drawing.Size(344, 371);
            this.listaSmerova.TabIndex = 4;
            this.listaSmerova.UseCompatibleStateImageBehavior = false;
            this.listaSmerova.View = System.Windows.Forms.View.Details;
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
            this.columnHeader8.Width = 160;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Max Ucenika ";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 111;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelSmer);
            this.groupBox1.Controls.Add(this.lblSmer);
            this.groupBox1.Controls.Add(this.comboBoxRazred);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.datumUpisa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbAdresa);
            this.groupBox1.Controls.Add(this.txbIme);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbPrezime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(368, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 390);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o uceniku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 48);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ukoliko zelite da promenite smer ucenika\r\nneophodno je da izaberete novi smer.\r\n(" +
    "Tabela levo)";
            // 
            // labelSmer
            // 
            this.labelSmer.AutoSize = true;
            this.labelSmer.Location = new System.Drawing.Point(112, 208);
            this.labelSmer.Name = "labelSmer";
            this.labelSmer.Size = new System.Drawing.Size(35, 13);
            this.labelSmer.TabIndex = 23;
            this.labelSmer.Text = "label4";
            // 
            // lblSmer
            // 
            this.lblSmer.AutoSize = true;
            this.lblSmer.Location = new System.Drawing.Point(16, 208);
            this.lblSmer.Name = "lblSmer";
            this.lblSmer.Size = new System.Drawing.Size(77, 13);
            this.lblSmer.TabIndex = 22;
            this.lblSmer.Text = "Smer Ucenika:";
            // 
            // comboBoxRazred
            // 
            this.comboBoxRazred.FormattingEnabled = true;
            this.comboBoxRazred.Items.AddRange(new object[] {
            "prvi",
            "drugi",
            "treći",
            "četvrti"});
            this.comboBoxRazred.Location = new System.Drawing.Point(115, 101);
            this.comboBoxRazred.Name = "comboBoxRazred";
            this.comboBoxRazred.Size = new System.Drawing.Size(143, 21);
            this.comboBoxRazred.TabIndex = 19;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(128, 279);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(130, 34);
            this.btnSacuvaj.TabIndex = 14;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // datumUpisa
            // 
            this.datumUpisa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumUpisa.Location = new System.Drawing.Point(115, 167);
            this.datumUpisa.Name = "datumUpisa";
            this.datumUpisa.Size = new System.Drawing.Size(143, 20);
            this.datumUpisa.TabIndex = 13;
            this.datumUpisa.Value = new System.DateTime(2019, 6, 3, 10, 58, 7, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // txbAdresa
            // 
            this.txbAdresa.Location = new System.Drawing.Point(115, 136);
            this.txbAdresa.Name = "txbAdresa";
            this.txbAdresa.Size = new System.Drawing.Size(143, 20);
            this.txbAdresa.TabIndex = 10;
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(115, 29);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(143, 20);
            this.txbIme.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Datum Upisa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // txbPrezime
            // 
            this.txbPrezime.Location = new System.Drawing.Point(115, 62);
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(143, 20);
            this.txbPrezime.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razred:";
            // 
            // IzmeniUcenikaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(667, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(683, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(683, 450);
            this.Name = "IzmeniUcenikaForma";
            this.Text = "AZURIRANJE UCENIKA";
            this.Load += new System.EventHandler(this.IzmeniUcenikaForma_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listaSmerova;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxRazred;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DateTimePicker datumUpisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAdresa;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSmer;
        private System.Windows.Forms.Label labelSmer;
        private System.Windows.Forms.Label label4;
    }
}