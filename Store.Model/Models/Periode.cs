using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Periode
    {
        public int PeriodeId { get; set; }
    public string PeriodeIntitule { get; set; }
    public string  Periodecode{ get; set; }

    public DateTime PeriodeDatedebut { get; set; }
        public DateTime PeriodeDatefin { get; set; }
        public int PeriodeSysuser { get; set; }
        public DateTime PeriodeSysDateCreation { get; set; }
        public DateTime PeriodeSysDateUpdate { get; set; }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
