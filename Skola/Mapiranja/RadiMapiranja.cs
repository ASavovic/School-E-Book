using FluentNHibernate.Mapping;
using Skola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Mapiranja
{
    class RadiMapiranja : ClassMap<Radi>
    {
        public RadiMapiranja()
        {
            Table("RADI");
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojCasova, "BROJ_CASOVA");

            References(x => x.Nastavnik).
               Column("ZAPOSLENI_ID").Not.LazyLoad();

            References(x => x.Skola).
                Column("SKOLA_ID").Not.LazyLoad();
        }
    }
}
