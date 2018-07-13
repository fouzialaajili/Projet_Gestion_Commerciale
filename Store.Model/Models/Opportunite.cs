using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class Opportunite
    {
        public int OpportuniteId { get; set; }
        public int OpportuniteNumero { get; set; }
        public int FichetiersIdtiers { get; set; }
        public DateTime? OpportuniteDateopportunite { get; set; }
        public int FichetiersIdcommercial { get; set; }
        public string OpportuniteStatut { get; set; }
        public int DeviseId { get; set; }
        public int OpportuniteBudgetClient { get; set; }
        public int OpportuniteBudgetEstime { get; set; }
        public string OpportuniteLibelle { get; set; }
        public int OpportuniteSysuser { get; set; }
        public DateTime? OpportuniteSysDateCreation { get; set; }
        public DateTime? OpportuniteSysDateUpdate { get; set; }

        public Opportunite()
        {
            OpportuniteSysDateCreation = DateTime.Now;
        }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
        public Fichetiers Fichetiers { get; set; }
        public Devise Devise { get; set; }
    }
}
