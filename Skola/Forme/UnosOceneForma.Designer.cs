namespace Skola
{
    partial class UnosOceneForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosOceneForma));
            this.listaOcena = new System.Windows.Forms.GroupBox();
            this.listaPredmeta = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajOcenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOcena = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datumDobijanjaOcene = new System.Windows.Forms.DateTimePicker();
            this.listaOcena.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaOcena
            // 
            this.listaOcena.Controls.Add(this.listaPredmeta);
            this.listaOcena.Location = new System.Drawing.Point(12, 12);
            this.listaOcena.Name = "listaOcena";
            this.listaOcena.Size = new System.Drawing.Size(242, 334);
            this.listaOcena.TabIndex = 23;
            this.listaOcena.TabStop = false;
            this.listaOcena.Text = "Lista Predmeta";
            // 
            // listaPredmeta
            // 
            this.listaPredmeta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1});
            this.listaPredmeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaPredmeta.FullRowSelect = true;
            this.listaPredmeta.GridLines = true;
            this.listaPredmeta.Location = new System.Drawing.Point(3, 16);
            this.listaPredmeta.MultiSelect = false;
            this.listaPredmeta.Name = "listaPredmeta";
            this.listaPredmeta.Size = new System.Drawing.Size(236, 315);
            this.listaPredmeta.TabIndex = 4;
            this.listaPredmeta.UseCompatibleStateImageBehavior = false;
            this.listaPredmeta.View = System.Windows.Forms.View.Details;
            this.listaPredmeta.SelectedIndexChanged += new System.EventHandler(this.popuniPoljeNastavnici);
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
            this.columnHeader8.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nastavnik";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 100;
            // 
            // btnDodajOcenu
            // 
            this.btnDodajOcenu.Location = new System.Drawing.Point(420, 110);
            this.btnDodajOcenu.Name = "btnDodajOcenu";
            this.btnDodajOcenu.Size = new System.Drawing.Size(150, 35);
            this.btnDodajOcenu.TabIndex = 21;
            this.btnDodajOcenu.Text = "Unesi Ocenu";
            this.btnDodajOcenu.UseVisualStyleBackColor = true;
            this.btnDodajOcenu.Click += new System.EventHandler(this.BtnDodajOcenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 27;
            // 
            // comboBoxOcena
            // 
            this.comboBoxOcena.FormattingEnabled = true;
            this.comboBoxOcena.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxOcena.Location = new System.Drawing.Point(420, 69);
            this.comboBoxOcena.Name = "comboBoxOcena";
            this.comboBoxOcena.Size = new System.Drawing.Size(150, 21);
            this.comboBoxOcena.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Datum upisa ocene:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Numericka Vrednost Ocene:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(472, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Neophodno je selektovati pedmet iz kog je ucenik dobio odgovarajucu ocenu.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datumDobijanjaOcene
            // 
            this.datumDobijanjaOcene.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDobijanjaOcene.Location = new System.Drawing.Point(420, 34);
            this.datumDobijanjaOcene.Name = "datumDobijanjaOcene";
            this.datumDobijanjaOcene.Size = new System.Drawing.Size(150, 20);
            this.datumDobijanjaOcene.TabIndex = 37;
            this.datumDobijanjaOcene.Value = new System.DateTime(2019, 6, 5, 16, 46, 37, 0);
            // 
            // UnosOceneForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(581, 384);
            this.Controls.Add(this.datumDobijanjaOcene);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOcena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listaOcena);
            this.Controls.Add(this.btnDodajOcenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(597, 423);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(597, 423);
            this.Name = "UnosOceneForma";
            this.Text = "UNOS OCENA";
            this.Load += new System.EventHandler(this.UnosOceneForma_Load);
            this.listaOcena.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox listaOcena;
        private System.Windows.Forms.ListView listaPredmeta;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnDodajOcenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOcena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datumDobijanjaOcene;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}