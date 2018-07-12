using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
   public  class Categorie
    {
        public int CategorieId { get; set; }
        public string CategorieLibelle { get; set; }
    public string CategorieDescription
    { get; set; }
        public int CategorieSysuser { get; set; }
        public DateTime CategorieSysDateCreation { get; set; }
        public DateTime CategorieSysDateUpdate { get; set; }
        public bool CategorieActif{ get; set; }
    public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
