using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    class RegelementPivot
    {
        public long Id { get; set; }

        public DateTime? DateReglement { get; set; }

        public string NumPiece { get; set; }

        public long? IdJournal { get; set; }

        public long? IdModePaiement { get; set; }

        public string Libelle { get; set; }

        public double? Montant { get; set; }

        public double? Solde { get; set; }

        public string Liaison { get; set; }

        public virtual CPT_Journaux CPT_Journaux { get; set; }

        public virtual GEN_TypePaiement GEN_TypePaiement { get; set; }
    }
}
