using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Entiteti
{
    public class Angazman
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime? DatumDo { get; set; }
        public virtual NastavnoOsoblje Nastavnik { get; set; }
        public virtual Predmet Predmet { get; set; }

        public Angazman()
        {
            Nastavnik = new NastavnoOsoblje();
            Predmet = new Predmet();
        }
        public override string ToString()
        {
            return Nastavnik.LIme + " " + Nastavnik.ImeRoditelja[0] + " " + Nastavnik.Prezime;
        }
    }
}
