using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Entiteti
{
    public abstract class Zaposleni
    {
        public virtual int Id { get; protected set; }
        public virtual String LIme { get; set; }
        public virtual String ImeRoditelja { get; set; }
        public virtual String Prezime { get; set; }
        public virtual DateTime? DatumRodjenja { get; set; }
        public virtual String Jmbg { get; set; }
        public virtual String Adresa { get; set; }





    }

    public class NastavnoOsoblje : Zaposleni
    {

        public virtual int PunaNorma { get; set; }
        public virtual IList<Angazman> ListaPredmeta { get; set; }
        public virtual IList<Radi> ListaSkola { get; set; }
        public NastavnoOsoblje()
        {
            ListaPredmeta = new List<Angazman>();
            ListaSkola = new List<Radi>();

        }

    }



    public class NeNastavnoOsoblje : Zaposleni
    {
        public virtual string Sprema { get; set; }
        public virtual string Sektor { get; set; }
    }

}
