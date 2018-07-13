using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class ArticlesConfiguration : EntityTypeConfiguration<Articles>
    {
        public ArticlesConfiguration()
        {
ToTable("Articles");
HasKey(a => a.ArticlesId);
HasOptional<Societe>(a => a.ArticlesSociete)
           .WithMany(d => d.SocieteArticles)
            .HasForeignKey<long?>(a => a.ArticlesSocieteId);

HasOptional<Depot>(a => a.ArticlesDepot)
                      .WithMany(d => d.DepotArticles)
                       .HasForeignKey<long?>(a => a.ArticlesDepotId);

 HasOptional<Categorie>(a => a.ArticlesCategorie)
.WithMany(d => d.CategorieArticles)
.HasForeignKey<long?>(a => a.ArticlesCategorieId);
            HasOptional<Unite>(a => a.ArticlesUnite)
    .WithMany(d => d.UniteArticles)
    .HasForeignKey<long?>(a => a.ArticlesUniteId);

            HasOptional<Marque>(a => a.ArticlesMarque)
.WithMany(d => d.MarqueArticles)
.HasForeignKey<long?>(a => a.ArticlesMarqueId);
        

    }
    }
}
