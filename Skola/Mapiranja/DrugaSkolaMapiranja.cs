using FluentNHibernate.Mapping;
using Skola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Mapiranja
{
    public class DrugaSkolaMapiranja : ClassMap<DrugaSkola>
    {
        public DrugaSkolaMapiranja()
        {
            Table("DRUGA_SKOLA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Naziv, "NAZIV");

          

            HasMany(x => x.ListaZaposlenih).
                KeyColumn("SKOLA_ID").LazyLoad().
                Cascade.All().
                Inverse();



        }
    }
}
