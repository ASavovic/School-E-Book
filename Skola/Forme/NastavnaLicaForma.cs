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
    public partial class NastavnaLicaForma : Form
    {
        public NastavnaLicaForma()
        {
            InitializeComponent();
        }

        private void NastavnaLica_Load(object sender, EventArgs e)
        {
            this.PopuniTabeluPodacima();
        }
        public void PopuniTabeluPodacima()
        {
            listaNastavnika.Items.Clear();
            List<NastavnoLicePregled> informacije = DTOManager.vratiSvaNastavnaLica();
            foreach (NastavnoLicePregled n in informacije)
            {
                String norma = "";
                if (n.PunaNorma == 1)
                    norma = "Da";
                else
                    norma = "Ne";
                ListViewItem item = new ListViewItem(new string[] {n.Id.ToString(),n.Ime,n.Ime_Roditelja,n.Prezime,n.Jmbg,n.Adresa,norma });
                listaNastavnika.Items.Add(item);
            }
            listaNastavnika.Refresh();
        }

        private void btnIzmeniNasatvnika_Click(object sender, EventArgs e)
        {
        
        }

        private void btnIzmeniNastavnika_Click(object sender, EventArgs e)
        {
            if (listaNastavnika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nastavnika cije podatke zelite da izmenite!");
                return;
            }

            int idNastavnika = Int32.Parse(listaNastavnika.SelectedItems[0].SubItems[0].Text);
            NastavnoLiceBasic ob = DTOManager.vratiNastavnoLice(idNastavnika);

            NastavnoLiceUpdateForm formaUpdate = new NastavnoLiceUpdateForm(ob);
            formaUpdate.ShowDialog();
            this.PopuniTabeluPodacima();
              

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaNastavnika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nastavnika koga zelite da obrisete!");
                return;
            }

            int idNastavnika = Int32.Parse(listaNastavnika.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog nastavnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiNastavnoLice(idNastavnika);
                MessageBox.Show("Brisanje uspesno obavljeno!");
                this.PopuniTabeluPodacima();
            }
            else
            {

            }

        }

        private void btnUnesiNastavnoLice_Click(object sender, EventArgs e)
        {
            NastavnoLiceDodajForm formaDodaj = new NastavnoLiceDodajForm();
            formaDodaj.ShowDialog();
            this.PopuniTabeluPodacima();
        }

        private void btnAngazmanNastavnika_Click(object sender, EventArgs e)
        {
            if (listaNastavnika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nastavnika cije angazmane zelite da vidite!");
                return;
            }

            int idNastavnika = Int32.Parse(listaNastavnika.SelectedItems[0].SubItems[0].Text);
            NastavnoLiceBasic ob = DTOManager.vratiNastavnoLice(idNastavnika);

            AngazmanNastavnikaForma formaAngazman = new AngazmanNastavnikaForma(ob);
            formaAngazman.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaNastavnika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nastavnika bez pune norme ciji rad drugim skolama zelite da vidite!");
                return;
            }

            int idNastavnika = Int32.Parse(listaNastavnika.SelectedItems[0].SubItems[0].Text);
            NastavnoLiceBasic ob = DTOManager.vratiNastavnoLice(idNastavnika);
            if(ob.PunaNorma==1)
            {
                MessageBox.Show("Izabrali ste nastavnika sa punom normom!");
                return;
            }
            RadUDrugiSkolamaForm forma = new RadUDrugiSkolamaForm(ob);
            forma.ShowDialog();

        }

        private void listaNastavnika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
