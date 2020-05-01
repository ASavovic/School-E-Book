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
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void btnNastavnoLice_Click(object sender, EventArgs e)
        {
            NastavnaLicaForma forma = new NastavnaLicaForma();
            forma.ShowDialog();
        }

        private void btnNeNastavnoLice_Click(object sender, EventArgs e)
        {
            NeNastavnaLicaForm forma = new NeNastavnaLicaForm();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZaposleniForma forma = new ZaposleniForma();
            forma.ShowDialog();
        }

        private void BtnUcenici_Click(object sender, EventArgs e)
        {
            UceniciForma forma = new UceniciForma();
            forma.ShowDialog();
        }

        private void BtnSmerovi_Click(object sender, EventArgs e)
        {
            SmeroviForma forma = new SmeroviForma();
            forma.ShowDialog();
        }

        private void BtnPredmeti_Click(object sender, EventArgs e)
        {
            PredmetiForma forma = new PredmetiForma();
            forma.ShowDialog();

        }

        private void btnDrugeSkole_Click(object sender, EventArgs e)
        {
            DrugeSkoleForm forma = new DrugeSkoleForm();
            forma.ShowDialog();
        }
    }
}
