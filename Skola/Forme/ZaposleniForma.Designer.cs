namespace Skola
{
    partial class ZaposleniForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaposleniForma));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaZaposlenih = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUkupno = new System.Windows.Forms.TextBox();
            this.txbNastavnici = new System.Windows.Forms.TextBox();
            this.txbOsoblje = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaZaposlenih);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Zaposlenih";
            // 
            // listaZaposlenih
            // 
            this.listaZaposlenih.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.listaZaposlenih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaZaposlenih.FullRowSelect = true;
            this.listaZaposlenih.GridLines = true;
            this.listaZaposlenih.Location = new System.Drawing.Point(3, 16);
            this.listaZaposlenih.Name = "listaZaposlenih";
            this.listaZaposlenih.Size = new System.Drawing.Size(564, 343);
            this.listaZaposlenih.TabIndex = 4;
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime Roditelja";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Jmbg";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adresa";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ukupan Broj Zaposlenih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nastavno Osoblje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nenastavno Osoblje:";
            // 
            // txbUkupno
            // 
            this.txbUkupno.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txbUkupno.Location = new System.Drawing.Point(591, 44);
            this.txbUkupno.Name = "txbUkupno";
            this.txbUkupno.ReadOnly = true;
            this.txbUkupno.Size = new System.Drawing.Size(121, 20);
            this.txbUkupno.TabIndex = 4;
            this.txbUkupno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbNastavnici
            // 
            this.txbNastavnici.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txbNastavnici.Location = new System.Drawing.Point(591, 99);
            this.txbNastavnici.Name = "txbNastavnici";
            this.txbNastavnici.ReadOnly = true;
            this.txbNastavnici.Size = new System.Drawing.Size(121, 20);
            this.txbNastavnici.TabIndex = 5;
            this.txbNastavnici.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbOsoblje
            // 
            this.txbOsoblje.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txbOsoblje.Location = new System.Drawing.Point(591, 155);
            this.txbOsoblje.Name = "txbOsoblje";
            this.txbOsoblje.ReadOnly = true;
            this.txbOsoblje.Size = new System.Drawing.Size(121, 20);
            this.txbOsoblje.TabIndex = 6;
            this.txbOsoblje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ZaposleniForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(744, 383);
            this.Controls.Add(this.txbOsoblje);
            this.Controls.Add(this.txbNastavnici);
            this.Controls.Add(this.txbUkupno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 422);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(760, 422);
            this.Name = "ZaposleniForma";
            this.Text = "ZAPOSLENI";
            this.Load += new System.EventHandler(this.ZaposleniForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaZaposlenih;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbUkupno;
        private System.Windows.Forms.TextBox txbNastavnici;
        private System.Windows.Forms.TextBox txbOsoblje;
    }
}