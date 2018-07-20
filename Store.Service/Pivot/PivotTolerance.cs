using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    public class PivotTolerance
    {
        public long  ToleranceId { get; set; }
       public int ToleranceEntier { get; set; }

      public long ToleranceSocieteId { get; set; }
        public PivotDossiers ToleranceSociete { get; set; }

  }
}

