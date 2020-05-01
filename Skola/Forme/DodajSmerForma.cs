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
    public partial class DodajSmerForma : Form
    {
        private SmerBasic smer;
        public DodajSmerForma()
        {
            InitializeComponent();
            smer = new SmerBasic();
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!validacija())
                return;
            smer.Naziv = this.txbNaziv.Text;
            smer.MaxUcenika = (int)this.brojMaxU.Value;
            DTOManager.dodajSmer(smer);
            MessageBox.Show("Uspesno je izvrseno dodavanje smera!");
            this.Close();
        }
        private bool validacija()
        {
            if (txbNaziv.Text.Length > 15 || txbNaziv.Text=="")
            {
                MessageBox.Show("Naziv smera je nevalidan!");
                return false;

            }
           
            else return true;

        }

        
    }
}
