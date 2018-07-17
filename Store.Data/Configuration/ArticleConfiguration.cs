using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class ArticleConfiguration : EntityTypeConfiguration<Article>
    {
        public ArticleConfiguration()
        {
ToTable("Article");
HasKey(a => a.ArticleId);
HasOptional<Societe>(a => a.ArticleSociete)
           .WithMany(d => d.SocieteArticle)
            .HasForeignKey<long?>(a => a.ArticleSocieteId);

HasOptional<Depot>(a => a.ArticleDepot)
                      .WithMany(d => d.DepotArticle)
                       .HasForeignKey<long?>(a => a.ArticleDepotId);

 HasOptional<Categorie>(a => a.ArticleCategorie)
.WithMany(d => d.CategorieArticle)
.HasForeignKey<long?>(a => a.ArticleCategorieId);

            HasOptional<Unite>(a => a.ArticleUnite)
    .WithMany(d => d.UniteArticle)
    .HasForeignKey<long?>(a => a.ArticleUniteId);

            HasOptional<Marque>(a => a.ArticleMarque)
.WithMany(d => d.MarqueArticle)
.HasForeignKey<long?>(a => a.ArticleMarqueId);
        

    }
    }
}
