using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class MouvementStock
    {
        public int MouvementStockId { get; set; }
        public string MouvementStockCode { get; set; }
        public string MouvementStockSens { get; set; }
        public long? MouvementStockTypearticle { get; set; }
        public string MouvementStockCodebundle { get; set; }
        public int ArticlesId { get; set; }
        public int MouvementStockNiveau { get; set; }
        public DateTime? MouvementStockDatemouvement { get; set; }
        public string MouvementStockOrigine { get; set; }
        public int DocumentCommercialIddocument { get; set; }
        public string  MouvementStockStatut { get; set; }
        public string MouvementStockSerialise { get; set; }
        public int MouvementStockNumeroserie { get; set; }
        public string MouvementStockLot { get; set; }
        public int MouvementStockNumerolot { get; set; }
        public int MouvementStockQuantite { get; set; }
        public int MouvementStockCodeliaison { get; set; }
        public int  DepotId { get; set; }
        public string MouvementStockDepot { get; set; }
        public string MouvementStockMotif { get; set; }
        public string MouvementStockDescmotif { get; set; }
        public int MouvementStockSys_user { get; set; }
        public DateTime? MouvementStockSysDateCreation { get; set; }
        public DateTime? MouvementStockSysDateUpdate { get; set; }

        public MouvementStock()
        {
            MouvementStockSysDateCreation = DateTime.Now;
        }
        public int ZenSocieteId { get; set; }
        public Societe ZenSociete { get; set; }
        public Depot Depot { get; set; }
        public Articles ZenArticles { get; set; }
        public DocumentCommercial DocumentCommercial { get; set; }








    }
}
