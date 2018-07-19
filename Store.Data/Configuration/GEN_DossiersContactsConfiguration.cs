using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GEN_DossiersContactsConfiguration : EntityTypeConfiguration<GEN_DossiersContacts>
    {
        public GEN_DossiersContactsConfiguration()
        {
            ToTable("DossiersContact");
            HasKey(x => x.DossiersContactsId);


            /***********************************/

             //public virtual GEN_Dossiers GEN_Dossiers { get; set; }
  
                    HasOptional<GEN_Dossiers>(a => a.GEN_Dossiers)
                                          .WithMany(d => d.GEN_DossiersContacts)
                                          .HasForeignKey<long?>(a => a.IdDossier);
            
       
    }
    }
}
