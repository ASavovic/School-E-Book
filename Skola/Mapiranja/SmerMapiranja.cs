using FluentNHibernate.Mapping;
using Skola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Mapiranja
{
    public class SmerMapiranja : ClassMap<Smer>
    {
        public SmerMapiranja()
        {
            Table("SMER");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.MaxUcenika, "MAX_UCENIKA");


            HasMany(x => x.ListaUcenika).
                KeyColumn("SMER_ID").LazyLoad().
                Inverse().
                Cascade.All();


            HasManyToMany(x => x.ListaPredmeta)
                .Table("LISTA_PREDMETA")
                .ParentKeyColumn("SMER_ID")
                .ChildKeyColumn("PREDMET_ID")
                .Inverse()
                .Cascade.All()
                .LazyLoad();
        }
    }
}
