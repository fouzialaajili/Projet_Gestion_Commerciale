using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class DocumentCommercialDetailConfiguration : EntityTypeConfiguration<DocumentCommercialDetail>
    {
        public DocumentCommercialDetailConfiguration()
        {
            ToTable("DocumentCommercialDetail");
            HasKey(a => a.DocumentCommercialDetailId);
            HasOptional<Article>(a => a.DocumentCommercialDetailArticle)
      .WithMany(d => d.ArticleDocumentCommercialDetail)
      .HasForeignKey<long?>(a => a.DocumentCommercialDetailArticleId);
            HasOptional<DocumentCommercial>(a => a.DocumentCommercialDetailDocumentCommercial)
             .WithMany(d => d.DocumentCommercialDocumentCommercialDetail)
             .HasForeignKey<long?>(a => a.DocumentCommercialIdDocumentCommercial);

     


    }
}
}
