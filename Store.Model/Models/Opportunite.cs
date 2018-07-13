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
     /***/   public int OpportuniteIdcommercial { get; set; }
        public string OpportuniteStatut { get; set; }
     /****/   public int OpportuniteIdDevise { get; set; }
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
       /****/ public long SocieteId { get; set; }
        virtual public Societe Societe { get; set; }
        virtual public Fichetiers Fichetiers { get; set; }
        virtual public Devises Devises { get; set; }



        public virtual ICollection<Motif> OpportuniteMotif { get; set; }
    }
}
