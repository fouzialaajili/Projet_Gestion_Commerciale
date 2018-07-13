using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Tolerance
    {
        public long  ToleranceId { get; set; }
       public int ToleranceEntier { get; set; }

      public long ToleranceSocieteId { get; set; }
        public virtual Societe ToleranceSociete { get; set; }

  }
}

