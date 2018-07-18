﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class GES_ArticlesPrixConfiguration : EntityTypeConfiguration<GES_ArticlesPrix>
    { public GES_ArticlesPrixConfiguration(){

            ToTable("ArticlesPrix");
            HasKey(a => a.ArticlesPrixId);
            HasOptional<GES_Article>(a => a.ArticlesPrixArticle)
.WithMany(d => d.ArticleArticlesPrix)
.HasForeignKey<long?>(a => a.ArticlesPrixArticleId);
            

    }
    }
}
