using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class ArticlesPrixConfiguration : EntityTypeConfiguration<ArticlesPrix>
    { public ArticlesPrixConfiguration(){

            ToTable("ArticlesPrix");
            HasKey(a => a.ArticlesPrixId);
            HasOptional<Articles>(a => a.ArticlesPrixArticles)
.WithMany(d => d.ArticlesArticlesPrix)
.HasForeignKey<long?>(a => a.ArticlesPrixArticlesId);
            

    }
    }
}
