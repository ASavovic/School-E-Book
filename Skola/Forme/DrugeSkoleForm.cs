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
    public partial class DrugeSkoleForm : Form
    {
        public DrugeSkoleForm()
        {
            InitializeComponent();
        }

        private void DrugeSkoleForm_Load(object sender, EventArgs e)
        {
            this.PopuniTabeluPodacima();
        }
        public void PopuniTabeluPodacima()
        {
            listaSkola.Items.Clear();
            List<DrugaSKolaPregled> informacije = DTOManager.vratiSveDrugeSkole();
            foreach (DrugaSKolaPregled n in informacije)
            {
               
                ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Naziv});
                listaSkola.Items.Add(item);
            }
            listaSkola.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (btnDodaj.Text == "Dodaj")
            {
                dodaj.Enabled = true;
                btnDodaj.Text = "Potvrdi";
                zaposleni.ResetText();
            }
            else
            {
                if (txbNazivDodaj.Text.Length > 25 || txbNazivDodaj.Text=="")
                {
                    MessageBox.Show("Naziv druge skole je nevalidan!");
                    return;

                }
                string poruka = "Da li zelite da dodate drugu skolu?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);
                if (result == DialogResult.OK)
                {
                    DrugaSKolaBasic skola = new DrugaSKolaBasic();
                    skola.Naziv = txbNazivDodaj.Text;
                    DTOManager.dodajDruguSkolu(skola);
                    MessageBox.Show("Uspesno ste dodali drugu skolu!");
                    PopuniTabeluPodacima();
                    txbNazivDodaj.ResetText();
                    dodaj.Enabled = false;
                    zaposleni.Enabled = false;
                }
                else
                {

                }
                btnDodaj.Text = "Dodaj";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnIzmeni.Text == "Izmeni")
            {
                zaposleni.ResetText();
                if (listaSkola.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite skolu koju zelite da izmenite!");
                    return;
                }
               
                int idSkole = Int32.Parse(listaSkola.SelectedItems[0].SubItems[0].Text);
                DrugaSKolaBasic skola = DTOManager.vratiDruguSkolu(idSkole);
                txbNazivIzmeni.Text = skola.Naziv;
                
                btnIzmeni.Text = "Sacuvaj";
                izmeni.Enabled = true;
                zaposleni.Enabled = false;

            }
           else
            {
                if (listaSkola.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite skolu koju zelite da izmenite!");
                    return;
                }
                if (txbNazivIzmeni.Text.Length > 25 || txbNazivIzmeni.Text=="")
                {
                    MessageBox.Show("Naziv druge skole je nevalidan");
                    return;

                }

                int idSkole = Int32.Parse(listaSkola.SelectedItems[0].SubItems[0].Text);
                string poruka = "Da li zelite da sacuvate izmene?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);
                DrugaSKolaBasic skola = DTOManager.vratiDruguSkolu(idSkole);
                skola.Naziv = txbNazivIzmeni.Text;
                if (result == DialogResult.OK)
                {
                    DTOManager.azurirajDruguSkolu(skola);
                    MessageBox.Show("Azuriranje uspesno obavljeno!");
                    txbNazivIzmeni.ResetText();
                    this.PopuniTabeluPodacima();
                    
                    izmeni.Enabled = false;
                    zaposleni.Enabled = false;

                }
                else
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zaposleni.Enabled = false;
            zaposleni.ResetText();
            if (listaSkola.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite skolu koju zelite da obrisete!");
                return;
            }

            int idSkole = Int32.Parse(listaSkola.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete skolu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
           
            if (result == DialogResult.OK)
            {
                DTOManager.izbrisiSkolu(idSkole);
                MessageBox.Show("Brisanje uspesno obavljeno!");
                
                zaposleni.Enabled = false;
                PopuniTabeluPodacima();

            }
            else
            {

            }
          
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaSkola.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite skolu cije zaposlene zelite da vidite!");
                return;
            }

            int idSkole = Int32.Parse(listaSkola.SelectedItems[0].SubItems[0].Text);
            DrugaSKolaBasic skola = DTOManager.vratiDruguSkolu(idSkole);
            zaposleni.Text = skola.Naziv;
            zaposleni.Enabled = true;
            dodaj.Enabled = false;
            izmeni.Enabled = false;
            listaZaposlenih.Items.Clear();
            List<ZaposleniPregled> informacije = DTOManager.vratiZaposleneUSkoli(idSkole);
            foreach (ZaposleniPregled n in informacije)
            {

                ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Ime,n.Prezime });
                listaZaposlenih.Items.Add(item);
            }
            listaZaposlenih.Refresh();


        }

        private void zaposleni_Enter(object sender, EventArgs e)
        {

        }
      
    }
}
