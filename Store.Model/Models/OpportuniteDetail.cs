using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class OpportuniteDetail
    {
        public int OpportuniteDetailId { get; set; }
        public int OpportuniteId { get; set; }
        public long? OpportuniteDetailType_action { get; set; }
        public int FichetiersIdcommercial { get; set; }
        public DateTime?  OpportuniteDetailDateaction { get; set; }
        public DateTime? OpportuniteDetailHeureaction { get; set; }
        public string OpportuniteDetailDescription { get; set; }
        public int OpportuniteDetailSysuser { get; set; }
        public DateTime? OpportuniteDetailSysDateCreation { get; set; }
        public DateTime? OpportuniteDetailSysDateUpdate { get; set; }
        public Fichetiers Fichetiers { get; set; }
        public Opportunite Opportunite { get; set; }
        public OpportuniteDetail()
        {
            OpportuniteDetailSysDateCreation = DateTime.Now;
        }



    }
}
