using Store.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
   public  class DocumentCommercialDetailSerie
    {
       public int DocumentCommercialDetailSerieId { get; set; }
        public double DocumentCommercialDetailSerieNumeroSerie { get; set; }
   public string DocumentCommercialDetailSerieNumeroLot { get; set; }
        public bool DocumentCommercialDetailSerieGarantie { get; set; }
     public DateTime   DocumentCommercialDetailSerieDateFinMaintenance { get; set; }
        public int DocumentCommercialDetailSerieSys_user { get; set; }
        public DateTime DocumentCommercialDetailSerieSys_DateCreation { get; set; }
        public DateTime DocumentCommercialDetailSerieSys_DateUpdate { get; set; }
    
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
        public int DocumentCommercialDetailIdDocumentDetail { get; set; }
        public DocumentCommercialDetail DocumentCommercialDetail { get; set; }

    }
}
