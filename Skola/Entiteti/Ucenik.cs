using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Entiteti
{
    public class Ucenik
    {
        public virtual int Id { get; protected set; }
        public virtual String Ime { get; set; }
        public virtual String Prezime { get; set; }
        public virtual String Razred { get; set; }
        public virtual String Adresa { get; set; }
        public virtual Smer SmerUcenika { get; set; }
        public virtual DateTime DatumUpisa { get; set; }
        public virtual IList<Staratelj> ListaStaratelja { get; set; }
        public virtual IList<Ocena> ListaOcena { get; set; }

        public Ucenik()
        {
            ListaStaratelja = new List<Staratelj>();
            ListaOcena = new List<Ocena>();
            SmerUcenika = new Smer();
        }
    }

}