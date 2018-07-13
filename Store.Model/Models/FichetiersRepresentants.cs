using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class FichetiersRepresentants
    {
        public int FichetiersRepresentantsId { get; set; }
        public string FichetiersRepresentantsNom { get; set; }
        public string FichetiersRepresentantsPrenom { get; set; }

        public string FichetiersRepresentantsAdresse { get; set; }
        public string FichetiersRepresentantsTel { get; set; }
        public string FichetiersRepresentantsGSM { get; set; }
        public string FichetiersRepresentantsFonction { get; set; }
        public string FichetiersRepresentantsEmail { get; set; }
        public string FichetiersRepresentantsVille { get; set; }
        public string FichetiersRepresentantsPays { get; set; }
        public bool FichetiersRepresentantsActif { get; set; }
        public int FichetiersRepresentantsSysuser { get; set; }

        public DateTime? FichetiersRepresentantsSysDateCreation { get; set; }
        public DateTime? FichetiersRepresentantsSysDateUpdate { get; set; }
        public FichetiersRepresentants()
        {
            FichetiersRepresentantsSysDateCreation = DateTime.Now;
        }
        public int SocieteId { get; set; }

        public Societe Societe { get; set; }
    }
}
