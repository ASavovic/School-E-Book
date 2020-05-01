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
    public partial class SmeroviForma : Form
    {
        public SmeroviForma()
        {
            InitializeComponent();
        }

        private void BtnDodajSmer_Click(object sender, EventArgs e)
        {
            DodajSmerForma forma = new DodajSmerForma();
            forma.ShowDialog();
            PopuniTabeluPodacima();
        }

        private void SmeroviForma_Load(object sender, EventArgs e)
        {
            this.PopuniTabeluPodacima();
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnObrisiSmer_Click(object sender, EventArgs e)
        {
            if (listaSmerova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite smer koji zelite da obrisete!");
                return;
            }
            int idSmera = Int32.Parse(listaSmerova.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani smer?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiSmer(idSmera);
                MessageBox.Show("Brisanje uspesno obavljeno!");
                this.PopuniTabeluPodacima();
            }
            else
            {

            }


        }

        private void BtnIzmeniSmer_Click(object sender, EventArgs e)
        {
            if (listaSmerova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite smer cije podatke zelite da izmenite!");
                return;
            }
            int idSmera = Int32.Parse(listaSmerova.SelectedItems[0].SubItems[0].Text);
            SmerBasic ob = DTOManager.vratiSmer(idSmera);
            UpdateSmer forma = new UpdateSmer(ob);
            forma.ShowDialog();
            this.PopuniTabeluPodacima();
        }
    }
}
