using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Entiteti
{
    public class Predmet
    {
        public virtual int Id { get; set; }
        public virtual String Naziv { get; set; }
        public virtual String Godina { get; set; }
        public virtual IList<Angazman> ListaNastavnika { get; set; }
        public virtual IList<Smer> ListaSmerova { get; set; }
        public virtual IList<Ocena> ListaOcena { get; set; }

        public Predmet()
        {
           ListaNastavnika = new List<Angazman>();
           ListaSmerova = new List<Smer>();
            ListaOcena = new List<Ocena>();
        }
    }
}
