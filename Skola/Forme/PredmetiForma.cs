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
    
    public partial class PredmetiForma : Form
    {
        private PredmetBasic pred = new PredmetBasic();
        public PredmetiForma()
        {
            InitializeComponent();
        }

        private void PredmetiForma_Load(object sender, EventArgs e)
        {
            PopuniTabeluPodacima();
            List<NastavnoLicePregled> nastavnici = DTOManager.vratiSvaNastavnaLica();
            foreach (NastavnoLicePregled n in nastavnici)
                this.listaNastavnika.Items.Add(n);
        }
        public void PopuniTabeluPodacima()
        {
            listaPredmeta.Items.Clear();
            List<PredmetPregled> informacije = DTOManager.vratiSvePredmete();
            foreach (PredmetPregled n in informacije)
            {
                if (n.Smer.Count == 0)
                {
                    ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Naziv, n.Godina });
                    listaPredmeta.Items.Add(item);
                }
                else
                {
                    foreach (String s in n.Smer)
                    {
                        ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Naziv, n.Godina, s });
                        listaPredmeta.Items.Add(item);
                    }

                }
               
            }
            listaPredmeta.Refresh();
        }

        private void BtnObrisiPredmet_Click(object sender, EventArgs e)
        {

            if (listaPredmeta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite predmet koji zelite da obrisete!");
                return;
            }
            int idPredmeta = Int32.Parse(listaPredmeta.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani predmet?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPredmet(idPredmeta);
                MessageBox.Show("Brisanje uspesno obavljeno!");
                this.PopuniTabeluPodacima();
            }
            else
            {

            }
        }

        private void BtnDodajPremet_Click(object sender, EventArgs e)
        {
            DodajPredmet forma = new DodajPredmet();
            forma.ShowDialog();
            PopuniTabeluPodacima();
        }

        private void BtnIzmeniPredmet_Click(object sender, EventArgs e)
        {

            if (listaPredmeta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite predmet koji zelite da izmenite!");
                return;
            }
            int idPredmeta = Int32.Parse(listaPredmeta.SelectedItems[0].SubItems[0].Text);
            pred = DTOManager.vratiPredmet(idPredmeta);
            IzmeniPredmet forma = new IzmeniPredmet(pred, listaPredmeta.SelectedItems[0].SubItems[3].Text);
            forma.ShowDialog();
            PopuniTabeluPodacima();
        }

        private void btnAngazman_Click(object sender, EventArgs e)
        {
            if (listaPredmeta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite predmet za koji zelite da angazujete nastavnika!");
                return;
            }
            grbAngazman.Enabled = true;
           

        }

        private void btnAngazujNastavnika_Click(object sender, EventArgs e)
        {
            int idPredmeta = Int32.Parse(listaPredmeta.SelectedItems[0].SubItems[0].Text);
            PredmetBasic p = DTOManager.vratiPredmet(idPredmeta);

            DateTime datumOdKada = this.datumOd.Value;
            DateTime? datumDoKada = null;
            if (chbDatumDo.Checked == false)
                datumDoKada = this.datumDo.Value;


            string poruka = "Da li ste sigurni da zelite da dodati novi angazman?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                AngazmanBasic angazman = new AngazmanBasic();
                NastavnoLicePregled izabrani = (NastavnoLicePregled)this.listaNastavnika.SelectedItem;
                NastavnoLiceBasic nastavnik = DTOManager.vratiNastavnoLice(izabrani.Id);
                angazman.Nastavnik = nastavnik;
                angazman.Predmet = p;
                angazman.DatumOd = datumOdKada;
                angazman.DatumDo = datumDoKada;
                DTOManager.dodajAngazman(angazman);
                MessageBox.Show("Uspesno ste dodali novi angazman!");
                
                grbAngazman.Enabled = false;
            }
            else
            {

            }
        }

        private void listaNastavnika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
