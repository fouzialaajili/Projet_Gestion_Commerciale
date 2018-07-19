using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class GES_DoclieartConfiguration : EntityTypeConfiguration<GES_Doclieart>
    {
        public GES_DoclieartConfiguration()
        {
            ToTable("Doclieart");
            HasKey(a => a.DoclieartId);
            HasOptional<GEN_Dossiers>(a => a.DoclieartSociete)
           .WithMany(d => d.SocieteDoclieart)
           .HasForeignKey<long?>(a => a.DoclieartSocieteId);
        }
    }
}
