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
    public partial class DodajNeNastavnoLiceForm : Form
    {
        NeNastavnoLiceBasic osoblje;
   
        public DodajNeNastavnoLiceForm()
        {
            InitializeComponent();
            btnSacuvaj.Text = "Dodaj";
            this.osoblje = new NeNastavnoLiceBasic();
        }
        public DodajNeNastavnoLiceForm(NeNastavnoLiceBasic n)
        {
            InitializeComponent();
            this.osoblje = n;
            btnSacuvaj.Text = "Izmeni";
           
               

        }
        private void DodajNastavnoLiceForm_Load(object sender, EventArgs e)
        {
            if(btnSacuvaj.Text=="Izmeni")
                popuniPodacima();
        }
        public void popuniPodacima()
        {
            txbIme.Text = osoblje.Ime;
            txbPrezime.Text = osoblje.Prezime;
            txbImeRoditelja.Text = osoblje.Ime_Roditelja;
            txbJmbg.Text = osoblje.Jmbg;
            txbAdresa.Text = osoblje.Adresa;
            txbSektor.Text = osoblje.sektor;
            txbSprema.Text = osoblje.sprema;
            datumRodjenja.Value = (DateTime)osoblje.DatumRodjenja;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!validacija())
                return;
            
            if (btnSacuvaj.Text=="Izmeni")
            {
                string poruka = "Da li ste sigurni da zelite da izmenite podatke?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);
                if (!validacija())
                    return;
                if (result == DialogResult.OK)
                {
                    this.prikupiPodatke();
                    DTOManager.azurirajNeNastavnoLice(this.osoblje);
                    MessageBox.Show("Azuriranje uspesno obavljeno!");
                    this.Close();
                }
                else
                {

                }

            }
            else
            {
                string poruka = "Da li ste sigurni da zelite da dodate novog zaposlenog?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);
                if (result == DialogResult.OK)
                {
                    this.prikupiPodatke();
                    DTOManager.dodajNeNastavnoLice(this.osoblje);
                    MessageBox.Show("Dodavanje uspesno obavljeno!");
                    this.Close();
                }
                else
                {

                }

            }
        }
        public void prikupiPodatke()
        {
            this.osoblje.Ime = txbIme.Text;
            this.osoblje.Prezime = txbPrezime.Text;
            this.osoblje.Ime_Roditelja = txbImeRoditelja.Text;
            this.osoblje.Adresa = txbAdresa.Text;
            this.osoblje.Jmbg = txbJmbg.Text;
            this.osoblje.sprema = txbSprema.Text;
            this.osoblje.sektor = txbSektor.Text;
            this.osoblje.DatumRodjenja = datumRodjenja.Value;
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
            else if(txbIme.Text == "" || txbIme.Text.Length >15)
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
            else if (txbSprema.Text == "" || txbSprema.Text.Length > 20)
            {
                MessageBox.Show("Nevalidan unos spreme!");
                return false;

            }
            else if (txbSektor.Text == "" || txbSektor.Text.Length > 30)
            {
                MessageBox.Show("Nevalidan unos sektora!");
                return false;

            }

            else return true;

        }
    }
}
