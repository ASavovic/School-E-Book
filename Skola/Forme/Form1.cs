using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Linq;
using Skola.Entiteti;

namespace Skola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Vratipredmet_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Predmet predmet = s.Load<Skola.Entiteti.Predmet>(2);
            MessageBox.Show("PREDMET ID: "+predmet.Id+" "+"NAZIV: "+predmet.Naziv);

            s.Close();
        }

        private void ObrisiPredment_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Predmet p = s.Load<Skola.Entiteti.Predmet>(45);
            
            s.Delete(p);

            MessageBox.Show("Predmet sa id-jem 45 je obrisan.");
            s.Flush();
            s.Close();
        }

        private void Azurirajpredmet_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Predmet p = s.Load<Skola.Entiteti.Predmet>(3);
            p.Naziv = "Astronomija";
            p.Godina = "prva";
            s.Merge(p);
            s.Flush();
            s.Close();
            MessageBox.Show("Predmet je azuriran.");
        }

        private void KreirajPredmet_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Predmet p = new Skola.Entiteti.Predmet
            {
                Godina = "prva",
                Naziv = "Muzicko",
            };
            s.Save(p);

            MessageBox.Show("Predmet je dodat.");
            s.Flush();
            s.Close();


        }

        private void PrikaziSvePredmete_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IEnumerable<Skola.Entiteti.Predmet> predmeti = from o in s.Query<Skola.Entiteti.Predmet>()
                                                           select o;
            foreach (Skola.Entiteti.Predmet o in predmeti)
            {
                MessageBox.Show("PREDMET: "+o.Naziv+" ("+o.Godina+" godina)");
            }

            s.Close();
        }

        private void KreirajUcenika_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Ucenik u = new Skola.Entiteti.Ucenik
            {
                Ime = "Marko",
                Prezime = "Dragojevic",
                Razred = "prvi",
                DatumUpisa = new DateTime(2015, 09, 01),
                Adresa = "Vuka Karadzica 15",
                SmerUcenika = s.Load<Skola.Entiteti.Smer>(3)

            };
            
            s.Save(u);

            MessageBox.Show("Ucenik Marko Dragojevic uspesno dodat.");
            s.Flush();
            s.Close();
        }

        private void VratiUcenika_Click(object sender, EventArgs e)
        {
            Skola.Entiteti.Ucenik ucenik = new Skola.Entiteti.Ucenik();
            
           
                ISession s = DataLayer.GetSession();
                ucenik = s.Load<Skola.Entiteti.Ucenik>(2);
                MessageBox.Show(ucenik.Ime + " " + ucenik.Prezime);
                s.Flush();
                s.Close();

        }

        private void ObrisiUcenika_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Ucenik u = s.Load<Skola.Entiteti.Ucenik>(22);

            s.Delete(u);

            MessageBox.Show("Ucenik sa id-jem 22 je obrisan.");
            s.Flush();
            s.Close();
        }

        private void PrikaziSveUcenike_Click(object sender, EventArgs e)
        {

            ISession s = DataLayer.GetSession();
            IEnumerable<Skola.Entiteti.Ucenik> ucenici = from o in s.Query<Skola.Entiteti.Ucenik>()
                                                         select o;
            foreach (Skola.Entiteti.Ucenik o in ucenici)
            {
                MessageBox.Show(o.Ime+" "+o.Prezime);
            }
            s.Close();
        }

        private void VratiUcenikuOcene_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Ucenik ucenik = s.Load<Skola.Entiteti.Ucenik>(5);



            foreach (Skola.Entiteti.Ocena o in ucenik.ListaOcena)
            {
                
                MessageBox.Show(o.Ucenik.Ime + " " + o.Ucenik.Prezime+" je dobio "+o.NumerickaVrednost+" iz predmeta "+o.Predmet.Naziv+".");
            }
           
            s.Flush();
            s.Close();

        }

        private void VratiSmerUcenika_Click(object sender, EventArgs e)
        {

            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Ucenik u = s.Load<Skola.Entiteti.Ucenik>(1);

            MessageBox.Show("Ucenik: " + u.Ime + " " + u.Prezime+" - smer: "+u.SmerUcenika.Naziv+".");
            s.Flush();
            s.Close();
        }

        private void VratiStarateljeUcenika_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Ucenik u = s.Load<Skola.Entiteti.Ucenik>(1);


            foreach (Skola.Entiteti.Staratelj o in u.ListaStaratelja)
            {

                MessageBox.Show(o.Ime + " " + o.Prezime + " je staratelj uceniku: " + u.Ime+ " " + u.Prezime+".");
            }
            s.Flush();
            s.Close();
        }

        private void AzurirajUcenika_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Ucenik u = s.Load<Skola.Entiteti.Ucenik>(5);
            u.Ime = "Aleksandar";
            u.Prezime ="Simic";
            MessageBox.Show("Azuriran je ucenik sa id-jem: 5.");
            s.SaveOrUpdate(u);
            s.Flush();
            s.Close();
        }

        private void KreirajSmer_Click(object sender, EventArgs e)
        {

            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Smer sm = new Skola.Entiteti.Smer();
            sm.Naziv = "astroloski";
            sm.MaxUcenika = 25;
            MessageBox.Show("Dodat je novi smer.");
            s.SaveOrUpdate(sm);
            s.Flush();
            s.Close();
        }

        private void AzurirajSmer_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Smer sm = s.Load<Skola.Entiteti.Smer>(2);
            sm.Naziv = "bioloski";
            sm.MaxUcenika = 60;
            s.SaveOrUpdate(sm);
            MessageBox.Show("Azuriranje smera je uspesno obavljeno.");
            
            s.Flush();
            s.Close();
        }

        private void ObrisiSmer_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Smer sm = s.Load<Skola.Entiteti.Smer>(22);
            s.Delete(sm);
            MessageBox.Show("Obrisan je smer.");
           
            s.Flush();
            s.Close();
        }

        private void VratiSmer_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Smer smer = s.Load<Skola.Entiteti.Smer>(2);
            MessageBox.Show(smer.Naziv+" ("+smer.MaxUcenika+")");
            s.Flush();
            s.Close();

        }

        private void KreirajStaratelja_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Staratelj r = new Skola.Entiteti.Staratelj();
            r.Ime = "Nenad";
            r.Prezime = "Petrovic";
            r.ClanSaveta = 0;
          
            s.Save(r);
            MessageBox.Show("Staratelj uspesno kreiran.");
            s.Flush();
            s.Close();
        }

        private void ObrisiStaratelja_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Staratelj u = s.Load<Skola.Entiteti.Staratelj>(23);
            s.Delete(u);
            MessageBox.Show("Staratelj uspesno obrisan.");
            
            s.Flush();
            s.Close();
        }

        

        private void AzurirajStaratelja_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Staratelj r = s.Load<Skola.Entiteti.Staratelj>(7);
            r.Ime = "Rajko";
            r.Prezime = "Trajkovic";
            r.ClanSaveta = 0;

           
            s.SaveOrUpdate(r);
            MessageBox.Show("Staratelj uspesno azuriran.");
            s.Flush();
            s.Close();
        }

        private void VratiListuDece_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            Staratelj r = s.Load<Staratelj>(1);
            foreach(Ucenik u in r.ListaDece)
            MessageBox.Show(u.Ime + " " +u.Prezime+" - staratelj: "+r.Ime+" "+r.Prezime);
            s.Close();
        }

        private void VratiListuTelefona_Click(object sender, EventArgs e)
        {

            ISession s = DataLayer.GetSession();

            Staratelj r = s.Load<Staratelj>(7);
            foreach (Telefoni t in r.ListaTelefona)
                MessageBox.Show(r.Ime + " " + r.Prezime+" broj telefona: "+t.BrojTelefona+"." );
            s.Close();
        }

        private void VratiClanoveSaveta_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IEnumerable<Skola.Entiteti.Staratelj> staratelji = from o in s.Query<Skola.Entiteti.Staratelj>()
                                                         select o;
            foreach (Skola.Entiteti.Staratelj o in staratelji)
            {
                if(o.ClanSaveta==1)
                MessageBox.Show(o.Ime + " " + o.Prezime+" je clan saveta.");
            }
        }

        private void KreirajOcenu_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Ocena ocena = new Ocena();


            ocena.DatumDobijanja = new DateTime(2019, 5,1);
            ocena.NumerickaVrednost = 4;
            ocena.Ucenik = s.Load<Ucenik>(2);
            ocena.Predmet = s.Load<Predmet>(22);
            ocena.Opis = "vrlo dobar";
            MessageBox.Show("Ocena kreirana.");
            s.SaveOrUpdate(ocena);
            s.Flush();
            s.Close();
        }

        private void AzurirajOcenu_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Ocena o = s.Load<Ocena>(5);
            o.NumerickaVrednost = 5;
            o.Opis = "odlican";
            s.SaveOrUpdate(o);
            MessageBox.Show("Azurirana Ocena.");
             
            s.Flush();
            s.Close();
        }

        private void ObrisiOcenu_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Ocena o = s.Load<Ocena>(28);
            s.Delete(o);
            MessageBox.Show("Ocena je obrisana.");
            

            s.Flush();
            s.Close();
        }

        private void VartiOcenu_Click(object sender, EventArgs e)
        {

            ISession s = DataLayer.GetSession();

            Ocena o = s.Load<Ocena>(5);
            MessageBox.Show(o.Predmet.Naziv + " " + o.NumerickaVrednost);
            s.Close();
        
    }

        private void VratiListuDrugihSkola_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IEnumerable<Skola.Entiteti.DrugaSkola> skole = from o in s.Query<Skola.Entiteti.DrugaSkola>()
                                                               select o;
            foreach (Skola.Entiteti.DrugaSkola o in skole)
            {
                
                    MessageBox.Show("Skola "+o.Naziv);
            }
        }

        private void VratiBrojSati_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            Radi r = s.Load<Radi>(1);

            MessageBox.Show("Nastavnik "+r.Nastavnik.LIme+" "+r.Nastavnik.Prezime+" radi u skoli "
                +r.Skola.Naziv+" sa brojem casova "+r.BrojCasova+".");
            s.Close();
        }

        private void VratiStaratelja_Click(object sender, EventArgs e)
        {
            Skola.Entiteti.Staratelj rod = new Skola.Entiteti.Staratelj();

            ISession s = DataLayer.GetSession();
            rod = s.Load<Skola.Entiteti.Staratelj>(5);
           s.Flush();

            MessageBox.Show(rod.Ime + " " + rod.Prezime);
            s.Close();
        }

        private void VratiSmerove_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Predmet p = s.Load<Skola.Entiteti.Predmet>(1);
            foreach (Skola.Entiteti.Smer o in p.ListaSmerova)
            {
                MessageBox.Show("Predmet "+p.Naziv+" se slusa na smeru: "+o.Naziv);
            }

            s.Close();
        }
         
        

        private void VratiNastavnike_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Skola.Entiteti.Predmet p = s.Load<Skola.Entiteti.Predmet>(1);
            foreach (Skola.Entiteti.Angazman o in p.ListaNastavnika)
            {
                MessageBox.Show(o.Nastavnik.LIme+" "+o.Nastavnik.Prezime+" je angazovan na predmetu "+p.Naziv);
            }
           

           s.Close();
        }

        private void VratiListuPredmeta_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Smer smer = s.Load<Skola.Entiteti.Smer>(3);
            foreach(Skola.Entiteti.Predmet p in smer.ListaPredmeta)
            MessageBox.Show(p.Naziv + " na smeru " + smer.Naziv+" godina: "+p.Godina);
            s.Flush();
            s.Close();
        }

        private void VratiListuUcenika_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Smer smer = s.Load<Skola.Entiteti.Smer>(3);
            foreach (Skola.Entiteti.Ucenik u in smer.ListaUcenika)
                MessageBox.Show(u.Ime+" "+u.Prezime + " na smeru " + smer.Naziv);
            s.Flush();
            s.Close();
        }

        private void VratiNastavnoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                NastavnoOsoblje n = s.Load<NastavnoOsoblje>(2);
                MessageBox.Show(n.LIme + " " + n.Prezime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void AzurirajZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Zaposleni z = s.Load<Zaposleni>(1);

                z.ImeRoditelja = "Goran";
                s.SaveOrUpdate(z);
                MessageBox.Show("Ime roditelja je azurirano zaposlenom sa id-jem 1.");
                

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void ObrisiZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();
                Skola.Entiteti.Zaposleni nastavnik = s.Load<Skola.Entiteti.Zaposleni>(62);
                
                s.Delete(nastavnik);

                MessageBox.Show("Zaposleni sa id-jem 62 je uspesno obrisan.");
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void VratiNenastavnoL_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                

                NeNastavnoOsoblje n = s.Load<NeNastavnoOsoblje>(7);
                MessageBox.Show(n.LIme + " " + n.Prezime);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void KreirajZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.NastavnoOsoblje z = new Entiteti.NastavnoOsoblje();

                z.LIme = "Marko";
                z.Prezime = "Mandic";
                z.ImeRoditelja = "Dragan";
                z.Jmbg = "0213455678457";
                z.Adresa = "Nemanjina br. 8";
                z.PunaNorma = 1;
                z.DatumRodjenja = new DateTime(1991, 01, 02);
                MessageBox.Show("Kreiran zaposleni");

                s.SaveOrUpdate(z);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        private void VratiZaposlene_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IEnumerable<Skola.Entiteti.Zaposleni> zaposleni = from o in s.Query<Skola.Entiteti.Zaposleni>()
                                                                    select o;
            foreach (Skola.Entiteti.Zaposleni o in zaposleni)
            {
                MessageBox.Show(o.LIme + " " + o.Prezime);
            }

            s.Close();
        }

        private void VratiSveNastavnike_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Skola.Entiteti.NastavnoOsoblje> nastavnici = from o in s.Query<Skola.Entiteti.NastavnoOsoblje>()
                                                                         select o;
                foreach (Skola.Entiteti.NastavnoOsoblje o in nastavnici)
                {
                    MessageBox.Show(o.LIme + " " + o.Prezime);
                }

                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
