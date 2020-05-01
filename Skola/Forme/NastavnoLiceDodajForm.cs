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
    public partial class NastavnoLiceDodajForm : Form
    {
        NastavnoLiceBasic nastavnik;
        public NastavnoLiceDodajForm()
        {
            InitializeComponent();
            nastavnik = new NastavnoLiceBasic();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!validacija())
                return;
            string poruka = "Da li zelite da dodate novog nastavnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.nastavnik.Ime = txbIme.Text;
                this.nastavnik.Ime_Roditelja = txbImeRoditelja.Text;
                this.nastavnik.Prezime = txbPrezime.Text;
                this.nastavnik.Jmbg = txbJmbg.Text;
                this.nastavnik.Adresa = txbAdresa.Text;
                if (chbPunaNorma.Checked == true)
                    this.nastavnik.PunaNorma = 1;
                else
                    this.nastavnik.PunaNorma = 0;
                this.nastavnik.DatumRodjenja = datumRodjenja.Value;
                DTOManager.dodajNastavnoLice(this.nastavnik);
                MessageBox.Show("Uspesno ste dodali novog nastavnika!");
                this.Close();
            }
            else
            {

            }


        }
        private bool validacija()
        {
            long pom = 0; ;
            if (txbJmbg.Text.Length != 13)
            {
                MessageBox.Show("Duzina JMBG-a koji ste uneli nije 13!");
                return false;

            }
            else if (!(Int64.TryParse(txbJmbg.Text, out pom)))
            {
                MessageBox.Show("Polje za JMBG sadrzi karaktere koji nisu cifre!");
                return false;
            }
            else if (txbIme.Text == "" || txbIme.Text.Length > 15)
            {
                MessageBox.Show("Nevalidan unos imena!");
                return false;

            }
            else if (txbImeRoditelja.Text == "" || txbImeRoditelja.Text.Length > 15)
            {
                MessageBox.Show("Nevalidan unos imena roditelja!");
                return false;

            }
            else if (txbPrezime.Text == "" || txbPrezime.Text.Length > 20)
            {
                MessageBox.Show("Nevalidan unos prezimena!");
                return false;

            }
            else if (txbAdresa.Text == "" || txbAdresa.Text.Length > 30)
            {
                MessageBox.Show("Nevalidan unos adrese!");
                return false;

            }
            else return true;

        }
        
    }
}
