﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
   public class DocumentsPivot
    {
        public long Id { get; set; }

        public string Libelle { get; set; }

        public string Tags { get; set; }

        public string Fichier { get; set; }

        public string NomObjetClasse { get; set; }

        public int IdObjet { get; set; }

        public long IdDossier { get; set; }

        public string Sys_user { get; set; }

        public DateTime? Sys_dateUpdate { get; set; }

        public DateTime? Sys_dateCreation { get; set; }

        public DossiersPivot GEN_Dossiers { get; set; }
    }
}
