namespace Skola
{
    partial class PredmetiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredmetiForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaPredmeta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datumOd = new System.Windows.Forms.DateTimePicker();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.chbDatumDo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaPredmeta);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista dostupnih predmeta";
            // 
            // listaPredmeta
            // 
            this.listaPredmeta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listaPredmeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaPredmeta.FullRowSelect = true;
            this.listaPredmeta.GridLines = true;
            this.listaPredmeta.Location = new System.Drawing.Point(3, 16);
            this.listaPredmeta.Name = "listaPredmeta";
            this.listaPredmeta.Size = new System.Drawing.Size(338, 257);
            this.listaPredmeta.TabIndex = 0;
            this.listaPredmeta.UseCompatibleStateImageBehavior = false;
            this.listaPredmeta.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Godina";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 114;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Smer";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum Do:";
            // 
            // datumOd
            // 
            this.datumOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumOd.Location = new System.Drawing.Point(438, 34);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(154, 20);
            this.datumOd.TabIndex = 3;
            this.datumOd.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // datumDo
            // 
            this.datumDo.Enabled = false;
            this.datumDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDo.Location = new System.Drawing.Point(438, 60);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(154, 20);
            this.datumDo.TabIndex = 4;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(451, 129);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(141, 37);
            this.btnUnesi.TabIndex = 5;
            this.btnUnesi.Text = "Unesi Angazman";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // chbDatumDo
            // 
            this.chbDatumDo.AutoSize = true;
            this.chbDatumDo.Checked = true;
            this.chbDatumDo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDatumDo.Location = new System.Drawing.Point(471, 96);
            this.chbDatumDo.Name = "chbDatumDo";
            this.chbDatumDo.Size = new System.Drawing.Size(121, 17);
            this.chbDatumDo.TabIndex = 6;
            this.chbDatumDo.Text = "Datum Do nepoznat";
            this.chbDatumDo.UseVisualStyleBackColor = true;
            this.chbDatumDo.CheckedChanged += new System.EventHandler(this.chbChecked_onChange);
            // 
            // PredmetiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(606, 294);
            this.Controls.Add(this.chbDatumDo);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.datumDo);
            this.Controls.Add(this.datumOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(622, 333);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(622, 333);
            this.Name = "PredmetiForm";
            this.Text = "DODAVANJE ANGAZMANA";
            this.Load += new System.EventHandler(this.PredmetiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaPredmeta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datumOd;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.CheckBox chbDatumDo;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}