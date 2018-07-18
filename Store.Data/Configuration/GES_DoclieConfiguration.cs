using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class GES_DoclieConfiguration : EntityTypeConfiguration<GES_Doclie>
    {
        public GES_DoclieConfiguration()
        {
            ToTable("Doclie");
            HasKey(a => a.DoclieId);
            HasOptional<Societe>(a => a.DoclieSociete)
         .WithMany(d => d.SocieteDoclie)
         .HasForeignKey<long?>(a => a.DoclieSocieteId);
        }
    }
}
