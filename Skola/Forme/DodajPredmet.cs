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
    public partial class DodajPredmet : Form
    {
        private PredmetBasic predmet= new PredmetBasic();
        public DodajPredmet()
        {
            InitializeComponent();
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!validacija())
                return;
            this.predmet.Naziv = txbNaziv.Text;
            this.predmet.Godina = comboBoxGodina.Text;
            this.predmet.smer =(SmerPregled) smerovi.SelectedItem;
            DTOManager.dodajPredmet(predmet);
            MessageBox.Show("Uspesno izvrseno dodavanje predmeta!");
            this.Close();
        }

        private void DodajPredmet_Load(object sender, EventArgs e)
        {
            this.Text = "DODAVANJE PREDMETA";
            List<SmerPregled> listaSmerova = DTOManager.vratiSveSmerove();
            foreach (SmerPregled s in listaSmerova)
                smerovi.Items.Add(s);

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
