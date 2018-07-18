using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GES_MouvementStockConfiguration : EntityTypeConfiguration<GES_MouvementStock>
    {
        public GES_MouvementStockConfiguration()
        {
            ToTable("MouvementStock");
            HasKey(x => x.MouvementStockId);


            /***********************************/

        // virtual public GEN_Dossiers MouvementStockSociete { get; set; }
        //virtual public GES_Depot MouvementStocksDepot { get; set; }
        //virtual public GES_Article MouvementStockArticles { get; set; }
        //virtual public DocumentCommercial MouvementStockDocumentCommercial { get; set; }


        HasOptional<GEN_Dossiers>(a => a.MouvementStockSociete)
                        .WithMany(d => d.SocieteMouvementStock)
                        .HasForeignKey<long?>(a => a.MouvementStockSocieteId);

            HasOptional<GES_Depot>(a => a.MouvementStocksDepot)
                    .WithMany(d => d.DepotMouvementStock)
                    .HasForeignKey<long?>(a => a.MouvementStockIddepot);

            HasOptional<GES_Article>(a => a.MouvementStockArticles)
                  .WithMany(d => d.ArticleMouvementStock)
                  .HasForeignKey<long?>(a => a.MouvementStockIdarticle);

            HasOptional<DocumentCommercial>(a => a.MouvementStockDocumentCommercial)
                  .WithMany(d => d.DocumentCommercialMouvementStock)
                  .HasForeignKey<long?>(a => a.MouvementStockIddocument);

        }
    }
}
