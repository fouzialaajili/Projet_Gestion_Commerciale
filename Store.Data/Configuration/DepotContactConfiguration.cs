using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class DepotContactConfiguration : EntityTypeConfiguration<DepotContact>
    {
        public DepotContactConfiguration()
        {
            ToTable("Depot de Contact");
            HasKey(a => a.DepotContactID);
            HasOptional<Depot>(a => a.DepotContactDepot)
.WithMany(d => d.DepotDepotContact)
.HasForeignKey<long?>(a => a.DepotContactDepotId);
     

    }
    }
}
