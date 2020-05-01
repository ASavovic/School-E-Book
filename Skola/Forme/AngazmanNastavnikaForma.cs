using Skola.Entiteti;
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
    public partial class AngazmanNastavnikaForma : Form
    {
        public NastavnoLiceBasic nastavnik;
        public AngazmanNastavnikaForma()
        {
            InitializeComponent();
        }
        public AngazmanNastavnikaForma(NastavnoLiceBasic n)
        {
            InitializeComponent();
            this.nastavnik = n;
        }

        private void AngazmanNastavnikaForma_Load(object sender, EventArgs e)
        {
            popuniTabeluPodacima();
            this.Text = $"ANGAZMAN NASTVNIKA {this.nastavnik.Ime.ToUpper()} {this.nastavnik.Prezime.ToUpper()}";
        }

        public void popuniTabeluPodacima()
        {
            listaPredmeta.Items.Clear();
            List<AngazmanPregled> informacije = DTOManager.vratiSveAngazmaneNastavnika(this.nastavnik);
            foreach (AngazmanPregled n in informacije)
            {
                if (n.Predmet.Smer.Count != 0)
                {
                    foreach (String smer in n.Predmet.Smer)
                    {
                        ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Predmet.Naziv, n.Predmet.Godina, smer, n.DatumOd.ToShortDateString(), n.DatumDo.ToString() });
                        listaPredmeta.Items.Add(item);
                    }
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Predmet.Naziv, n.Predmet.Godina, "Jos uvek nije definisan.", n.DatumOd.ToShortDateString(), n.DatumDo.ToString() });
                    listaPredmeta.Items.Add(item);
                }
                
              
            }
            listaPredmeta.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            PredmetiForm formaPredmeti = new PredmetiForm(this.nastavnik);
            formaPredmeti.ShowDialog();
            this.popuniTabeluPodacima();
        }

        private void btnUkloniAngazman_Click(object sender, EventArgs e)
        {
            if (listaPredmeta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite predmet za koji zelite da obrisete angazman!");
                return;
            }

            int idAngazmana = Int32.Parse(listaPredmeta.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani angazman?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiAngazman(idAngazmana);
                MessageBox.Show("Brisanje uspesno obavljeno!");
                this.popuniTabeluPodacima();
            }
            else
            {

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaPredmeta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite angazman koji zelite na izmenite!");
                return;
            }

            int idAngazmana = Int32.Parse(listaPredmeta.SelectedItems[0].SubItems[0].Text);
            AngazmanBasic a = DTOManager.vratiAngazman(idAngazmana);
            AzuriranjeAngazmanaForm formaAzuriranje = new AzuriranjeAngazmanaForm(a);
            formaAzuriranje.ShowDialog();
            
            this.popuniTabeluPodacima();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
