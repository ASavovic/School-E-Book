using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Skola
{
    public partial class AzuriranjeAngazmanaForm : Form
    {
        AngazmanBasic angazman;
        public AzuriranjeAngazmanaForm()
        {
            InitializeComponent();
        }
        public AzuriranjeAngazmanaForm(AngazmanBasic a)
        {
            InitializeComponent();
            angazman = a;
        }

        private void chbDatumDo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDatumDo.Checked == false)
                datumDo.Enabled = true;
            else
                datumDo.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AzuriranjeAngazmanaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            datumOd.Value = angazman.DatumOd;
            if(angazman.DatumDo!=null)
                datumDo.Value = (DateTime)angazman.DatumDo;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

            string poruka = "Da li zelite da izvrsite izmene?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.angazman.DatumOd = datumOd.Value;
                if (chbDatumDo.Checked == false)
                    this.angazman.DatumDo = datumDo.Value;
                
  
                DTOManager.azurirajAngazman(this.angazman);
                MessageBox.Show("Uspesno izvrseno azuriranje!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
