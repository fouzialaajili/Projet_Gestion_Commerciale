using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
   public  class DeviseConfiguration : EntityTypeConfiguration<Devise>
    {
        public DeviseConfiguration()
        {
            ToTable("Devise");
            HasKey(a => a.DeviseId);


            HasOptional<Societe>(a => a.DeviseSociete)
.WithMany(d => d.SocieteDevise)
.HasForeignKey<long?>(a => a.DeviseSocieteId);
        }
    }
}
