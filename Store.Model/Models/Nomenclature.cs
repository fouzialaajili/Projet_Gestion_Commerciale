using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Nomenclature
    {
        public long NomenclatureId { get; set; }
        public int ArticlenomencId { get; set; }
        public string NomenclatureLib { get; set; }
        public int NomenclatureQuantite { get; set; }
        public int NomenclatureSysuser { get; set; }
        public DateTime? NomenclatureSysDateCreation { get; set; }
        public DateTime? NomenclatureSysDateUpdate { get; set; }
     /***/public long NomenclatureIdarticle { get; set; }
        public Nomenclature()
        {
            NomenclatureSysDateCreation = DateTime.Now;
        }
        virtual public Articles NomenclatureArticle { get; set; }
    }
}
