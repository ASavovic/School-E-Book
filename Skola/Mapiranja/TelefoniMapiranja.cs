using FluentNHibernate.Mapping;
using Skola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Mapiranja
{
    public class TelefoniMapiranja : ClassMap<Telefoni>
    {
        public TelefoniMapiranja()
        {
            Table("TELEFONI");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();


            Map(x => x.BrojTelefona, "TELEFON");

            References(x => x.Staratelj_Id).
                Column("STARATELJ_ID").Not.LazyLoad();

        }
    }
}
