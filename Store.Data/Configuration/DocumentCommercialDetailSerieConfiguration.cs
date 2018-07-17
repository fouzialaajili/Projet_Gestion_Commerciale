using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class DocumentCommercialDetailSerieConfiguration : EntityTypeConfiguration<DocumentCommercialDetailSerie>
    {
        public DocumentCommercialDetailSerieConfiguration()
        {
            ToTable("DocumentCommercialDetailSerie");
            HasKey(a => a.DocumentCommercialDetailSerieId);

            HasOptional<Societe>(a => a.DocumentCommercialDetailSerieSociete)
    .WithMany(d => d.SocieteDocumentCommercialDetailSerie)
    .HasForeignKey<long?>(a => a.DocumentCommercialDetailSerieSocieteId);
            HasOptional<DocumentCommercialDetail>(a => a.DocumentCommercialDetailSerieDocumentCommercialDetail)
             .WithMany(d => d.DocumentCommercialDetailDocumentCommercialDetailSerie)
             .HasForeignKey<long?>(a => a.DocumentCommercialDetailSerieDocumentCommercialDetailIdDocumentDetail);
        
    }
    }
}
