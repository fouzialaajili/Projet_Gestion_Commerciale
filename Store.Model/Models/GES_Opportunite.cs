﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class GES_Opportunite
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

        public GES_Opportunite()
        {
            OpportuniteSysDateCreation = DateTime.Now;
        }
       /****/ public long OpportuniteSocieteId { get; set; }
        virtual public GEN_Dossiers OpportuniteSociete { get; set; }
        virtual public GEN_Tiers OpportuniteFichetier { get; set; }
        virtual public Devise OpportuniteDevise { get; set; }
        public virtual ICollection<GES_Motif> OpportuniteMotif { get; set; }
      //  public virtual ICollection<CrmContact> OpportuniteCrmContact { get; set; }
        public virtual ICollection<GES_OpportuniteDetail> OpportuniteOpportuniteDetail{ get; set; }
    }
}