using Skola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola
{
    #region Zaposleni
    public class ZaposleniPregled
    {
        public int Id { get; protected set; }
        public String Ime { get; set; }
        public String Ime_Roditelja { get; set; }
        public String Prezime { get; set; }
        public String Jmbg { get; set; }
        public String Adresa { get; set; }

        public ZaposleniPregled(int id, String ime, String imeRoditelja, String prezime, String jmbg, String adresa)
        {
            this.Id = id;
            this.Ime = ime;
            this.Ime_Roditelja = imeRoditelja;
            this.Prezime = prezime;
            this.Jmbg = jmbg;
            this.Adresa = adresa;

        }
    }
    public class ZaposleniBasic
    {
        public int Id { get; protected set; }
        public String Ime { get; set; }
        public String Ime_Roditelja { get; set; }
        public String Prezime { get; set; }
        public String Jmbg { get; set; }
        public String Adresa { get; set; }
        public DateTime? DatumRodjenja { get; set; }

        public ZaposleniBasic(int id, String ime, String imeRoditelja, String prezime, String jmbg, String adresa,DateTime? datumRodjenja)
        {
            this.Id = id;
            this.Ime = ime;
            this.Ime_Roditelja = imeRoditelja;
            this.Prezime = prezime;
            this.Jmbg = jmbg;
            this.Adresa = adresa;
            this.DatumRodjenja = datumRodjenja;

        }
        public ZaposleniBasic()
        {

        }

    }
    #endregion

    #region NeNastavnoLice
    public class NeNastavnoLicePregled : ZaposleniPregled
    {
        public String sektor;
        public String sprema;
        public NeNastavnoLicePregled(int id, String ime, String imeRoditelja, String prezime, String jmbg, String adresa, String sektor, String sprema) : base(id,ime,imeRoditelja,prezime,jmbg,adresa)
        {
            this.sektor = sektor;
            this.sprema = sprema;
        }
    }
    public class NeNastavnoLiceBasic : ZaposleniBasic
    {
        public String sektor;
        public String sprema;
        public NeNastavnoLiceBasic(int id, String ime, String imeRoditelja, String prezime, String jmbg, String adresa, String sektor, String sprema,DateTime? datumRodjenja) : base(id, ime, imeRoditelja, prezime, jmbg, adresa,datumRodjenja)
        {
            this.sektor = sektor;
            this.sprema = sprema;
        }
        public NeNastavnoLiceBasic()
        {

        }
    }
    #endregion

    #region NastavnoLice
    public class NastavnoLicePregled : ZaposleniPregled
    {

        public int PunaNorma { get; set; }

        public NastavnoLicePregled(int id, String ime, String imeRoditelja, String prezime, String jmbg, String adresa,int norma):base(id,ime,imeRoditelja,prezime,jmbg,adresa)
        {

            this.PunaNorma = norma;
        }
        public override string ToString()
        {
            return this.Ime + " " + this.Ime_Roditelja + " " + this.Prezime;
        }

    }
    public class NastavnoLiceBasic : ZaposleniBasic
    {

        public int PunaNorma { get; set; }
        

        public NastavnoLiceBasic(int id, String ime, String imeRoditelja, String prezime, String jmbg, String adresa, int norma,DateTime? datumRodjenja):base(id,ime,imeRoditelja,prezime,jmbg,adresa,datumRodjenja)
        {
            this.PunaNorma = norma;
        }
        public NastavnoLiceBasic()
        {

        }

    }
    #endregion

    #region Angazman
    public class AngazmanPregled
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime? DatumDo { get; set; }
        public virtual PredmetPregled Predmet { get; set; }

        public AngazmanPregled(int id,DateTime DatumOd,DateTime? DatumDo,Predmet p)
        {
            this.Id = id;
            this.DatumOd = DatumOd;
            this.DatumDo = DatumDo;
            this.Predmet = new PredmetPregled(p.Id, p.Naziv, p.Godina);
            foreach(Smer smer in p.ListaSmerova)
            {
                this.Predmet.Smer.Add(smer.Naziv);
            }
            
        }

    }
    public class AngazmanBasic
    {
        public  int Id { get; set; }
        public  DateTime DatumOd { get; set; }
        public  DateTime? DatumDo { get; set; }
        public  NastavnoLiceBasic Nastavnik { get; set; }
        public  PredmetBasic Predmet { get; set; }

        public AngazmanBasic(int id, DateTime DatumOd, DateTime? DatumDo,NastavnoLiceBasic n, PredmetBasic p)
        {
            this.Id = id;
            this.DatumOd = DatumOd;
            this.DatumDo = DatumDo;
            this.Nastavnik = n;
            this.Predmet = p;
        }
        public AngazmanBasic()
        {

        }
    }
    #endregion

    #region Smer
    public class SmerPregled
    {
        public virtual int Id { get; set; }
        public virtual String Naziv { get; set; }
        public virtual int MaxUcenika { get; set; }
        public SmerPregled() { }
        public SmerPregled(int id, String naziv,int maxUcenika)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.MaxUcenika = maxUcenika;
        }
        public override string ToString()
        {
            return this.Naziv;
        }
    }

    public class SmerBasic
    {
        public virtual int Id { get; set; }
        public virtual String Naziv { get; set; }
        public virtual int MaxUcenika { get; set; }

        public SmerBasic(int id, String naziv, int maxUcenika)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.MaxUcenika = maxUcenika;
        }
        public SmerBasic()
        {

        }
    }
    #endregion Smer

    #region Ocena
    public class OcenaPregled
    {
        public  int Id { get; set; }
        public  int NumerickaVrednost { get; set; }
        public  string Opis { get; set; }
        public  DateTime DatumDobijanja { get; set; }

        public PredmetPregled Predmet { get; set; }
        public UcenikPregled Ucenik { get; set; }
        public OcenaPregled(int id,int numerickaVrednost,string opis,DateTime datum, PredmetPregled pred, UcenikPregled u)
        {
            this.Id = id;
            this.NumerickaVrednost = numerickaVrednost;
            this.Opis = opis;
            this.DatumDobijanja = datum;
            this.Predmet = pred;
            this.Ucenik = u;
        }
    }

    public class OcenaBasic
    {
        public int Id { get; set; }
        public int NumerickaVrednost { get; set; }
        public string Opis { get; set; }
        public DateTime DatumDobijanja { get; set; }

        public PredmetBasic Predmet { get; set; }
        public UcenikBasic Ucenik { get; set; }
        public OcenaBasic(int id, int numerickaVrednost, string opis, DateTime datum,PredmetBasic pred, UcenikBasic u)
        {
            this.Id = id;
            this.NumerickaVrednost = numerickaVrednost;
            this.Opis = opis;
            this.DatumDobijanja = datum;
            this.Predmet = pred;
            this.Ucenik = u;
        }
        public OcenaBasic()
        {

        }

    }
    #endregion

    #region Predmet
    public class PredmetPregled
    {
        public  int Id { get; set; }
        public  String Naziv { get; set; }
        public  String Godina { get; set; }
        public String Nastavnik { get; set; }
        public List<String> Smer { get; set; }
       

        public PredmetPregled(int id,String naziv,String godina)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Godina = godina;
            this.Smer = new List<String>();
        }
    }
    
    public class PredmetBasic
    {
        public  int Id { get; set; }
        public  String Naziv { get; set; }
        public  String Godina { get; set; }
        public SmerPregled smer { get; set; }

        public PredmetBasic(int id, String naziv, String godina)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Godina = godina;
        }
        public PredmetBasic()
        {

        }
    }
    #endregion

    #region RadUDrugojSkoli

    public class RadUDrugojSkoliPregled
    {
        public int id;
        public DrugaSkola skola;
        public int brojCasova;

        public RadUDrugojSkoliPregled(int id,DrugaSkola skola,int brojCasova)
        {
            this.id = id;
            this.skola = skola;
            this.brojCasova = brojCasova;
        }
    }

    public class RadUDrugojSkoliBasic
    {
        public int id;
        public DrugaSKolaBasic skola;
        public int brojCasova;
        public NastavnoLiceBasic nastavnik;

        public RadUDrugojSkoliBasic(int id, DrugaSKolaBasic skola,int brojCasova,NastavnoLiceBasic n)
        {
            this.id = id;
            this.skola = skola;
            this.brojCasova = brojCasova;
            this.nastavnik = n;

        }
        public RadUDrugojSkoliBasic()
        {


        }

    }
    #endregion

    #region DrugaSkola
    public class DrugaSKolaPregled
    {
        public  int Id { get; protected set; }
        public  String Naziv { get; set; }

        public DrugaSKolaPregled(int id,String naziv)
        {
            this.Id = id;
            this.Naziv = naziv;
        }
    }

    public class DrugaSKolaBasic
    {
        public int Id { get; protected set; }
        public String Naziv { get; set; }

        public DrugaSKolaBasic(int id, String naziv)
        {
            this.Id = id;
            this.Naziv = naziv;
        }

        public DrugaSKolaBasic()
        {

        }
        public override string ToString()
        {
            return this.Naziv;
        }
    }
    #endregion

    #region Ucenik

    public class UcenikPregled
    {

        public int Id { get; set; }

        public String Ime { get; set; }

        public String Prezime { get; set; }

        public String Razred { get; set; }

        public String Adresa { get; set; }

        public SmerPregled SmerUcenika { get; set; }
       
        public DateTime Datum_upisa { get; set; }

       // public IList<Staratelj> ListaStaratelja { get; set; }

       // public IList<Ocena> ListaOcena { get; set; }


        public UcenikPregled()
        {

        }

        public UcenikPregled(int id, String ime, String prezime, String razred, String adresa,
            DateTime upis, SmerPregled nazivs)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.Razred = razred;
            this.Datum_upisa = upis;
           // this.ListaOcena = ocene;
            this.SmerUcenika = nazivs;
           // this.ListaStaratelja = roditelji;

        }
    }

    public class UcenikBasic
    {
        public int Id { get; set; }

        public String Ime { get; set; }

        public String Prezime { get; set; }

        public String Razred { get; set; }

        public String Adresa { get; set; }

        public SmerBasic SmerUcenika { get; set; }

        public DateTime Datum_upisa { get; set; }

       // public IList<Staratelj> ListaStaratelja { get; set; }

        //public IList<Ocena> ListaOcena { get; set; }


        public UcenikBasic()
        {

        }

        public UcenikBasic(int id, String ime, String prezime, String razred, String adresa,
            DateTime upis, SmerBasic nazivs)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.Razred = razred;
            this.Datum_upisa = upis;
            this.SmerUcenika = nazivs;

        }
    }


    #endregion

    #region Staratelj
    public class StarateljPregled
    {
        public int Id;
        public String Ime;
        public String Prezime;
        public int clanSaveta;

        public StarateljPregled(int id, String ime, String prezime, int savet)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.clanSaveta = savet;
        }
       public StarateljPregled()
        {

        }

    }
    public class StarateljBasic
    {
        public int Id;
        public String Ime;
        public String Prezime;
        public int clanSaveta;

        public StarateljBasic(String ime,String prezime,int savet)
        {
            
            this.Ime = ime;
            this.Prezime = prezime;
            this.clanSaveta = savet;
        }
        public StarateljBasic()
        {

        }

    }

    #endregion

    #region Telefon
    public class TelefonPregled
    {
        public  int Id { get; protected set; }
        public  String BrojTelefona { get; set; }
        public int idStaratelja { get; set; }
        public TelefonPregled(int id,String brojTelefon)
        {
            this.idStaratelja = id;
            this.BrojTelefona = brojTelefon;
        }
      
        public TelefonPregled()
        {

        }
    }
    public class TelefonBasic
    {
        public int Id { get; protected set; }
        public String BrojTelefona { get; set; }

        public TelefonBasic(int id, String brojTelefon)
        {
            this.Id = id;
            this.BrojTelefona = brojTelefon;
        }
        public TelefonBasic()
        {

        }
    }

    #endregion



}
