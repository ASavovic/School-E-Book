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
    public partial class OcenaForma : Form
    {
        private UcenikBasic ucenik = new UcenikBasic();
        public OcenaForma(UcenikBasic u)
        {
            InitializeComponent();
            ucenik = u;
        }

        private void OcenaForma_Load(object sender, EventArgs e)
        {
            this.PopuniTabeluPodacima();
            this.Text = $"OCENE UCENIKA {ucenik.Ime.ToUpper()} {ucenik.Prezime.ToUpper()}";
        }
        public void PopuniTabeluPodacima()
        {
            listaOcenaUcenika.Items.Clear();
            List<OcenaPregled> informacije = DTOManager.vratiOceneUcenika(ucenik);
            foreach (OcenaPregled n in informacije)
            {

                ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Opis, n.NumerickaVrednost.ToString(), n.DatumDobijanja.ToShortDateString(), n.Predmet.Naziv });
                listaOcenaUcenika.Items.Add(item);
            }
            listaOcenaUcenika.Refresh();
        }

        private void BtnDodajOcenu_Click(object sender, EventArgs e)
        {
            UnosOceneForma forma = new UnosOceneForma(ucenik);
            forma.ShowDialog();
            PopuniTabeluPodacima();
        }

        private void BtnObrisiOcenu_Click(object sender, EventArgs e)
        {
            if (listaOcenaUcenika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite smer koji zelite da obrisete!");
                return;
            }
            int idOcene = Int32.Parse(listaOcenaUcenika.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu ocenu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiOcenu(idOcene);
                MessageBox.Show("Brisanje uspesno obavljeno!");
                this.PopuniTabeluPodacima();
            }
            else
            {

            }

        }
    }
}
