﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GES_FournisseurArticleConfiguration  : EntityTypeConfiguration<GES_FournisseurArticle>
    {
        public GES_FournisseurArticleConfiguration()
        {
            ToTable("FournisseurArticle");
            HasKey(x => x.FournisseurArticleId);


            /***********************************/

     //virtual public GEN_Tiers FournisseurArticleFichetier { get; set; }
     //   virtual public GES_Article FournisseurArticleArticle
     //   { get; set; }


        HasOptional<GEN_Tiers>(a => a.FournisseurArticleFichetier)
                .WithMany(d => d.GES_FournisseurArticle)
                .HasForeignKey<long?>(a => a.FournisseurArticleIdfournisseur);

            HasOptional<GES_Article>(a => a.FournisseurArticleArticle)
                    .WithMany(d => d.ArticleFournisseurArticle)
                    .HasForeignKey<long?>(a => a.FournisseurArticleIdArticle);

        }
    }
}
