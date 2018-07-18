using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GES_GedConfiguration : EntityTypeConfiguration<GES_Ged>
    {
        public GES_GedConfiguration()
        {
            ToTable("Ged");
            HasKey(x => x.GedId);
           
        }
    }
}
