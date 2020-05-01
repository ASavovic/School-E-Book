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
    public partial class ZaposleniForma : Form
    {
        public int brojZaposlenih = 0;
        public int brojNastavnika = 0;
        public int brojOsoblja = 0;
        public ZaposleniForma()
        {
            InitializeComponent();
        }

        private void ZaposleniForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            listaZaposlenih.Items.Clear();
            List<NastavnoLicePregled> informacije01 = DTOManager.vratiSvaNastavnaLica();
            List<NeNastavnoLicePregled> informacije02 = DTOManager.vratiSvaNeNastavnaLica();
            foreach (NastavnoLicePregled n in informacije01)
            {
               
                ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Ime, n.Ime_Roditelja, n.Prezime, n.Jmbg, n.Adresa});
                listaZaposlenih.Items.Add(item);
                this.brojNastavnika++;
            }
            foreach (NeNastavnoLicePregled n in informacije02)
            {

                ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Ime, n.Ime_Roditelja, n.Prezime, n.Jmbg, n.Adresa });
                listaZaposlenih.Items.Add(item);
                this.brojOsoblja++;
            }
            this.brojZaposlenih = this.brojNastavnika + this.brojOsoblja;
            txbNastavnici.Text = this.brojNastavnika.ToString();
            txbOsoblje.Text = this.brojOsoblja.ToString();
            txbUkupno.Text = this.brojZaposlenih.ToString();
            listaZaposlenih.Refresh();

        }
    }
}
