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
    
    public partial class DodajUcenikaForma : Form
    {
        private UcenikBasic noviUcenik = new UcenikBasic();
        private SmerBasic smerUcenika = new SmerBasic();
        private int brUcenikaNaSmeru=0;
        public DodajUcenikaForma()
        {
            InitializeComponent();
        }

        private void DodajUcenikaForma_Load(object sender, EventArgs e)
        {

            PopuniTabeluPodacima();
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

            if (listaSmerova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite smer na koji zelite da dodate ucenika!");
                return;
            }
            int idSmera = Int32.Parse(listaSmerova.SelectedItems[0].SubItems[0].Text);
            this.brUcenikaNaSmeru=DTOManager.vratiBrojUcenikaNaSmeru(idSmera);
            smerUcenika = DTOManager.vratiSmer(idSmera);
            if (brUcenikaNaSmeru >= smerUcenika.MaxUcenika)
            {
                MessageBox.Show("Nije moguce dodati uvenika na  smer jer je broj mesta na smeru popunjen!");
                return;
            }
            MessageBox.Show("Trenutno na smeru ima " + brUcenikaNaSmeru + " ucenika moguce je dodati jos " + (smerUcenika.MaxUcenika - brUcenikaNaSmeru)+" .");
            groupBox1.Enabled = true;
            txbIme.Enabled = true;
            txbPrezime.Enabled = true;
            txbAdresa.Enabled = true;
            datumUpisa.Enabled = true;
            btnSacuvaj.Enabled = true;
            btnNastavi.Enabled = false;
            comboBoxRazred.Enabled = true;
            txbAdresa.Enabled = true;
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!validacija())
                return;
            noviUcenik.Ime = txbIme.Text;
            noviUcenik.Prezime = txbPrezime.Text;
            noviUcenik.Razred = comboBoxRazred.Text;
            noviUcenik.Datum_upisa = datumUpisa.Value;
            noviUcenik.SmerUcenika = smerUcenika;
            noviUcenik.Adresa = txbAdresa.Text;
            string poruka = "Da li zelite da nastavite?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.dodajUcenika(noviUcenik);

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
