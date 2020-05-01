using FluentNHibernate.Mapping;
using Skola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Mapiranja
{
    public class UcenikMapiranja : ClassMap<Ucenik>
    {
        public UcenikMapiranja()
        {
            Table("UCENIK");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Razred).Column("RAZRED");
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.DatumUpisa).Column("DATUM_UPISA");

            References(x => x.SmerUcenika).Column("SMER_ID").LazyLoad();

            HasMany(x => x.ListaOcena).KeyColumn("UCENIK_ID")
                .LazyLoad()
                .Inverse().
                Cascade.All();

            HasManyToMany(x => x.ListaStaratelja)
                .Table("ODGOVORNO_LICE")
                .ParentKeyColumn("UCENIK_ID")
                .ChildKeyColumn("STARATELJ_ID")
                .Inverse()
                .Cascade.All();
        }
    }
}
