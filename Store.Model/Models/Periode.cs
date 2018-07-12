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

    public DateTime PeriodeDate_debut { get; set; }
        public DateTime PeriodeDate_fin { get; set; }
        public int PeriodeSys_user { get; set; }
        public DateTime PeriodeSys_DateCreation { get; set; }
        public DateTime PeriodeSys_DateUpdate { get; set; }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
