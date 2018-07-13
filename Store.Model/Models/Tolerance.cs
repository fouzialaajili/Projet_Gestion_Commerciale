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
<<<<<<< HEAD
       public int ZenSocieteId { get; set; }
        virtual public Societe Societe { get; set; }
=======
      public long ToleranceSocieteId { get; set; }
        public virtual Societe ToleranceSociete { get; set; }
>>>>>>> 2267e92627d70391d6d45f5590325e078926f7fb
  }
}

