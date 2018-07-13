using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Tolerance
    {
        public int ToleranceId { get; set; }
       public int ToleranceEntier { get; set; }
       public int ZenSocieteId { get; set; }
        virtual public Societe Societe { get; set; }
  }
}

