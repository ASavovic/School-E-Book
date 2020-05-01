using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Entiteti
{
    public class Smer
    {
        public virtual int Id { get; set; }
        public virtual String Naziv { get; set; }
        public virtual int MaxUcenika { get; set; }
        public virtual IList<Predmet> ListaPredmeta { get; set; }
        public virtual IList<Ucenik> ListaUcenika { get; set; }

        public Smer()
        {
            ListaPredmeta = new List<Predmet>();
            ListaUcenika = new List<Ucenik>();
        }
    }
}
