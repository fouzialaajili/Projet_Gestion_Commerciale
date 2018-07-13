using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Depot
    {
        public int DepotId { get; set; }

        public string DepotVille { get; set; }
        public string DepotPays { get; set; }
    public string DepotAdresse { get; set; }
        public string DepotDepot { get; set; }
        public string DepotCode{ get; set; }
        public string DepotDescription
        { get; set; }
        public int DepotSysuser { get; set; }
        public DateTime DepotSysDateCreation { get; set; }
        public DateTime DepotSysDateUpdate { get; set; }
        public bool DepotActif { get; set; }

      

        public long DepotSocieteId { get; set; }
        public virtual Societe DepotSociete { get; set; }
        public virtual ICollection<MouvementStock> DepotMouvementStock { get; set; }
        public virtual ICollection<Articles> DepotArticles { get; set; }
        public virtual ICollection<DepotContact> DepotDepotContact { get; set; }
       
    }
}
