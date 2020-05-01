namespace Skola
{
    partial class NastavnaLicaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NastavnaLicaForma));
            this.btnUnesiNastavnoLice = new System.Windows.Forms.Button();
            this.btnIzmeniNastavnika = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listaNastavnika = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAngazmanNastavnika = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUnesiNastavnoLice
            // 
            this.btnUnesiNastavnoLice.Location = new System.Drawing.Point(541, 28);
            this.btnUnesiNastavnoLice.Name = "btnUnesiNastavnoLice";
            this.btnUnesiNastavnoLice.Size = new System.Drawing.Size(151, 38);
            this.btnUnesiNastavnoLice.TabIndex = 1;
            this.btnUnesiNastavnoLice.Text = "Dodaj Nastavnika";
            this.btnUnesiNastavnoLice.UseVisualStyleBackColor = true;
            this.btnUnesiNastavnoLice.Click += new System.EventHandler(this.btnUnesiNastavnoLice_Click);
            // 
            // btnIzmeniNastavnika
            // 
            this.btnIzmeniNastavnika.Location = new System.Drawing.Point(541, 72);
            this.btnIzmeniNastavnika.Name = "btnIzmeniNastavnika";
            this.btnIzmeniNastavnika.Size = new System.Drawing.Size(151, 36);
            this.btnIzmeniNastavnika.TabIndex = 2;
            this.btnIzmeniNastavnika.Text = "Izmeni Nastavnika";
            this.btnIzmeniNastavnika.UseVisualStyleBackColor = true;
            this.btnIzmeniNastavnika.Click += new System.EventHandler(this.btnIzmeniNastavnika_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Obrisi Nastavnika";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listaNastavnika
            // 
            this.listaNastavnika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader1});
            this.listaNastavnika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaNastavnika.FullRowSelect = true;
            this.listaNastavnika.GridLines = true;
            this.listaNastavnika.Location = new System.Drawing.Point(3, 16);
            this.listaNastavnika.MultiSelect = false;
            this.listaNastavnika.Name = "listaNastavnika";
            this.listaNastavnika.Size = new System.Drawing.Size(517, 311);
            this.listaNastavnika.TabIndex = 4;
            this.listaNastavnika.UseCompatibleStateImageBehavior = false;
            this.listaNastavnika.View = System.Windows.Forms.View.Details;
            this.listaNastavnika.SelectedIndexChanged += new System.EventHandler(this.listaNastavnika_SelectedIndexChanged);
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
            this.columnHeader9.Text = "Ime Roditelja";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 111;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Prezime";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 103;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Jmbg";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 121;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Adresa";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 149;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Puna Norma";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaNastavnika);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 330);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Nastavnih Lica";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Podaci prikazani u tabeli su\r\nosnovni podaci zaposlenog \r\nnastavnog osoblja skole" +
    ".";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnAngazmanNastavnika
            // 
            this.btnAngazmanNastavnika.Location = new System.Drawing.Point(541, 157);
            this.btnAngazmanNastavnika.Name = "btnAngazmanNastavnika";
            this.btnAngazmanNastavnika.Size = new System.Drawing.Size(151, 37);
            this.btnAngazmanNastavnika.TabIndex = 7;
            this.btnAngazmanNastavnika.Text = "Angazman Nastavnika";
            this.btnAngazmanNastavnika.UseVisualStyleBackColor = true;
            this.btnAngazmanNastavnika.Click += new System.EventHandler(this.btnAngazmanNastavnika_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Rad u drugim skolama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NastavnaLicaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAngazmanNastavnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnIzmeniNastavnika);
            this.Controls.Add(this.btnUnesiNastavnoLice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(735, 393);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(735, 393);
            this.Name = "NastavnaLicaForma";
            this.Text = "NASTAVNA LICA";
            this.Load += new System.EventHandler(this.NastavnaLica_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUnesiNastavnoLice;
        private System.Windows.Forms.Button btnIzmeniNastavnika;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listaNastavnika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAngazmanNastavnika;
        private System.Windows.Forms.Button button1;
    }
}