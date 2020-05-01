using FluentNHibernate.Mapping;
using Skola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Mapiranja
{
    public class PredmetMapiranja : ClassMap<Predmet>
    {
        public PredmetMapiranja()
        {
            Table("PREDMET");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Godina, "GODINA");
            Map(x => x.Naziv, "NAZIV");


            HasMany(x => x.ListaOcena).
                KeyColumn("PREDMET_ID").LazyLoad().
                Cascade.All().
                Inverse();



            HasManyToMany(x => x.ListaSmerova)
                .Table("LISTA_PREDMETA")
                .ParentKeyColumn("PREDMET_ID")
                .ChildKeyColumn("SMER_ID");



             HasMany(x => x.ListaNastavnika).
                KeyColumn("PREDMET_ID").LazyLoad().
                Cascade.All().
                Inverse();


        }
    }
}
