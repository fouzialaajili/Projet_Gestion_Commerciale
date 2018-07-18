namespace Store.Model
{
    using System;
    using System.Collections.Generic;


    public partial class GEN_Dossiers
    {
      

        public long DossierId { get; set; }
        public string CodeDossier { get; set; }

        public string DossierRaisonSociale { get; set; }
        public int? IdTypeDossier { get; set; }

        public string DossierAdresse { get; set; }

        public string DossierTel { get; set; }

        public string DossierFax { get; set; }

        public string DossierEmail { get; set; }

        public string DossierVille { get; set; }

        public string DossierPays { get; set; }

        public string DossierSiteWeb { get; set; }

        public string DossierCapitalSocial { get; set; }

        public int? IdDeviseTenueCompte { get; set; }


        public string DossierIdentifiantFiscale { get; set; }

        public string DossierIdentifiantTVA { get; set; }

        public string DossierPatente { get; set; }

        public string DossierRegistreCommerce { get; set; }

        public string DossierNumeroCNSS { get; set; }

        public string DossierICE { get; set; }

        public int? DossierComptaActif { get; set; }

        public int? DossierGescomAtif { get; set; }

        public int? DossierPaieActif { get; set; }

        public bool DossierActif { get; set; }

        public string DossierCleSecuriteCompta { get; set; }

        public string DossierCleSecuritePaie { get; set; }

        public string DossierCleSecuriteGescom { get; set; }

        public string DossierCleSecurite { get; set; }

        public string Dossiersys_user { get; set; }

        public DateTime? Dossiersys_dateUpdate { get; set; }

        public DateTime? Dossiersys_dateCreation { get; set; }

        public virtual GEN_Societes GEN_Societes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPT_Classe> CPT_Classe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPT_CodesTVA> CPT_CodesTVA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPT_CompteG> CPT_CompteG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPT_ComptesBancaires> CPT_ComptesBancaires { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPT_Journaux> CPT_Journaux { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPT_ParametrageComptable> CPT_ParametrageComptable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPT_Pieces> CPT_Pieces { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_Devises> GEN_Devises { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_Documents> GEN_Documents { get; set; }

      

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_DossiersContacts> GEN_DossiersContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_DossiersSites> GEN_DossiersSites { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_Exercices> GEN_Exercices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_Numeration> GEN_Numeration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_Preferences> GEN_Preferences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_Tiers> GEN_Tiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_TypePaiement> GEN_TypePaiement { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GES_Motif> GES_Motif { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GES_MotifTicket> GES_MotifTicket { get; set; }




    }
}
