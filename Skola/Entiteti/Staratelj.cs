using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Entiteti
{
    public class Staratelj
    {
        public virtual int Id { get; protected set; }
        public virtual String Ime { get; set; }
        public virtual String Prezime { get; set; }
        public virtual int ClanSaveta { get; set; }
        public virtual IList<Ucenik> ListaDece { get; set; }
        public virtual IList<Telefoni> ListaTelefona { get; set; }

        public Staratelj()
        {
            ListaDece = new List<Ucenik>();
            ListaTelefona = new List<Telefoni>();
        }

    }


}
