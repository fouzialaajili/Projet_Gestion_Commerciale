﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    class ExercicesPivot
    {
        public long Id { get; set; }


        public string CodeExercice { get; set; }

        public string Libelle { get; set; }


        public DateTime? DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        public bool Actif { get; set; }

        public int? ComptaCloture { get; set; }

        public int? GescomCloture { get; set; }

        public int? PaieCloture { get; set; }

        public long? IdDossier { get; set; }

        public string sys_user { get; set; }

        public DateTime? sys_dateUpdate { get; set; }

        public DateTime? sys_dateCreation { get; set; }

        public  DossiersPivot GEN_Dossiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PeriodesPivot> GEN_Periodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PreferencesPivot> GEN_Preferences { get; set; }
    }
}
