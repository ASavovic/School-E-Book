namespace Skola
{
    partial class SmeroviForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmeroviForma));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaSmerova = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisiSmer = new System.Windows.Forms.Button();
            this.btnIzmeniSmer = new System.Windows.Forms.Button();
            this.btnDodajSmer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 48);
            this.label1.TabIndex = 13;
            this.label1.Text = "Podaci prikazani u tabeli \r\nsu osnovni podaci\r\no smerovima skole.";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaSmerova);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 330);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Smerova";
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
            this.listaSmerova.Size = new System.Drawing.Size(316, 311);
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
            // btnObrisiSmer
            // 
            this.btnObrisiSmer.Location = new System.Drawing.Point(362, 123);
            this.btnObrisiSmer.Name = "btnObrisiSmer";
            this.btnObrisiSmer.Size = new System.Drawing.Size(151, 37);
            this.btnObrisiSmer.TabIndex = 11;
            this.btnObrisiSmer.Text = "Obrisi Smer";
            this.btnObrisiSmer.UseVisualStyleBackColor = true;
            this.btnObrisiSmer.Click += new System.EventHandler(this.BtnObrisiSmer_Click);
            // 
            // btnIzmeniSmer
            // 
            this.btnIzmeniSmer.Location = new System.Drawing.Point(362, 81);
            this.btnIzmeniSmer.Name = "btnIzmeniSmer";
            this.btnIzmeniSmer.Size = new System.Drawing.Size(151, 36);
            this.btnIzmeniSmer.TabIndex = 10;
            this.btnIzmeniSmer.Text = "Izmeni Smer";
            this.btnIzmeniSmer.UseVisualStyleBackColor = true;
            this.btnIzmeniSmer.Click += new System.EventHandler(this.BtnIzmeniSmer_Click);
            // 
            // btnDodajSmer
            // 
            this.btnDodajSmer.Location = new System.Drawing.Point(362, 37);
            this.btnDodajSmer.Name = "btnDodajSmer";
            this.btnDodajSmer.Size = new System.Drawing.Size(151, 38);
            this.btnDodajSmer.TabIndex = 9;
            this.btnDodajSmer.Text = "Dodaj Smer";
            this.btnDodajSmer.UseVisualStyleBackColor = true;
            this.btnDodajSmer.Click += new System.EventHandler(this.BtnDodajSmer_Click);
            // 
            // SmeroviForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(559, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnObrisiSmer);
            this.Controls.Add(this.btnIzmeniSmer);
            this.Controls.Add(this.btnDodajSmer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(575, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(575, 400);
            this.Name = "SmeroviForma";
            this.Text = "SMEROVI";
            this.Load += new System.EventHandler(this.SmeroviForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaSmerova;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnObrisiSmer;
        private System.Windows.Forms.Button btnIzmeniSmer;
        private System.Windows.Forms.Button btnDodajSmer;
    }
}