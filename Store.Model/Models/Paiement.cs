using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Paiement
    {
        public int PaiementId{ get; set; }
    public string  PaiementCode
        { get; set; }
        public string PaiementIntitule { get; set; }
        public long  PaiementType { get; set; }
        public DateTime PaiementEcheance { get; set; }
        public int PaiementSysuser { get; set; }
        public DateTime PaiementSysDateCreation { get; set; }
        public DateTime PaiementSysDateUpdate { get; set; }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
