﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    public class DocumentCommercialPivot
    {
        public long  DocumentCommercialId { get; set; }
        public String DocumentCommercialNumeroPiece { get; set; }
        public int DocumentCommercialEtatPiece { get; set; }
        public long DocumentCommercialTypePiece { get; set; }
       public DateTime DocumentCommercialDateDocument { get; set; }
       public int  DocumentCommercialReference { get; set; }
       public Double DocumentCommercialTotalHTTC { get; set; }
        public Double DocumentCommercialTotalTVATC { get; set; }
        public Double DocumentCommercialTotalTTCTC { get; set; }
         public int DocumentCommercialDevise { get; set; }
        public Double DocumentCommercialTotalHTDevise { get; set; }
        public Double DocumentCommercialTotalTVADevise { get; set; }
        public Double DocumentCommercialTotalTTCDevise { get; set; }
        public int DocumentCommercialCoursDevise { get; set; }
       public string DocumentCommercialStatutRegelement { get; set; }
        public string DocumentCommercialCodeLiaison { get; set; }
        public string DocumentCommercialStatutDocument { get; set; }
        public string DocumentCommercialConditionGe { get; set; }
        public int DocumentCommercialSysuser { get; set; }
        public DateTime DocumentCommercialSysDateCreation { get; set; }
        public DateTime DocumentCommercialSysDateUpdate { get; set; }
      public long  DocumentCommercialSocieteId { get; set; }
        public DossiersPivot DocumentCommercialSociete { get; set; }

        public  ICollection<MouvementStockPivot> DocumentCommercialMouvementStock { get; set; }

        public  ICollection<DocumentCommercialDetailPivot> DocumentCommercialDocumentCommercialDetail { get; set; }





    }  
}
