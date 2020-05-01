using FluentNHibernate.Mapping;
using Skola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Mapiranja
{
    public class AngazmanMapiranja : ClassMap<Angazman>
    {
        public AngazmanMapiranja()
        {
            Table("ANGAZMAN");
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");

            References(x => x.Nastavnik).
               Column("ZAPOSLENI_ID").Not.LazyLoad();

            References(x => x.Predmet).
               Column("PREDMET_ID").Not.LazyLoad();

        }
    }
}
