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
        public Enum PaiementType { get; set; }
        public DateTime PaiementEcheance { get; set; }
        public int PaiementSys_user { get; set; }
        public DateTime PaiementSys_DateCreation { get; set; }
        public DateTime PaiementSys_DateUpdate { get; set; }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
