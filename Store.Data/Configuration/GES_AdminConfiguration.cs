using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class GES_AdminConfiguration : EntityTypeConfiguration<GES_Admin>
    {
      public GES_AdminConfiguration() {
           ToTable("Admin");
            HasKey(a => a.AdminId);
           
     
    }
    }
}
