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
    public partial class UceniciForma : Form
    {
        public UceniciForma()
        {
            InitializeComponent();
        }

        public void PopuniTabeluPodacima()
        {
            listaUcenika.Items.Clear();
            List<UcenikPregled> informacije = DTOManager.vratiSveUcenike();
            foreach (UcenikPregled n in informacije)
            {

                ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Ime, n.Prezime, n.Razred, n.Adresa, n.SmerUcenika.Naziv, n.Datum_upisa.ToString() });
                listaUcenika.Items.Add(item);
            }
            listaUcenika.Refresh();
        }

        private void UceniciForma_Load(object sender, EventArgs e)
        {
            this.PopuniTabeluPodacima();
        }

        private void ObrisiUcenika_Click(object sender, EventArgs e)
        {

            if (listaUcenika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ucenika kog zelite da obrisete!");
                return;
            }
            int idUcenika = Int32.Parse(listaUcenika.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog ucenika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiUcenika(idUcenika);
                MessageBox.Show("Brisanje uspesno obavljeno!");
                this.PopuniTabeluPodacima();
            }
            else
            {

            }
        }

        private void BtnPrikaziOceneUcenika_Click(object sender, EventArgs e)
        {
            if (listaUcenika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ucenika cije ocene treba prikazati!");
                return;
            }
            int idUcenika = Int32.Parse(listaUcenika.SelectedItems[0].SubItems[0].Text);
            UcenikBasic ub = DTOManager.vratiUcenika(idUcenika);
            OcenaForma forma = new OcenaForma(ub);
            forma.ShowDialog();
        }

        private void BtnUnesiPodatkeNovogUcenika_Click(object sender, EventArgs e)
        {

            DodajUcenikaForma forma = new DodajUcenikaForma();
            forma.ShowDialog();
            this.PopuniTabeluPodacima();
        }

        private void BtnIzmeniUcenika_Click(object sender, EventArgs e)
        {
            if (listaUcenika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ucenika koga zelite da izmenite!");
                return;
            }
            int idUcenika = Int32.Parse(listaUcenika.SelectedItems[0].SubItems[0].Text);
            UcenikBasic uc = DTOManager.vratiUcenika(idUcenika);
            IzmeniUcenikaForma forma = new IzmeniUcenikaForma(uc);
            forma.ShowDialog();
            PopuniTabeluPodacima();
        }

        private void BtnDodajStaratelja_Click(object sender, EventArgs e)
        {

            if (listaUcenika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ucenika kome zelite dodati staratelja!");
                return;
            }
            int idUcenika = Int32.Parse(listaUcenika.SelectedItems[0].SubItems[0].Text);
            UcenikBasic uc = DTOManager.vratiUcenika(idUcenika);
            DodajStarateljaForma forma = new DodajStarateljaForma(uc);
            forma.ShowDialog();
        }
    }
}
