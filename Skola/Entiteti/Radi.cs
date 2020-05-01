using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Entiteti
{
    public class Radi
    {
        public virtual int Id { get; set; }
        public virtual int BrojCasova { get; set; }
        public virtual NastavnoOsoblje Nastavnik { get; set; }
        public virtual DrugaSkola Skola { get; set; }

        public Radi()
        {
            Nastavnik = new NastavnoOsoblje();
            Skola = new DrugaSkola();
        }
    }
}
