using FluentNHibernate.Mapping;
using Skola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Mapiranja
{
    public class OcenaMapiranja : ClassMap<Ocena>
    {
        public OcenaMapiranja()
        {
            Table("OCENA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumDobijanja, "DATUM");
            Map(x => x.NumerickaVrednost, "NUMERICKA_VREDNOST");
            Map(x => x.Opis, "OPIS");

            References(x => x.Ucenik).
                Column("UCENIK_ID").Not.LazyLoad(); 

            References(x => x.Predmet).
                Column("PREDMET_ID").Not.LazyLoad(); 


        }
    }
}
