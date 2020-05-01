using FluentNHibernate.Mapping;
using Skola.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skola.Mapiranja
{
    public class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");

            DiscriminateSubClassesOnColumn("TIP_OSOBLJA");



            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.LIme).Column("LIME");
            Map(x => x.ImeRoditelja).Column("IME_RODITELJA");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Jmbg).Column("JMBG");
            Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA");
            Map(x => x.Adresa).Column("ADRESA");




        }
    }
    public class NastavnoOsobljeMapiranja : SubclassMap<NastavnoOsoblje>
    {
        public NastavnoOsobljeMapiranja()
        {


            DiscriminatorValue("nastavno");
            Map(x => x.PunaNorma, "PUNA_NORMA_FLAG");


            HasMany(x => x.ListaPredmeta).KeyColumn("ZAPOSLENI_ID")
                .LazyLoad()
                .Inverse().
                Cascade.All();


            HasMany(x => x.ListaSkola).KeyColumn("ZAPOSLENI_ID")
                .LazyLoad()
                .Inverse().
                Cascade.All();

        }
    }



    public class NeNastavnoOsobljeMapiranja : SubclassMap<NeNastavnoOsoblje>
    {


        public NeNastavnoOsobljeMapiranja()
        {

            DiscriminatorValue("nenastavno");
            Map(x => x.Sprema).Column("SPREMA");
            Map(x => x.Sektor).Column("SEKTOR");

        }
    }

}
