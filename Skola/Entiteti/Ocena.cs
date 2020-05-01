using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Entiteti
{
    public class Ocena
    {
        public virtual int Id { get; set; }
        public virtual int NumerickaVrednost { get; set; }
        public virtual string Opis { get; set; }
        public virtual DateTime DatumDobijanja { get; set; }
        public virtual Predmet Predmet { get; set; }
        public virtual Ucenik Ucenik { get; set; }

        public Ocena()
        {
             Predmet = new Predmet();
             Ucenik = new Ucenik();
        }
    }
}
