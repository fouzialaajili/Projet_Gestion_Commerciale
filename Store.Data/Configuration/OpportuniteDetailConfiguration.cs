using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class OpportuniteDetailConfiguration : EntityTypeConfiguration<OpportuniteDetail>
    {
        public OpportuniteDetailConfiguration()
        {
            ToTable(" OpportuniteDetail");
            HasKey(x => x.OpportuniteDetailId);


            /***********************************/

        //       virtual public Fichetiers OpportuniteDetailFichetier { get; set; }
        //virtual public Opportunite OpportuniteDetailOpportunite { get; set; }

        HasOptional<Fichetier>(a => a.OpportuniteDetailFichetier)
                                  .WithMany(d => d.FichetiersOpportuniteDetail)
                                  .HasForeignKey<long?>(a => a.OpportuniteDetailIdcommercial);

            HasOptional<Opportunite>(a => a.OpportuniteDetailOpportunite)
                                  .WithMany(d => d.OpportuniteOpportuniteDetail)
                                  .HasForeignKey<long?>(a => a.OpportuniteDetailIdopportunite);

        }
    }
}
