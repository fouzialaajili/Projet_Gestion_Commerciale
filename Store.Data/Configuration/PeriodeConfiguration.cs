using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class PeriodeConfiguration : EntityTypeConfiguration<Periode>
    {
        public PeriodeConfiguration()
        {
            ToTable("Periode");
            HasKey(x => x.PeriodeId);


            /***********************************/
            //      virtual public Societe PeriodeSociete { get; set; }


            HasOptional<Societe>(a => a.PeriodeSociete)
                            .WithMany(d => d.SocietePeriode)
                            .HasForeignKey<long?>(a => a.PeriodeSocieteId);


        }
    }
}
