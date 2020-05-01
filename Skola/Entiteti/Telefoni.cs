using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Entiteti
{
    public class Telefoni
    {
        public virtual int Id { get; protected set; }
        public virtual String BrojTelefona { get; set; }
        public virtual Staratelj Staratelj_Id { get; set; }

        public Telefoni()
        {
           Staratelj_Id = new Staratelj();
        }

    }
}
