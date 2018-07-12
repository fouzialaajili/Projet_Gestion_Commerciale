using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Parametrage
    {
        public int ParametrageId { get; set; }
        public string ParametrageCode { get; set; }
        public string ParametrageDescription { get; set; }
        public long? TypeParametrage { get; set; }
        public string ParametrageOrdre { get; set; }
        public Boolean ParametrageActif { get; set; }
        public int ParametrageSysuser { get; set; }
        public DateTime? ParametrageSysDateCreation { get; set; }
        public DateTime? ParametrageSysDateUpdate { get; set; }

        public Parametrage()
        {
            ParametrageSysDateCreation = DateTime.Now;
        }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }


    }
}
