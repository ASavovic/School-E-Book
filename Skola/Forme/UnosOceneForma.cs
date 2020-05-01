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
    public partial class UnosOceneForma : Form
    {
        private UcenikBasic ucenik=new UcenikBasic();
        private OcenaBasic ocenaUcenikova= new OcenaBasic();
        public UnosOceneForma(UcenikBasic u)
        {
            InitializeComponent();
            ucenik = u;

        }

        private void UnosOceneForma_Load(object sender, EventArgs e)
        {
            this.PopuniTabeluPodacima();
            this.Text = $"UNOS OCENA UCENIKU {ucenik.Ime.ToUpper()} {ucenik.Prezime.ToUpper()}";
        }
        public void PopuniTabeluPodacima()
        {
            listaPredmeta.Items.Clear();
            List<PredmetPregled> informacije = DTOManager.vratiPredmeteUcenika(ucenik);
            foreach (PredmetPregled n in informacije)
            {

                ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Naziv,n.Nastavnik});
                listaPredmeta.Items.Add(item);
            }
            listaPredmeta.Refresh();
        }

        private void BtnDodajOcenu_Click(object sender, EventArgs e)
        {
            if (listaPredmeta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate izabrati predmet!");
                return;
            }
            
            int idPredmeta = Int32.Parse(listaPredmeta.SelectedItems[0].SubItems[0].Text);
            PredmetBasic ob = DTOManager.vratiPredmet(idPredmeta);
            ocenaUcenikova.DatumDobijanja = datumDobijanjaOcene.Value;
            ocenaUcenikova.NumerickaVrednost = Int32.Parse(comboBoxOcena.Text);
            ocenaUcenikova.Predmet = ob;
            String opis="";
            int vrednostOcene= Int32.Parse(comboBoxOcena.Text);
            switch (vrednostOcene)
            {
                case 1:
                    opis = "nedovoljan";
                    break;
                case 2:
                    opis = "dovoljan";
                    break;
                case 3:
                    opis = "dobar";
                    break;
                case 4:
                    opis = "vrlo dobar";
                    break;
                case 5:
                    opis = "odlican";
                    break;


            }
            ocenaUcenikova.Opis = opis;
            ocenaUcenikova.Ucenik = ucenik;
            DTOManager.dodajOcenu(ocenaUcenikova);
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void popuniPoljeNastavnici(object sender, EventArgs e)
        {
            
        }
    }
}
