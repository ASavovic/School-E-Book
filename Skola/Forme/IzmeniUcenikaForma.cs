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
    public partial class IzmeniUcenikaForma : Form
    {
        private UcenikBasic Ucenik = new UcenikBasic();
        private UcenikBasic izmenjenUcenik = new UcenikBasic();
        private int brUcenikaNaSmeru = 0;
        private SmerBasic smerUcenika = new SmerBasic();
        public IzmeniUcenikaForma(UcenikBasic ucenik)
        {
            InitializeComponent();
            Ucenik = ucenik;
        }

        private void IzmeniUcenikaForma_Load(object sender, EventArgs e)
        {
            PopuniTabeluPodacima();
            PopuniPodatke();
            this.Text = $"IZMENA UCENIKA {this.Ucenik.Ime.ToUpper()} {this.Ucenik.Prezime.ToUpper()} ";
        }
        public void PopuniPodatke()
        {
            labelSmer.Text =Ucenik.SmerUcenika.Naziv;
            txbIme.Text = Ucenik.Ime;
            txbPrezime.Text = Ucenik.Prezime;
            txbAdresa.Text = Ucenik.Adresa;
            datumUpisa.Value = Ucenik.Datum_upisa;
            comboBoxRazred.Text = Ucenik.Razred;
            txbAdresa.Text = Ucenik.Adresa;
        }
        public void PopuniTabeluPodacima()
        {
            listaSmerova.Items.Clear();
            List<SmerPregled> informacije = DTOManager.vratiSveSmerove();
            foreach (SmerPregled n in informacije)
            {

                ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Naziv, n.MaxUcenika.ToString() });
                listaSmerova.Items.Add(item);
            }
            listaSmerova.Refresh();
        }

        private void BtnNastavi_Click(object sender, EventArgs e)
        {
            
            groupBox1.Enabled = true;
            txbIme.Enabled = true;
            txbPrezime.Enabled = true;
            txbAdresa.Enabled = true;
            datumUpisa.Enabled = true;
            btnSacuvaj.Enabled = true;
            //btnNastavi.Enabled = false;
            comboBoxRazred.Enabled = true;
            txbAdresa.Enabled = true;
            return;
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!validacija())
                return;
            izmenjenUcenik.Id = Ucenik.Id;
            izmenjenUcenik.Ime = txbIme.Text;
            izmenjenUcenik.Prezime = txbPrezime.Text;
            izmenjenUcenik.Razred = comboBoxRazred.Text;
            izmenjenUcenik.Datum_upisa = datumUpisa.Value;
            izmenjenUcenik.SmerUcenika = smerUcenika;
            izmenjenUcenik.Adresa = txbAdresa.Text;
            if (listaSmerova.SelectedItems.Count == 0)
            {
                smerUcenika = DTOManager.vratiSmer(Ucenik.SmerUcenika.Id);

            }
            else
            {
                int idSmera = Int32.Parse(listaSmerova.SelectedItems[0].SubItems[0].Text);
                this.brUcenikaNaSmeru = DTOManager.vratiBrojUcenikaNaSmeru(idSmera);
                smerUcenika = DTOManager.vratiSmer(idSmera);
                if (brUcenikaNaSmeru >= smerUcenika.MaxUcenika && smerUcenika.Id!=idSmera)
                {
                    MessageBox.Show("Nije moguce dodati ucenika na  smer jer je broj mesta na smeru popunjen!");
                    return;
                }
               // MessageBox.Show("Trenutno na smeru ima " + brUcenikaNaSmeru + " ucenika moguce je dodati jos " + (smerUcenika.MaxUcenika - brUcenikaNaSmeru) + " .");
                lblSmer.Text = smerUcenika.Naziv;


            }
            
            izmenjenUcenik.SmerUcenika = smerUcenika;
            string poruka = "Da li zelite da nastavite?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.azurirajUcenika(izmenjenUcenik);

                Close();
            }
            else
            {

            }
        }
        public bool validacija()
        {
            if (txbIme.Text == "" || txbIme.Text.Length > 15)
            {
                MessageBox.Show("Nevalidan unos imena!");
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
            return true;
        }


    }
}
