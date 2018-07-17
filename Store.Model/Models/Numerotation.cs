using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Numerotation
    {
        public long NumerotationId { get; set; }
        public long? NumerotationType { get; set; }
        public string NumerotationExpression { get; set; }
        public int NumerotationNombre { get; set; }
        public string NumerotationValeur { get; set; }
        public int NumerotationCompteur { get; set; }
        public int NumerotationIncrement { get; set; }

        public long NumerotationSysuser { get; set; }
        public DateTime? NumerotationSysDateCreation { get; set; }
        public DateTime? NumerotationSysDateUpdate { get; set; }

        public Numerotation()
        {
            NumerotationSysDateCreation = DateTime.Now;
        }
        public long NumerotationSocieteId { get; set; }
        virtual public Societe NumerotationSociete { get; set; }
    }
}
