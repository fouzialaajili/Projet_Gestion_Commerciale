using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Parametrage
    {
        public long ParametrageId { get; set; }
        public string ParametrageCode { get; set; }
        public string ParametrageDescription { get; set; }
        public long? TypeParametrage { get; set; }
        public string ParametrageOrdre { get; set; }
        public bool ParametrageActif { get; set; }
        public long ParametrageSysuser { get; set; }
        public DateTime? ParametrageSysDateCreation { get; set; }
        public DateTime? ParametrageSysDateUpdate { get; set; }

        public Parametrage()
        {
            ParametrageSysDateCreation = DateTime.Now;
        }
        public long ParametrageSocieteId { get; set; }
        virtual public Societe ParametrageSociete { get; set; }


    }
}
