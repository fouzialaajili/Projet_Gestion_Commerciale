using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
   public  class PivotCategorie
    {
        public long  CategorieId { get; set; }
        public string CategorieLibelle { get; set; }
    public string CategorieDescription
    { get; set; }
        public int CategorieSysuser { get; set; }
        public DateTime CategorieSysDateCreation { get; set; }
        public DateTime CategorieSysDateUpdate { get; set; }
        public bool CategorieActif{ get; set; }
    public long  CategorieSocieteId { get; set; }
        public PivotDossiers CategorieSociete { get; set; }
        public ICollection<PivotArticle> CategorieArticle { get; set; }
    }
}
