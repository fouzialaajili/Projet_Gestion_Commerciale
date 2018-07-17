using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class FournisseurArticleConfiguration  : EntityTypeConfiguration<FournisseurArticle>
    {
        public FournisseurArticleConfiguration()
        {
            ToTable("FournisseurArticle");
            HasKey(x => x.FournisseurArticleId);


            /***********************************/

        //virtual public Fichetiers FournisseurArticleFichetier { get; set; }
        //virtual public Articles FournisseurArticleArticle { get; set; }


        HasOptional<Fichetier>(a => a.FournisseurArticleFichetier)
                .WithMany(d => d.FournisseurArticleFichetier)
                .HasForeignKey<long?>(a => a.FournisseurArticleIdfournisseur);

            HasOptional<Article>(a => a.FournisseurArticleArticle)
                    .WithMany(d => d.ArticleFournisseurArticle)
                    .HasForeignKey<long?>(a => a.FournisseurArticleIdArticle);

        }
    }
}
