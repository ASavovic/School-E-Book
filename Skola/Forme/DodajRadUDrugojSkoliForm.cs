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
    public partial class DodajRadUDrugojSkoliForm : Form
    {
        RadUDrugojSkoliBasic rad;
        NastavnoLiceBasic nastavnik;
        public DodajRadUDrugojSkoliForm()
        {
            InitializeComponent();
            
        }
        public DodajRadUDrugojSkoliForm(NastavnoLiceBasic n)
        {
            InitializeComponent();
            rad = new RadUDrugojSkoliBasic();
            btnSacuvaj.Text = "Dodaj";
            this.nastavnik = n;
        }
        public DodajRadUDrugojSkoliForm(RadUDrugojSkoliBasic n)
        {
            InitializeComponent();
            
            btnSacuvaj.Text = "Izmeni";
            this.rad = n;
        }

        private void DodajRadUDrugojSkoliForm_Load(object sender, EventArgs e)
        {
            popuniSelectPolje();
            if (btnSacuvaj.Text=="Izmeni")
            {
                popuniPolja();
            }
            
        }
        public void popuniPolja()
        {
            brojSati.Value = this.rad.brojCasova;
            skole.SelectedText = this.rad.skola.Naziv;
        }
        public void popuniSelectPolje()
        {
            List<DrugaSKolaBasic> listaSkola = DTOManager.vratiSkoleBasic();
            foreach (DrugaSKolaBasic skola in listaSkola)
            {

                skole.Items.Add(skola);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(btnSacuvaj.Text=="Dodaj")
            {
                rad.brojCasova = (int)brojSati.Value;
                rad.skola = (DrugaSKolaBasic)skole.SelectedItem;
                rad.nastavnik = nastavnik;
                DTOManager.dodajRadUdrugojSkoli(rad);
                MessageBox.Show("Uspesno je izvrseno dodavanje!");
                this.Close();
                
            }
            else
            {
                procitajVrednosti();
                DTOManager.azurirajRadUDrugojSkoli(rad);
                MessageBox.Show("Uspesno je izvrseno azuriranje!");
                this.Close();
            }
        }
        public void procitajVrednosti()
        {
            if(skole.SelectedItem!=null)
            {
                this.rad.skola = (DrugaSKolaBasic)skole.SelectedItem;
            }
          
            this.rad.brojCasova = (int)brojSati.Value;
            

        }
    }
}
