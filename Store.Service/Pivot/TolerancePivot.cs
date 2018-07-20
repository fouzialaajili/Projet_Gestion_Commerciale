using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    public class TolerancePivot
    {
        public long ToleranceId { get; set; }
        public int ToleranceEntier { get; set; }

        public long ToleranceSocieteId { get; set; }
        public  GEN_Dossiers ToleranceSociete { get; set; }

    }
}
