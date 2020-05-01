namespace Skola
{
    partial class OcenaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OcenaForma));
            this.label1 = new System.Windows.Forms.Label();
            this.listaOcena = new System.Windows.Forms.GroupBox();
            this.listaOcenaUcenika = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajOcenu = new System.Windows.Forms.Button();
            this.btnObrisiOcenu = new System.Windows.Forms.Button();
            this.listaOcena.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 64);
            this.label1.TabIndex = 19;
            this.label1.Text = "Podaci prikazani\r\nu tabeli su\r\nosnovni podaci o \r\nocenama ucenika.";
            // 
            // listaOcena
            // 
            this.listaOcena.Controls.Add(this.listaOcenaUcenika);
            this.listaOcena.Location = new System.Drawing.Point(12, 21);
            this.listaOcena.Name = "listaOcena";
            this.listaOcena.Size = new System.Drawing.Size(486, 330);
            this.listaOcena.TabIndex = 18;
            this.listaOcena.TabStop = false;
            this.listaOcena.Text = "Lista Ocena";
            // 
            // listaOcenaUcenika
            // 
            this.listaOcenaUcenika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listaOcenaUcenika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaOcenaUcenika.FullRowSelect = true;
            this.listaOcenaUcenika.GridLines = true;
            this.listaOcenaUcenika.Location = new System.Drawing.Point(3, 16);
            this.listaOcenaUcenika.MultiSelect = false;
            this.listaOcenaUcenika.Name = "listaOcenaUcenika";
            this.listaOcenaUcenika.Size = new System.Drawing.Size(480, 311);
            this.listaOcenaUcenika.TabIndex = 4;
            this.listaOcenaUcenika.UseCompatibleStateImageBehavior = false;
            this.listaOcenaUcenika.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            this.columnHeader7.Width = 41;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Opis";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 86;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Numericka Vrednost";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 111;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Datum Dobijanja";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 137;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Predmet";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 121;
            // 
            // btnDodajOcenu
            // 
            this.btnDodajOcenu.Location = new System.Drawing.Point(507, 37);
            this.btnDodajOcenu.Name = "btnDodajOcenu";
            this.btnDodajOcenu.Size = new System.Drawing.Size(151, 38);
            this.btnDodajOcenu.TabIndex = 15;
            this.btnDodajOcenu.Text = "Unesi Ocenu";
            this.btnDodajOcenu.UseVisualStyleBackColor = true;
            this.btnDodajOcenu.Click += new System.EventHandler(this.BtnDodajOcenu_Click);
            // 
            // btnObrisiOcenu
            // 
            this.btnObrisiOcenu.Location = new System.Drawing.Point(507, 81);
            this.btnObrisiOcenu.Name = "btnObrisiOcenu";
            this.btnObrisiOcenu.Size = new System.Drawing.Size(151, 36);
            this.btnObrisiOcenu.TabIndex = 20;
            this.btnObrisiOcenu.Text = "Obrisi Ocenu";
            this.btnObrisiOcenu.UseVisualStyleBackColor = true;
            this.btnObrisiOcenu.Click += new System.EventHandler(this.BtnObrisiOcenu_Click);
            // 
            // OcenaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(668, 355);
            this.Controls.Add(this.btnObrisiOcenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaOcena);
            this.Controls.Add(this.btnDodajOcenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(684, 394);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(684, 394);
            this.Name = "OcenaForma";
            this.Text = "OCENE UCENIKA";
            this.Load += new System.EventHandler(this.OcenaForma_Load);
            this.listaOcena.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox listaOcena;
        private System.Windows.Forms.ListView listaOcenaUcenika;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnDodajOcenu;
        private System.Windows.Forms.Button btnObrisiOcenu;
    }
}