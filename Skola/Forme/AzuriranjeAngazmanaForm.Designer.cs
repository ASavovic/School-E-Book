namespace Skola
{
    partial class AzuriranjeAngazmanaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AzuriranjeAngazmanaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datumOd = new System.Windows.Forms.DateTimePicker();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbDatumDo = new System.Windows.Forms.CheckBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum Do:";
            // 
            // datumOd
            // 
            this.datumOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumOd.Location = new System.Drawing.Point(81, 31);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(150, 20);
            this.datumOd.TabIndex = 2;
            // 
            // datumDo
            // 
            this.datumDo.Enabled = false;
            this.datumDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDo.Location = new System.Drawing.Point(81, 62);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(150, 20);
            this.datumDo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbDatumDo);
            this.groupBox1.Controls.Add(this.btnAzuriraj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datumDo);
            this.groupBox1.Controls.Add(this.datumOd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o angazmanu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chbDatumDo
            // 
            this.chbDatumDo.AutoSize = true;
            this.chbDatumDo.Checked = true;
            this.chbDatumDo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDatumDo.Location = new System.Drawing.Point(9, 99);
            this.chbDatumDo.Name = "chbDatumDo";
            this.chbDatumDo.Size = new System.Drawing.Size(138, 17);
            this.chbDatumDo.TabIndex = 5;
            this.chbDatumDo.Text = "Datum Do nije definisan";
            this.chbDatumDo.UseVisualStyleBackColor = true;
            this.chbDatumDo.CheckedChanged += new System.EventHandler(this.chbDatumDo_CheckedChanged);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(119, 154);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(112, 27);
            this.btnAzuriraj.TabIndex = 4;
            this.btnAzuriraj.Text = "Azuriraj Angazman";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // AzuriranjeAngazmanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(267, 214);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(283, 253);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(283, 253);
            this.Name = "AzuriranjeAngazmanaForm";
            this.Text = "AZURIRANJE ANGAZMANA";
            this.Load += new System.EventHandler(this.AzuriranjeAngazmanaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datumOd;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbDatumDo;
        private System.Windows.Forms.Button btnAzuriraj;
    }
}