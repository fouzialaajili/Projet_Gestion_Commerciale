using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class ParametrageConfiguration : EntityTypeConfiguration<Parametrage>
    {
        public ParametrageConfiguration()
        {
            ToTable("Parametrage");
            HasKey(x => x.ParametrageId);


            /***********************************/
          //    virtual public Societe ParametrageSociete { get; set; }


        HasOptional<Societe>(a => a.ParametrageSociete)
                        .WithMany(d => d.SocieteParametrage)
                        .HasForeignKey<long?>(a => a.ParametrageSocieteId);


        }
    }
}
