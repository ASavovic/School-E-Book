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
    public partial class RadUDrugiSkolamaForm : Form
    {
        NastavnoLiceBasic nastavnik;
        public RadUDrugiSkolamaForm()
        {
            InitializeComponent();
        }
        public RadUDrugiSkolamaForm(NastavnoLiceBasic n)
        {
            InitializeComponent();
            this.nastavnik = n;
        }

        private void RadUDrugiSkolamaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            listaSkola.Items.Clear();
            List<RadUDrugojSkoliPregled> informacije = DTOManager.vratiRadUDrugimSkolama(this.nastavnik.Id);
            foreach (RadUDrugojSkoliPregled n in informacije)
            {
               
                ListViewItem item = new ListViewItem(new string[] { n.id.ToString(), n.skola.Naziv, n.brojCasova.ToString()});
                listaSkola.Items.Add(item);
            }
            listaSkola.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaSkola.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite skolu u kojoj radnik vise ne radi!");
                return;
            }

            int idRada = Int32.Parse(listaSkola.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani angazman?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiRadUdrugojSkoli(idRada);
                MessageBox.Show("Brisanje uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            DodajRadUDrugojSkoliForm forma = new DodajRadUDrugojSkoliForm(this.nastavnik);
            forma.ShowDialog();
            popuniPodacima();
           

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaSkola.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite stavku za izmenu!");
                return;
            }

            int idRada = Int32.Parse(listaSkola.SelectedItems[0].SubItems[0].Text);
            RadUDrugojSkoliBasic rad = DTOManager.vratiRadUSkoli(idRada);
            DodajRadUDrugojSkoliForm forma = new DodajRadUDrugojSkoliForm(rad);
            forma.ShowDialog();
            popuniPodacima();

        }
    }
}
