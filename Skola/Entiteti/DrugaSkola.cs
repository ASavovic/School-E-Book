using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Entiteti
{
    public class DrugaSkola
    {
        public virtual int Id { get; protected set; }
        public virtual String Naziv { get; set; }
        public virtual IList<Radi> ListaZaposlenih { get; set; }

        public DrugaSkola()
        {
            ListaZaposlenih = new List<Radi>();
        }
    }
}
