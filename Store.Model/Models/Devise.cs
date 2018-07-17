using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Devise
    {
        public long  DeviseId { get; set; }
        public string DeviseCode { get; set; }
        public string DeviseCodeIso { get; set; }
        public string  DeviseDescription { get; set; }
        public Double DeviseCoursDevise { get; set; }
        public bool DeviseTenuedecompte { get; set; }
        public bool DeviseTenuedeActif { get; set; }
        public int DeviseSysuser { get; set; }
        public DateTime DeviseSysDateCreation { get; set; }
        public DateTime DeviseSysDateUpdate { get; set; }
        public long  DeviseSocieteId { get; set; }
        public virtual Societe DeviseSociete { get; set; }
        public virtual ICollection<Opportunite> DeviseOpportunite { get; set; }
    }
}
