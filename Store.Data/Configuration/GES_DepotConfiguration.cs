using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class GES_DepotConfiguration : EntityTypeConfiguration<GES_Depot>
    {
        public GES_DepotConfiguration()
        {
            ToTable("Depot");
            HasKey(a => a.DepotId);
            HasOptional<GES_Societe>(a => a.DepotSociete)
.WithMany(d => d.SocieteDepot)
.HasForeignKey<long?>(a => a.DepotSocieteId);


    }
    }
}
