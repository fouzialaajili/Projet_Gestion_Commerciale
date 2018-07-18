using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class DocumentCommercialDetailSerieConfiguration : EntityTypeConfiguration<GES_DocumentCommercialDetailSerie>
    {
        public DocumentCommercialDetailSerieConfiguration()
        {
            ToTable("DocumentCommercialDetailSerie");
            HasKey(a => a.DocumentCommercialDetailSerieId);

            HasOptional<GEN_Dossiers>(a => a.DocumentCommercialDetailSerieSociete)
    .WithMany(d => d.SocieteDocumentCommercialDetailSerie)
    .HasForeignKey<long?>(a => a.DocumentCommercialDetailSerieSocieteId);
            HasOptional<GES_DocumentCommercialDetail>(a => a.DocumentCommercialDetailSerieDocumentCommercialDetail)
             .WithMany(d => d.DocumentCommercialDetailDocumentCommercialDetailSerie)
             .HasForeignKey<long?>(a => a.DocumentCommercialDetailSerieDocumentCommercialDetailIdDocumentDetail);
        
    }
    }
}
