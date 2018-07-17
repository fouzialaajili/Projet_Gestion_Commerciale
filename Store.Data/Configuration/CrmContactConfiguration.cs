using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
   public  class CrmContactConfiguration : EntityTypeConfiguration<CrmContact>
    {
        public CrmContactConfiguration()
        {
            ToTable("CrmContact");
            HasKey(a => a.CrmContactId);
            HasOptional<Societe>(a => a.CrmContactSociete)
.WithMany(d => d.SocieteCrmContact)
.HasForeignKey<long?>(a => a.CrmContactSocieteId);

            HasOptional<Opportunite>(a => a.CrmContactOpportunite)
.WithMany(d => d.OpportuniteCrmContact)
.HasForeignKey<long?>(a => a.CrmContactOpportuniteId);
            HasOptional<Fichetiers>(a => a.CrmContactFichetiers)
.WithMany(d => d.FichetiersCrmContact)
.HasForeignKey<long?>(a => a.CrmContactFichetiersId);



        
    }
    }
}
