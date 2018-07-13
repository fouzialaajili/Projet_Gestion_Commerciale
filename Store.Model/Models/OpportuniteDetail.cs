using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class OpportuniteDetail
    {
        public long OpportuniteDetailId { get; set; }
      /***/  public long OpportuniteDetailIdopportunite { get; set; }
        public long? OpportuniteDetailType_action { get; set; }
     /***/   public long OpportuniteDetailIdcommercial { get; set; }
        public DateTime?  OpportuniteDetailDateaction { get; set; }
        public DateTime? OpportuniteDetailHeureaction { get; set; }
        public string OpportuniteDetailDescription { get; set; }
        public long OpportuniteDetailSysuser { get; set; }
        public DateTime? OpportuniteDetailSysDateCreation { get; set; }
        public DateTime? OpportuniteDetailSysDateUpdate { get; set; }
        virtual public Fichetiers Fichetiers { get; set; }
        virtual public Opportunite Opportunite { get; set; }
        public OpportuniteDetail()
        {
            OpportuniteDetailSysDateCreation = DateTime.Now;
        }



    }
}
