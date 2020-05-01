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
    public partial class PredmetiForm : Form
    {
        public NastavnoLiceBasic nastavnik;
        public PredmetBasic predmet;
        public PredmetiForm()
        {
            InitializeComponent();
        }
        public PredmetiForm(NastavnoLiceBasic n)
        {
            InitializeComponent();
            this.nastavnik = n;
            predmet = new PredmetBasic();
            
        }
        public void popuniTabeluPodacima()
        {
            listaPredmeta.Items.Clear();
            List<PredmetPregled> informacije = DTOManager.vratiSvePredmete();
            foreach (PredmetPregled n in informacije)
            {
                if (n.Smer.Count != 0)
                {
                    foreach(String naziv in n.Smer)
                    {
                        ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Naziv, n.Godina,naziv });
                        listaPredmeta.Items.Add(item);
                    }
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[] { n.Id.ToString(), n.Naziv, n.Godina, "Još uvek nije određen smer." });
                    listaPredmeta.Items.Add(item);

                }

                
            }
            listaPredmeta.Refresh();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PredmetiForm_Load(object sender, EventArgs e)
        {
            popuniTabeluPodacima();
            this.Text = $"DODAVANJE ANGAZMANA {nastavnik.Ime} {nastavnik.Ime_Roditelja[0]} {nastavnik.Prezime}";
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (listaPredmeta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate da selektujete predmet kako biste dodali angazman!");
                return;
            }

            int idPredmeta = Int32.Parse(listaPredmeta.SelectedItems[0].SubItems[0].Text);
            PredmetBasic p = DTOManager.vratiPredmet(idPredmeta);

            DateTime datumOdKada = this.datumOd.Value;
            DateTime? datumDoKada=null;
            if (chbDatumDo.Checked == false)
                datumDoKada = this.datumDo.Value;
           

            string poruka = "Da li ste sigurni da zelite da dodati novi angazman?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                AngazmanBasic angazman = new AngazmanBasic();
                angazman.Nastavnik = this.nastavnik;
                angazman.Predmet = p;
                angazman.DatumOd = datumOdKada;
                angazman.DatumDo = datumDoKada;
                DTOManager.dodajAngazman(angazman);
                MessageBox.Show("Uspesno ste dodali novi angazman!");
                this.Close();
            }
            else
            {

            }


            

          
            
        }

        private void chbChecked_onChange(object sender, EventArgs e)
        {
            if (chbDatumDo.Checked == true)
            {
                datumDo.Enabled = false;
            }
            else
                datumDo.Enabled = true;
        }
        
        
    }
}
