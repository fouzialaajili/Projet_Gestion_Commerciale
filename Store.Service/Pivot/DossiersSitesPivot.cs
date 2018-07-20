﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    class DossiersSitesPivot
    {
        public long Id { get; set; }


        public string Nom { get; set; }

        public string Adresse { get; set; }


        public string Tel { get; set; }


        public string Fax { get; set; }


        public string Email { get; set; }


        public string Ville { get; set; }


        public string Pays { get; set; }

        public bool Actif { get; set; }

        public long? IdDossier { get; set; }

        public int? ParDefault { get; set; }

        public string sys_user { get; set; }

        public DateTime? sys_dateUpdate { get; set; }

        public DateTime? sys_dateCreation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<EcrituresPivot> CPT_Ecritures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PiecesPivot> CPT_Pieces { get; set; }

        public DossiersPivot GEN_Dossiers { get; set; }
    }
}
