using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Opportunite
    {
        public long OpportuniteId { get; set; }
        public int OpportuniteNumero { get; set; }
      /**/  public long OpportuniteIdtiers { get; set; }
        public DateTime? OpportuniteDateopportunite { get; set; }
     /***/   public long OpportuniteIdcommercial { get; set; }
        public string OpportuniteStatut { get; set; }
     /****/   public long OpportuniteIdDevise { get; set; }
        public int OpportuniteBudgetClient { get; set; }
        public int OpportuniteBudgetEstime { get; set; }
        public string OpportuniteLibelle { get; set; }
        public long OpportuniteSysuser { get; set; }
        public DateTime? OpportuniteSysDateCreation { get; set; }
        public DateTime? OpportuniteSysDateUpdate { get; set; }

        public Opportunite()
        {
            OpportuniteSysDateCreation = DateTime.Now;
        }
       /****/ public long OpportuniteSocieteId { get; set; }
        virtual public Societe OpportuniteSociete { get; set; }
        virtual public Fichetier OpportuniteFichetier { get; set; }
        virtual public Devise OpportuniteDevise { get; set; }


        public virtual ICollection<Motif> OpportuniteMotif { get; set; }
        public virtual ICollection<CrmContact> OpportuniteCrmContact { get; set; }
        public virtual ICollection<OpportuniteDetail> OpportuniteOpportuniteDetail{ get; set; }
    }
}
