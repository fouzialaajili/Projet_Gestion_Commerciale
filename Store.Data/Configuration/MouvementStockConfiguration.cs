using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class MouvementStockConfiguration : EntityTypeConfiguration<MouvementStock>
    {
        public MouvementStockConfiguration()
        {
            ToTable("MouvementStock");
            HasKey(x => x.MouvementStockId);


            /***********************************/

        //   virtual public Societe MouvementStockSociete { get; set; }
        //virtual public Depot MouvementStocksDepot { get; set; }
        //virtual public Articles MouvementStockArticles { get; set; }
        //virtual public DocumentCommercial MouvementStockDocumentCommercial { get; set; }


        HasOptional<Societe>(a => a.MouvementStockSociete)
                        .WithMany(d => d.SocieteMouvementStock)
                        .HasForeignKey<long?>(a => a.MouvementStockSocieteId);

            HasOptional<Depot>(a => a.MouvementStocksDepot)
                    .WithMany(d => d.DepotMouvementStock)
                    .HasForeignKey<long?>(a => a.MouvementStockIddepot);

            HasOptional<Articles>(a => a.MouvementStockArticles)
                  .WithMany(d => d.ArticleMouvementStock)
                  .HasForeignKey<long?>(a => a.MouvementStockIdarticle);

            HasOptional<DocumentCommercial>(a => a.MouvementStockDocumentCommercial)
                  .WithMany(d => d.DocumentCommercialMouvementStock)
                  .HasForeignKey<long?>(a => a.MouvementStockIddocument);

        }
    }
}
