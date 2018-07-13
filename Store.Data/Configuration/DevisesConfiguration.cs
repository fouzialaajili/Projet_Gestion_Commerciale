using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
   public  class DevisesConfiguration : EntityTypeConfiguration<Devises>
    {
        public DevisesConfiguration()
        {
            ToTable("Devises");
            HasKey(a => a.DevisesId);

        }
    }
}
