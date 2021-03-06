﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    public class OpportunitePivot
    {

        public long OpportuniteId { get; set; }
        public int OpportuniteNumero { get; set; }
        /**/
        public long OpportuniteIdtiers { get; set; }
        public DateTime? OpportuniteDateopportunite { get; set; }
        /***/
        public long OpportuniteIdcommercial { get; set; }
        public string OpportuniteStatut { get; set; }
        /****/
        public long OpportuniteIdDevise { get; set; }
        public int OpportuniteBudgetClient { get; set; }
        public int OpportuniteBudgetEstime { get; set; }
        public string OpportuniteLibelle { get; set; }
        public long OpportuniteSysuser { get; set; }
        public DateTime? OpportuniteSysDateCreation { get; set; }
        public DateTime? OpportuniteSysDateUpdate { get; set; }
        /****/
        public long OpportuniteDossierd { get; set; }
       public DossiersPivot OpportuniteDossier { get; set; }
         public TiersPivot OpportuniteFichetier { get; set; }
      public DevisesPivot OpportuniteDevise { get; set; }
        public  ICollection<MotifPivot> OpportuniteMotif { get; set; }
        //  public virtual ICollection<CrmContact> OpportuniteCrmContact { get; set; }
        public  ICollection<OpportuniteDetailPivot> OpportuniteOpportuniteDetail { get; set; }
    }
}
