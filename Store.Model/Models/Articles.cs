using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Articles
    {
        public int ArticlesId { get; set; }


        public Enum ArticlesTypeArticle { get; set; }
        public string ArticlesCodeArticle
        { get; set; }
        public string ArticlesDescription { get; set; }
        public string ArticlesDescriptif
        { get; set; }
        public string ArticlesCodeABarre { get; set; }
        public string ArticlesEstSerialiser
        { get; set; }
        public bool ArticlesEstGererEnStock { get; set; }
        public bool  ArticlesEstVendu
        { get; set; }
        public bool ArticlesEstAchat { get; set; }
    public double  ArticlesPrixAchatDefault
        { get; set; }
        public double ArticlesPrixVenteDefault { get; set; }
        public double ArticlesCoefficientMarge
        { get; set; }
        public int  ArticlesSeuilStockMin { get; set; }
        public int  ArticlesSeuilStockMax
        { get; set; }
        public bool  ArticlesGarantieMaintenance { get; set; }
    public int ArticlesGarantiemois
        { get; set; }


        public bool ArticlesPubliable { get; set; }
    public bool ArticlesActif
        { get; set; }
public string ArticlesImage
        { get; set; }
        public int ArticlesSys_user { get; set; }
        public DateTime ArticlesSys_DateCreation { get; set; }
        public DateTime ArticlesSys_DateUpdate { get; set; }
        public bool DepotActif { get; set; }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
        public int   DepotId { get; set; }
        public  Depot Depot  { get; set; }
        public int CategorieId { get; set; }
        public Categorie Categorie{ get; set; }
        public int UniteId { get; set; }
        public Unite Unite { get; set; }
        public int MarqueId { get; set; }
        public  Marque  Marque{ get; set; }

    }
}
