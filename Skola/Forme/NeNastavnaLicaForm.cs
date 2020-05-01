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
    public partial class NeNastavnaLicaForm : Form
    {
        public NeNastavnaLicaForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajNeNastavnoLiceForm forma = new DodajNeNastavnoLiceForm();
            forma.ShowDialog();
            popuniTabeluPodacima();

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaNenastavnogOsoblja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nenastavno lice koje zelite da izmenite!");
                return;
            }

            int idOsobe = Int32.Parse(listaNenastavnogOsoblja.SelectedItems[0].SubItems[0].Text);
            NeNastavnoLiceBasic n = DTOManager.vratiNeNastavnoLice(idOsobe);
            DodajNeNastavnoLiceForm forma = new DodajNeNastavnoLiceForm(n);
            forma.ShowDialog();
            popuniTabeluPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaNenastavnogOsoblja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nenastavno lice koje zelite da obrisete!");
                return;
            }

            int idOsobe = Int32.Parse(listaNenastavnogOsoblja.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrano nenasatvno lice?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiNeNastavnoLice(idOsobe);
                MessageBox.Show("Brisanje uspesno obavljeno!");
                this.popuniTabeluPodacima();
            }
            else
            {

            }
        }

        private void NeNastavnaLicaForm_Load(object sender, EventArgs e)
        {
            this.popuniTabeluPodacima();
        }
        public void popuniTabeluPodacima()
        {
            listaNenastavnogOsoblja.Items.Clear();
            List<NeNastavnoLicePregled> informacije = DTOManager.vratiSvaNeNastavnaLica();
            foreach (NeNastavnoLicePregled n in informacije)
            {
               
                ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Ime, n.Ime_Roditelja, n.Prezime, n.Jmbg, n.Adresa, n.sektor,n.sprema });
                listaNenastavnogOsoblja.Items.Add(item);
            }
            listaNenastavnogOsoblja.Refresh();
        }
    }
}
