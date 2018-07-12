using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Nomenclature
    {
        public int NomenclatureId { get; set; }
        public int ArticlenomencId { get; set; }
        public string NomenclatureLib { get; set; }
        public int NomenclatureQuantite { get; set; }
        public int NomenclatureSysuser { get; set; }
        public DateTime? NomenclatureSysDateCreation { get; set; }
        public DateTime? NomenclatureSysDateUpdate { get; set; }
        public int ArticlesId { get; set; }
        public Nomenclature()
        {
            NomenclatureSysDateCreation = DateTime.Now;
        }
        public Articles Articles { get; set; }
    }
}
