using FluentNHibernate.Mapping;
using Skola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Mapiranja
{
    public class StarateljMapiranja : ClassMap<Staratelj>
    {
        public StarateljMapiranja()
        {
              Table("STARATELJ");


              Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

              Map(x => x.Ime).Column("IME");
              Map(x => x.Prezime).Column("PREZIME");
              Map(x => x.ClanSaveta).Column("CLAN_SAVETA_FLAG");


              HasMany(x => x.ListaTelefona).
                 KeyColumn("STARATELJ_ID").Not.
                 LazyLoad().
                 Cascade.All().
                 Inverse();

              HasManyToMany(x => x.ListaDece)
                  .Table("ODGOVORNO_LICE")
                  .ParentKeyColumn("STARATELJ_ID")
                  .ChildKeyColumn("UCENIK_ID")
                  .Not.LazyLoad()
                  .Cascade.All();
          }
        }

    
}
