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
    public partial class UpdateSmer : Form
    {
        private SmerBasic smer;
        public UpdateSmer(SmerBasic s)
        {
            InitializeComponent();
            smer = s;
        }

        private void BtnAzuriraj_Click(object sender, EventArgs e)
        {

            if (!validacija())
                return;
            string poruka = "Da li zelite da izvrsite izmene?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.smer.Naziv = txbNaziv.Text;
                this.smer.MaxUcenika = (int)brojMaxU.Value;
               
                DTOManager.azurirajSmer(this.smer);
                MessageBox.Show("Uspesno izvrseno azuriranje!");
                this.Close();
            }
            else
            {

            }
        }
        private bool validacija()
        {
            if (txbNaziv.Text.Length > 15 || txbNaziv.Text == "")
            {
                MessageBox.Show("Naziv smera je nevalidan!");
                return false;

            }

            else return true;

        }
        private void UpdateSmer_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"IZMENA SMERA {this.smer.Naziv.ToUpper()}";
        }
        public void popuniPodacima()
        {
            txbNaziv.Text = this.smer.Naziv;
            brojMaxU.Value = this.smer.MaxUcenika;
        }
    }
}
