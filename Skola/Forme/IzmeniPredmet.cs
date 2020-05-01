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
    public partial class IzmeniPredmet : Form
    {
        PredmetBasic pred = new PredmetBasic();
        String smer;
        public IzmeniPredmet(PredmetBasic p,String smer)
        {
            InitializeComponent();
            pred = p;
            this.smer = smer;
        }

        private void IzmeniPredmet_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"IZMENA PREDMETA {pred.Naziv.ToUpper()} ";
        }
        public void popuniPodacima()
        {
            txbNaziv.Text = this.pred.Naziv;
            comboBoxGodina.Text = this.pred.Godina;
            listaSmerova.Text = this.smer;
            List<SmerPregled> listaSmerovaPregled = DTOManager.vratiSveSmerove();
            foreach (SmerPregled s in listaSmerovaPregled)
                this.listaSmerova.Items.Add(s);

        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!validacija())
                return;
            string poruka = "Da li zelite da izvrsite izmene?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.pred.Naziv = txbNaziv.Text;
                this.pred.Godina = comboBoxGodina.Text;
                this.pred.smer = (SmerPregled)listaSmerova.SelectedItem;
                DTOManager.azurirajPredmet(pred);
                MessageBox.Show("Uspesno izvrseno azuriranje!");
                this.Close();
            }
            else
            {

            }
        }
        private bool validacija()
        {
            if (txbNaziv.Text.Length > 15 || txbNaziv.Text=="")
            {
                MessageBox.Show("Naziv predmeta je nevalidan!");
                return false;

            }

            else return true;

        }
    }

}
