﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class GES_Article
    {
        public long ArticleId { get; set; }


        public long ArticleTypeArticle { get; set; }
        public string ArticleCodeArticle
        { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleDescriptif
        { get; set; }
        public string ArticleCodeABarre { get; set; }
        public string ArticleEstSerialiser
        { get; set; }
        public bool ArticleEstGererEnStock { get; set; }
        public bool  ArticleEstVendu
        { get; set; }
        public bool ArticleEstAchat { get; set; }
    public double  ArticlePrixAchatDefault
        { get; set; }
        public double ArticlePrixVenteDefault { get; set; }
        public double ArticleCoefficientMarge
        { get; set; }
        public int  ArticleSeuilStockMin { get; set; }
        public int  ArticleSeuilStockMax
        { get; set; }
        public bool  ArticleGarantieMaintenance { get; set; }
    public int ArticleGarantiemois
        { get; set; }


        public bool ArticlePubliable { get; set; }
    public bool ArticleActif
        { get; set; }
public string ArticleImage
        { get; set; }
        public int ArticleSysuser { get; set; }
        public DateTime ArticleSysDateCreation { get; set; }
        public DateTime ArticlesSysDateUpdate { get; set; }
      
        public long ArticleSocieteId { get; set; }
        public virtual GEN_Dossiers ArticleSociete { get; set; }
        public long ArticleDepotId { get; set; }
       public  virtual GES_Depot ArticleDepot { get; set; }
        public long ArticleCategorieId { get; set; }
        public virtual Categorie ArticleCategorie { get; set; }
        public long  ArticleUniteId { get; set; }
        public virtual Unite ArticleUnite { get; set; }
        public long ArticleMarqueId { get; set; }
        public  virtual Marque ArticleMarque { get; set; }

        public virtual ICollection<GES_FournisseurArticle> ArticleFournisseurArticle { get; set; }
        public virtual ICollection<GES_MouvementStock> ArticleMouvementStock { get; set; }
        public virtual ICollection<GES_Nomenclature> ArticleNomenclature { get; set; }
        public virtual ICollection<ArticlesPrix> ArticleArticlesPrix { get; set; }
        public virtual ICollection<DocumentCommercialDetail> ArticleDocumentCommercialDetail { get; set; }


    }
}
