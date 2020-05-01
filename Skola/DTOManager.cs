using NHibernate;
using NHibernate.Linq;
using Skola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Skola
{
    public class DTOManager
    {
        #region NastavnaLica
        public static List<NastavnoLicePregled> vratiSvaNastavnaLica()
        {
            List<NastavnoLicePregled> nastavnici = new List<NastavnoLicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<NastavnoOsoblje> nastavnoOsoblje = from o in s.Query<NastavnoOsoblje>()
                                                               select o;

                foreach (NastavnoOsoblje o in nastavnoOsoblje)
                {


                    nastavnici.Add(new NastavnoLicePregled(o.Id, o.LIme, o.ImeRoditelja, o.Prezime, o.Jmbg, o.Adresa, o.PunaNorma));


                }
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return nastavnici;
        }
        public static NastavnoLiceBasic vratiNastavnoLice(int id)
        {
            NastavnoLiceBasic ob = new NastavnoLiceBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                NastavnoOsoblje o = s.Load<NastavnoOsoblje>(id);
                ob = new NastavnoLiceBasic(o.Id, o.LIme, o.ImeRoditelja, o.Prezime, o.Jmbg, o.Adresa, o.PunaNorma, o.DatumRodjenja);

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ob;
        }

        public static NastavnoLiceBasic azurirajNastavnoLice(NastavnoLiceBasic n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NastavnoOsoblje o = s.Load<NastavnoOsoblje>(n.Id);
                o.LIme = n.Ime;
                o.ImeRoditelja = n.Ime_Roditelja;
                o.Prezime = n.Prezime;
                o.Jmbg = n.Jmbg;
                o.Adresa = n.Adresa;
                o.PunaNorma = n.PunaNorma;
                if(o.PunaNorma==1)
                {
                    //nastavnik sada ima punu normu i brisemo rad u drugim skolama
                    IEnumerable<Radi> drugeSkole = from radnik in s.Query<Radi>()
                                                   where radnik.Nastavnik.Id==o.Id
                                                   select radnik;
                    List<Radi> skole = drugeSkole.ToList<Radi>();
                    int count = skole.Count();
                    for(int i=0;i<count;i++)
                    {
                        s.Delete(skole[i]);

                    }
                    
                    
                }
                o.DatumRodjenja = n.DatumRodjenja;

                s.Update(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return n;
        }
        public static void obrisiNastavnoLice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NastavnoOsoblje o = s.Load<NastavnoOsoblje>(id);
                s.Delete(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void dodajNastavnoLice(NastavnoLiceBasic n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NastavnoOsoblje o = new NastavnoOsoblje();
                o.LIme = n.Ime;
                o.ImeRoditelja = n.Ime_Roditelja;
                o.Prezime = n.Prezime;
                o.Jmbg = n.Jmbg;
                o.Adresa = n.Adresa;
                o.PunaNorma = n.PunaNorma;
                o.DatumRodjenja = n.DatumRodjenja;
                s.SaveOrUpdate(o);


                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        #endregion

        #region NeNastavnoLice
        public static List<NeNastavnoLicePregled> vratiSvaNeNastavnaLica()
        {
            List<NeNastavnoLicePregled> osoblje = new List<NeNastavnoLicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<NeNastavnoOsoblje> neNastavnoOsoblje = from o in s.Query<NeNastavnoOsoblje>()
                                                                   select o;

                foreach (NeNastavnoOsoblje o in neNastavnoOsoblje)
                {


                    osoblje.Add(new NeNastavnoLicePregled(o.Id, o.LIme, o.ImeRoditelja, o.Prezime, o.Jmbg, o.Adresa, o.Sektor, o.Sprema));


                }
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return osoblje;
        }
        public static NeNastavnoLiceBasic vratiNeNastavnoLice(int id)
        {
            NeNastavnoLiceBasic ob = new NeNastavnoLiceBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                NeNastavnoOsoblje o = s.Load<NeNastavnoOsoblje>(id);
                ob = new NeNastavnoLiceBasic(o.Id, o.LIme, o.ImeRoditelja, o.Prezime, o.Jmbg, o.Adresa, o.Sektor, o.Sprema, o.DatumRodjenja);

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ob;
        }

        public static NeNastavnoLiceBasic azurirajNeNastavnoLice(NeNastavnoLiceBasic n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NeNastavnoOsoblje o = s.Load<NeNastavnoOsoblje>(n.Id);
                o.LIme = n.Ime;
                o.ImeRoditelja = n.Ime_Roditelja;
                o.Prezime = n.Prezime;
                o.Jmbg = n.Jmbg;
                o.Adresa = n.Adresa;
                o.Sektor = n.sektor;
                o.Sprema = n.sprema;
                o.DatumRodjenja = n.DatumRodjenja;

                s.Update(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return n;
        }
        public static void obrisiNeNastavnoLice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NeNastavnoOsoblje o = s.Load<NeNastavnoOsoblje>(id);
                s.Delete(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void dodajNeNastavnoLice(NeNastavnoLiceBasic n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NeNastavnoOsoblje o = new NeNastavnoOsoblje();
                o.LIme = n.Ime;
                o.ImeRoditelja = n.Ime_Roditelja;
                o.Prezime = n.Prezime;
                o.Jmbg = n.Jmbg;
                o.Adresa = n.Adresa;
                o.Sprema = n.sprema;
                o.Sektor = n.sektor;
                o.DatumRodjenja = n.DatumRodjenja;
                s.SaveOrUpdate(o);


                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }

        


        #endregion

        #region RadUDrugimSkolama

        public static List<RadUDrugojSkoliPregled> vratiRadUDrugimSkolama(int id)
        {
            List<RadUDrugojSkoliPregled> skole = new List<RadUDrugojSkoliPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Radi> listaSkola = from o in s.Query<Radi>()
                                               where o.Nastavnik.Id == id
                                               select o;

                foreach (Radi o in listaSkola)
                {


                    skole.Add(new RadUDrugojSkoliPregled(o.Id, o.Skola, o.BrojCasova));


                }
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return skole;
        }

        public static DrugaSKolaBasic vratiDruguSkolu(int id)
        {
            DrugaSKolaBasic ob = new DrugaSKolaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                DrugaSkola o = s.Load<DrugaSkola>(id);
                ob = new DrugaSKolaBasic(o.Id, o.Naziv);

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ob;
        }
        public static RadUDrugojSkoliBasic vratiRadUSkoli(int id)
        {
            RadUDrugojSkoliBasic ob = new RadUDrugojSkoliBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Radi o = s.Load<Radi>(id);
                DrugaSKolaBasic skola = DTOManager.vratiDruguSkolu(o.Skola.Id);
                NastavnoLiceBasic nastavnik = DTOManager.vratiNastavnoLice(o.Nastavnik.Id);
                ob = new RadUDrugojSkoliBasic(o.Id, skola, o.BrojCasova, nastavnik);

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ob;

        }
        public static List<DrugaSKolaBasic> vratiSkoleBasic()
        {

            List<DrugaSKolaBasic> skole = new List<DrugaSKolaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<DrugaSkola> listaSkola = from o in s.Query<DrugaSkola>()
                                                     select o;

                foreach (DrugaSkola o in listaSkola)
                {


                    skole.Add(new DrugaSKolaBasic(o.Id, o.Naziv));


                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return skole;

        }
        public static List<DrugaSKolaPregled> vratiSveDrugeSkole()
        {
            List<DrugaSKolaPregled> skole = new List<DrugaSKolaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<DrugaSkola> listaSkola = from o in s.Query<DrugaSkola>()
                                                     select o;

                foreach (DrugaSkola o in listaSkola)
                {


                    skole.Add(new DrugaSKolaPregled(o.Id, o.Naziv));


                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return skole;
        }

        public static RadUDrugojSkoliBasic azurirajRadUDrugojSkoli(RadUDrugojSkoliBasic n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Radi o = s.Load<Radi>(n.id);
                o.Skola = s.Load<DrugaSkola>(n.skola.Id);
                o.BrojCasova = n.brojCasova;
                o.Nastavnik = s.Load<NastavnoOsoblje>(n.nastavnik.Id);
                s.Update(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return n;
        }
        public static void obrisiRadUdrugojSkoli(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Radi o = s.Load<Radi>(id);
                s.Delete(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void dodajRadUdrugojSkoli(RadUDrugojSkoliBasic n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Radi o = new Radi();
                o.Nastavnik = s.Load<NastavnoOsoblje>(n.nastavnik.Id);
                o.Skola = s.Load<DrugaSkola>(n.skola.Id);
                o.BrojCasova = n.brojCasova;
                s.SaveOrUpdate(o);


                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        #endregion

        #region Angazman
        public static List<AngazmanPregled> vratiSveAngazmaneNastavnika(NastavnoLiceBasic n)
        {
            List<AngazmanPregled> angazmanPregledi = new List<AngazmanPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Angazman> angazmani = from a in s.Query<Angazman>()
                                                  where a.Nastavnik.Id == n.Id
                                                  select a;


                foreach (Angazman a in angazmani)
                {


                    angazmanPregledi.Add(new AngazmanPregled(a.Id, a.DatumOd, a.DatumDo, a.Predmet));


                }
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return angazmanPregledi;
        }
        public static List<PredmetPregled> vratiSvePredmete()
        {
            List<PredmetPregled> predmeti = new List<PredmetPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predmet> angazmani = from p in s.Query<Predmet>()
                                                 select p;


                foreach (Predmet a in angazmani)
                {

                    PredmetPregled p = new PredmetPregled(a.Id, a.Naziv, a.Godina);
                    if (a.ListaSmerova != null)
                    {
                        foreach (Smer smer in a.ListaSmerova)
                            p.Smer.Add(smer.Naziv);
                    }
                    predmeti.Add(p);


                }
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return predmeti;
        }
        public static PredmetBasic vratiPredmet(int id)
        {
            PredmetBasic ob = new PredmetBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet o = s.Load<Predmet>(id);
                ob = new PredmetBasic(o.Id, o.Naziv, o.Godina);

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ob;
        }
        public static void dodajAngazman(AngazmanBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Angazman o = new Angazman();
                o.DatumOd = a.DatumOd;
                o.DatumDo = a.DatumDo;
                o.Nastavnik = s.Load<NastavnoOsoblje>(a.Nastavnik.Id);
                o.Predmet = s.Load<Predmet>(a.Predmet.Id);



                s.SaveOrUpdate(o);


                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void obrisiAngazman(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Angazman o = s.Load<Angazman>(id);
                s.Delete(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static AngazmanBasic azurirajAngazman(AngazmanBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Angazman o = s.Load<Angazman>(a.Id);
                o.DatumOd = a.DatumOd;
                o.DatumDo = a.DatumDo;
                s.Update(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return a;
        }
        public static List<AngazmanBasic> vratiNastavnikeNaPredmetu(int id)
        {
            List<AngazmanBasic> angazmani = new List<AngazmanBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                
                IEnumerable<Angazman> informacije= from o in s.Query<Angazman>()
                                                   where o.Predmet.Id==id
                                                   select o;
                foreach(Angazman a in informacije)
                {
                    NastavnoLiceBasic nastavnik = DTOManager.vratiNastavnoLice(a.Nastavnik.Id);
                    PredmetBasic predmet = DTOManager.vratiPredmet(a.Predmet.Id);
                    AngazmanBasic an = new AngazmanBasic(a.Id, a.DatumOd, a.DatumDo, nastavnik, predmet);
                    angazmani.Add(an);
                }
             

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return angazmani;

        }
        public static AngazmanBasic vratiAngazman(int id)
        {
            AngazmanBasic ob = new AngazmanBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Angazman o = s.Load<Angazman>(id);
                NastavnoLiceBasic n = DTOManager.vratiNastavnoLice(o.Nastavnik.Id);
                PredmetBasic p = DTOManager.vratiPredmet(o.Predmet.Id);
                ob = new AngazmanBasic(o.Id, o.DatumOd, o.DatumDo, n, p);

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ob;
        }
        #endregion

        #region Ucenik
        public static List<UcenikPregled> vratiSveUcenike()
        {
            List<UcenikPregled> ucenici = new List<UcenikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ucenik> uceniciSkole = from o in s.Query<Ucenik>()
                                                   select o;
                SmerPregled smer = new SmerPregled();
                foreach (Ucenik o in uceniciSkole)
                {

                    smer = new SmerPregled(o.SmerUcenika.Id, o.SmerUcenika.Naziv, o.SmerUcenika.MaxUcenika);
                    ucenici.Add(new UcenikPregled(o.Id, o.Ime, o.Prezime, o.Razred, o.Adresa, o.DatumUpisa, smer));


                }
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ucenici;
        }
        public static void dodajUcenika(UcenikBasic u)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik o = new Ucenik();
                o.Ime = u.Ime;
                o.Prezime = u.Prezime;
                o.Razred = u.Razred;
                o.Adresa = u.Adresa;
                o.DatumUpisa = u.Datum_upisa;
                o.SmerUcenika = s.Load<Smer>(u.SmerUcenika.Id);

                //mora jos

                s.SaveOrUpdate(o);


                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static void obrisiUcenika(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik o = s.Load<Ucenik>(id);
                s.Delete(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static UcenikBasic azurirajUcenika(UcenikBasic u)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik o = s.Load<Ucenik>(u.Id);
                o.Ime = u.Ime;
                o.Prezime = u.Prezime;
                o.Razred = u.Razred;
                o.Adresa = u.Adresa;
                o.SmerUcenika = s.Load<Smer>(u.SmerUcenika.Id);
                o.DatumUpisa = u.Datum_upisa;

                s.Update(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            return u;
        }
        public static UcenikBasic vratiUcenika(int id)
        {
            UcenikBasic ub = new UcenikBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik u = s.Load<Ucenik>(id);
                SmerBasic smer = new SmerBasic(u.SmerUcenika.Id, u.SmerUcenika.Naziv, u.SmerUcenika.MaxUcenika);
                ub = new UcenikBasic(u.Id, u.Ime, u.Prezime, u.Razred, u.Adresa, u.DatumUpisa, smer);

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ub;
        }
        #endregion

        #region Ocena
        public static void obrisiOcenu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ocena o = s.Load<Ocena>(id);
                s.Delete(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static List<OcenaPregled> vratiOceneUcenika(UcenikBasic u)
        {
            List<OcenaPregled> ocene = new List<OcenaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ocena> oceneUcenika = from o in s.Query<Ocena>()
                                                  select o;
                PredmetPregled pred;
                UcenikPregled uceniK;
                SmerPregled smer;
                foreach (Ocena o in oceneUcenika)
                {
                    if (o.Ucenik.Id == u.Id)
                    {
                        smer = new SmerPregled(o.Ucenik.SmerUcenika.Id,o.Ucenik.SmerUcenika.Naziv,o.Ucenik.SmerUcenika.MaxUcenika);
                        uceniK = new UcenikPregled(o.Ucenik.Id, o.Ucenik.Ime, o.Ucenik.Prezime, o.Ucenik.Razred,o.Ucenik.Adresa,o.Ucenik.DatumUpisa, smer);
                        pred = new PredmetPregled(o.Predmet.Id, o.Predmet.Naziv, o.Predmet.Godina);
                        ocene.Add(new OcenaPregled(o.Id, o.NumerickaVrednost, o.Opis, o.DatumDobijanja, pred,uceniK));
                    }

                }
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ocene;
        }
        #endregion

        #region Smer
        public static List<SmerPregled> vratiSveSmerove()
        {
            List<SmerPregled> smerovi = new List<SmerPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Smer> smeroviSkole = from o in s.Query<Smer>()
                                                 select o;

                foreach (Smer o in smeroviSkole)
                {


                    smerovi.Add(new SmerPregled(o.Id, o.Naziv, o.MaxUcenika));


                }
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return smerovi;
        }
        public static void obrisiSmer(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smer o = s.Load<Smer>(id);
                s.Delete(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static SmerBasic azurirajSmer(SmerBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smer o = s.Load<Smer>(a.Id);
                o.Naziv = a.Naziv;
                o.MaxUcenika = a.MaxUcenika;
                s.Update(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return a;
        }
        public static void dodajSmer(SmerBasic smer)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smer o = new Smer();
                o.Naziv = smer.Naziv;
                o.MaxUcenika = smer.MaxUcenika;
                //mora jos



                s.SaveOrUpdate(o);


                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static SmerBasic vratiSmer(int id)
        {
            SmerBasic ob = new SmerBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Smer o = s.Load<Smer>(id);
                ob = new SmerBasic(o.Id, o.Naziv, o.MaxUcenika);

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ob;
        }
        public static int vratiBrojUcenikaNaSmeru(int smerId)
        {
            int count = 0;
            List<UcenikPregled> ucenici = new List<UcenikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ucenik> uceniciSkole = from o in s.Query<Ucenik>()
                                                   select o;
               
                foreach (Ucenik o in uceniciSkole)
                {

                    if (o.SmerUcenika.Id == smerId)
                        ++count;


                }
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return count;
        }
        #endregion

        #region Predmet
        public static List<PredmetPregled> vratiPredmeteUcenika(UcenikBasic u)
        {
            List<PredmetPregled> predmetiUcenika = new List<PredmetPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                Smer smer = s.Load<Smer>(u.SmerUcenika.Id);
               
    
                String godina;
                if (u.Razred == "prvi")
                    godina = "prva";
                else if (u.Razred == "drugi")
                    godina = "druga";
                else if (u.Razred == "treći")
                    godina = "treća";
                else
                    godina = "četvrta";

                foreach (Predmet o in smer.ListaPredmeta)
                {
                    if (o.Godina == godina)
                    {
                        List<AngazmanBasic> nastavnici = DTOManager.vratiNastavnikeNaPredmetu(o.Id);
                        if(nastavnici.Count!=0)
                        {
                            foreach (AngazmanBasic n in nastavnici)
                            {
                                PredmetPregled p = new PredmetPregled(o.Id, o.Naziv, o.Godina);
                                p.Nastavnik = n.Nastavnik.Ime + " " + n.Nastavnik.Ime_Roditelja[0] + " " + n.Nastavnik.Prezime;
                                predmetiUcenika.Add(p);
                            }
                        }
                        else
                        {
                            predmetiUcenika.Add(new PredmetPregled(o.Id, o.Naziv, o.Godina));
                        }
                       
                    }

                }
                s.Close();
               
            }
            catch { }
            return predmetiUcenika;
        }
        public static void dodajOcenu(OcenaBasic ocena)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Ocena o = new Ocena();
                o.NumerickaVrednost = ocena.NumerickaVrednost;
                o.Opis = ocena.Opis;
                o.Predmet = s.Load<Predmet>(ocena.Predmet.Id);
                o.Ucenik = s.Load<Ucenik>(ocena.Ucenik.Id);
                o.DatumDobijanja = ocena.DatumDobijanja;


                s.SaveOrUpdate(o);


                s.Flush();

                s.Close();
            }
            catch { }
        }
        public static void obrisiPredmet(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet o = s.Load<Predmet>(id);
                s.Delete(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void dodajPredmet(PredmetBasic p)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Predmet o = new Predmet();
                o.Naziv = p.Naziv; ;
                o.Godina = p.Godina;
                Smer smer = s.Load<Smer>(p.smer.Id);
                o.ListaSmerova.Add(smer);
                s.Save(o);


                s.Flush();

                s.Close();
            }
            catch(Exception ec) {
                MessageBox.Show(ec.Message);
            }
        }
        public static void azurirajPredmet(PredmetBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet o = s.Load<Predmet>(p.Id);
                o.Naziv = p.Naziv; ;
                o.Godina = p.Godina;
                Smer smer = s.Load<Smer>(p.smer.Id);
                if (!o.ListaSmerova.Contains(smer))
                    o.ListaSmerova.Add(smer);
                s.Update(o);


                s.Flush();

                s.Close();
            }
            catch { }
        }
        #endregion

        #region Staratelj
        public static List<StarateljPregled> vratiSveStarateljeUcenika(int idUcenika)
        {
           List<StarateljPregled> staratelji = new List<StarateljPregled>();
            try {
                ISession s = DataLayer.GetSession();
                Ucenik u = s.Load<Ucenik>(idUcenika);
                foreach(Staratelj staratelj in u.ListaStaratelja)
                {
                    staratelji.Add(new StarateljPregled(staratelj.Id, staratelj.Ime, staratelj.Prezime, staratelj.ClanSaveta));
                }


                s.Close();

            }
            catch (Exception ec)
                {
                    //handle exceptions
                }

                return staratelji;
            


        }
        public static void dodajStaratelja(UcenikBasic u,StarateljBasic staratelj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Staratelj o = new Staratelj();
                o.Ime = staratelj.Ime;
                o.Prezime = staratelj.Prezime;
                o.ClanSaveta = staratelj.clanSaveta;
                Ucenik ucenik = s.Load<Ucenik>(u.Id);
                o.ListaDece.Add(ucenik);
                s.SaveOrUpdate(o);
                //ucenik.ListaStaratelja.Add(o);
                

                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void obrisiStaratelja(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Staratelj o = s.Load<Staratelj>(id);
                int count = o.ListaDece.Count;
                for (int i = 0; i < count; i++)
                    o.ListaDece.RemoveAt(i);
                s.Delete(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void azurirajStaratelja(StarateljPregled n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Staratelj o = s.Load<Staratelj>(n.Id);
                o.Ime = n.Ime;
                o.Prezime = n.Prezime;
                o.ClanSaveta = n.clanSaveta;

                s.Update(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

       
        }
        public static StarateljPregled vratiStaratelja(int id)
        {
            StarateljPregled st = new StarateljPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Staratelj o = s.Load<Staratelj>(id);
                st.Ime = o.Ime;
                st.Prezime = o.Prezime;
                st.clanSaveta = o.ClanSaveta;
                st.Id = o.Id;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return st;

        }

        #endregion

        #region Telefon
        public static void dodajTelefon(TelefonPregled t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Telefoni telefon = new Telefoni();
                telefon.Staratelj_Id = s.Load<Staratelj>(t.idStaratelja);
                telefon.BrojTelefona = t.BrojTelefona;
                s.Save(telefon);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static List<TelefonBasic> vratiTelefone(int id)
        {
            List<TelefonBasic> telefoni = new List<TelefonBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Telefoni> info = from o in s.Query < Telefoni>()
                                             where o.Staratelj_Id.Id==id
                                             select o;

                foreach (Telefoni o in info)
                {

                   
                    telefoni.Add(new TelefonBasic(o.Id,o.BrojTelefona));


                }
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return telefoni;
        }
        public static void obrisiTelefon(int idTelefona)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Telefoni o = s.Load<Telefoni>(idTelefona);
                Staratelj staratelj = new Staratelj();
                staratelj = o.Staratelj_Id;
                staratelj.ListaTelefona.Remove(o);
                s.Delete(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion

        #region DrugaSkola
        public static DrugaSKolaBasic azurirajDruguSkolu(DrugaSKolaBasic d)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                DrugaSkola o = s.Load<DrugaSkola>(d.Id);
                o.Naziv = d.Naziv;
                
                s.Update(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return d;
        }
        public static void dodajDruguSkolu(DrugaSKolaBasic d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DrugaSkola o = new DrugaSkola();
                o.Naziv = d.Naziv;
              



                s.SaveOrUpdate(o);


                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void izbrisiSkolu(int idSkola)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DrugaSkola o = s.Load<DrugaSkola>(idSkola);
                s.Delete(o);


                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static List<ZaposleniPregled> vratiZaposleneUSkoli(int idSkole)
        {
            List<ZaposleniPregled> zaposleni = new List<ZaposleniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Radi> zaposleniSkole = from o in s.Query<Radi>()
                                                   where o.Skola.Id==idSkole
                                                   select o;

                foreach (Radi o in zaposleniSkole)
                {


                    zaposleni.Add(new ZaposleniPregled(o.Nastavnik.Id,o.Nastavnik.LIme,o.Nastavnik.ImeRoditelja,o.Nastavnik.Prezime,
                        o.Nastavnik.Jmbg,o.Nastavnik.Adresa));


                }
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return zaposleni;
        }
        #endregion
    }
}
