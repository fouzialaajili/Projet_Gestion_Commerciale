using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
   public  class Categorie
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
        public virtual Societe CategorieSociete { get; set; }
        public virtual ICollection<Articles> CategorieArticles { get; set; }
    }
}
