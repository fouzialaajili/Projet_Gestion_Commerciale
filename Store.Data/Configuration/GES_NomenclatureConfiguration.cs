﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GES_NomenclatureConfiguration : EntityTypeConfiguration<GES_Nomenclature>
    {
        public GES_NomenclatureConfiguration()
        {
            ToTable("Nomenclature");
            HasKey(x => x.NomenclatureId);


            /***********************************/

         // virtual public Articles NomenclatureArticle { get; set; }



        HasOptional<GES_Article>(a => a.NomenclatureArticle)
                  .WithMany(d => d.ArticleNomenclature)
                  .HasForeignKey<long?>(a => a.NomenclatureIdarticle);
            }
    }
}
