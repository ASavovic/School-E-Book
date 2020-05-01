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
    public partial class DodajStarateljaForma : Form
    {
       private  UcenikBasic ucenik;
        public DodajStarateljaForma(UcenikBasic u )
        {
            InitializeComponent();
            ucenik = u;
        }

        private void DodajStarateljaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"DODAVANJE STARATELJA UCENIKU {ucenik.Ime.ToUpper()} {ucenik.Prezime.ToUpper()}";
        }
        public void popuniPodacima()
        {

            listaStaratelja.Items.Clear();
            List<StarateljPregled> informacije = DTOManager.vratiSveStarateljeUcenika(ucenik.Id);
            foreach (StarateljPregled n in informacije)
            {
                String norma = "";
                if (n.clanSaveta == 1)
                    norma = "Da";
                else
                    norma = "Ne";
                ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Ime,  n.Prezime, norma });
                listaStaratelja.Items.Add(item);
            }
            listaStaratelja.Refresh();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!validacija())
                return;
            String ime = txbIme.Text;
            String prezime = txbPrezime.Text;
            int clan = 0;
            if(chBClanRodSaveta.Checked==true)
            {
                clan = 1;
            }
            StarateljBasic s = new StarateljBasic(ime, prezime, clan);
            string poruka = "Da li zelite da dodate staratelja?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.dodajStaratelja(ucenik,s);
            }
            else
            {

            }
            this.popuniPodacima();
            txbIme.ResetText();
            txbPrezime.ResetText();
        }
        public bool validacija()
        {
            if (txbIme.Text == "" || txbIme.Text.Length > 15)
            {
                MessageBox.Show("Nevalidan unos imena!");
                return false;

            }
            else if (txbPrezime.Text == "" || txbPrezime.Text.Length > 20)
            {
                MessageBox.Show("Nevalidan unos prezimena!");
                return false;

            }
           
            return true;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaStaratelja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite staratelja koga zelite da obrisete!");
                return;
            }

            int idStaratelja = Int32.Parse(listaStaratelja.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog staratelja?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiStaratelja(idStaratelja);
            }
            else
            {

            }
            popuniPodacima();
            txbIme.ResetText();
            txbPrezime.ResetText();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (!validacija())
                return;
            if (listaStaratelja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite staratelja koga zelite da izmenite!");
                return;
            }

            int idStaratelja = Int32.Parse(listaStaratelja.SelectedItems[0].SubItems[0].Text);

            if (btnIzmeni.Text == "Izmeni")
            {
                 StarateljPregled s = DTOManager.vratiStaratelja(idStaratelja);
                 txbIme.Text = s.Ime;
                 txbPrezime.Text = s.Prezime;
                if (s.clanSaveta == 1)
                    chBClanRodSaveta.Checked = true;
                else
                    chBClanRodSaveta.Checked = false;
                btnIzmeni.Text = "Sacuvaj izmene";
            }
            else
            {


                String ime = txbIme.Text;
                String prezime = txbPrezime.Text;
                int clan = 0;
                if (chBClanRodSaveta.Checked == true)
                {
                    clan = 1;
                }
                StarateljPregled s = new StarateljPregled(idStaratelja, ime, prezime, clan);
                string poruka = "Da li zelite da izmenite izabranog staratelja?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);
                if (result == DialogResult.OK)
                {
                    DTOManager.azurirajStaratelja(s);
                }
                else
                {

                }
                btnIzmeni.Text = "Izmeni";
                popuniPodacima();
                txbIme.ResetText();
                txbPrezime.ResetText();
            }

        }

        private void btnDodajTelefon_Click(object sender, EventArgs e)
        {
            if(txbTelefon.Text.Length>15 || txbTelefon.Text=="")
            {
                MessageBox.Show("Nevalidan unos broja telefona!");
                return;
            }
            if (listaStaratelja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite staratelja kome zelite da dodate broj telefona!");
                return;
            }

            int idStaratelja = Int32.Parse(listaStaratelja.SelectedItems[0].SubItems[0].Text);

            
            TelefonPregled t = new TelefonPregled(idStaratelja, txbTelefon.Text);
            DTOManager.dodajTelefon(t);
            MessageBox.Show("Uspesno ste dodali novi broj telefona!");

            popuniTelefone();
            txbTelefon.ResetText();

            


        }

        private void btnPrikaziTelefone_Click(object sender, EventArgs e)
        {
            grbDodatniPodaci.Enabled = true;
            popuniTelefone();
           



        }
        public void popuniTelefone()
        {
            if (listaStaratelja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite staratelja cije brojeve telefona zelite da vidite!");
                return;
            }

            int idStaratelja = Int32.Parse(listaStaratelja.SelectedItems[0].SubItems[0].Text);
            StarateljPregled staratelj = DTOManager.vratiStaratelja(idStaratelja);
            grbDodatniPodaci.Text = $"{staratelj.Ime} {staratelj.Prezime} Telefoni";
            listaTelefona.Items.Clear();
            List<TelefonBasic> informacije = DTOManager.vratiTelefone(idStaratelja);
            foreach (TelefonBasic n in informacije)
            {

                ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.BrojTelefona });
                listaTelefona.Items.Add(item);
            }
            listaTelefona.Refresh();
        }

        private void onemoguciDodavanje(object sender, EventArgs e)
        {
            grbDodatniPodaci.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaTelefona.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite broj telefona koji zelite da obrisete!");
                return;
            }

            int idTelefona = Int32.Parse(listaTelefona.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da izbrisete broj telefona?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiTelefon(idTelefona);
                MessageBox.Show("Uspesno ste izbrisali broj telefona!");
                popuniTelefone();
            }
            else
            {

            }

        }

        private void listaTelefona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click_1(object sender, EventArgs e)
        {
            if (listaStaratelja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite staratelja kog zelite da obrisete!");
                return;
            }

            int idStaratelja = Int32.Parse(listaStaratelja.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da izbrisete staratelja?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiStaratelja(idStaratelja);
                MessageBox.Show("Uspesno ste izbrisali staratelja!");
                popuniPodacima();
            }
            else
            {

            }

        }
    }
}
