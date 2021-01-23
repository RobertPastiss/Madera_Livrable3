﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Madera.Models
{

    public class Devis
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string LibelleDevis { get; set; }
        public string EtatDevis { get; set; }
        [ForeignKey("PlanID")]
        public int PlanID { get; set; }
        public DateTime DateDebutDevis { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal PrixTotalHtDevis { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal PrixTotalTtcDevis { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal MargeCommercialDevis { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal MargeEntrepriseDevis { get; set; }
        public int IdUtilisateurCreation { get; set; }
        public DateTime DateCreation { get; set; }
        public int IdUtilisateurModification { get; set; }
        public DateTime DateModification { get; set; }
        public DateTime DateArchivage { get; set; }
        public int ProjetID { get; set; }
        public virtual Plan Plan { get; set; }
    }

    public class SearchingDevis : Devis
    {

        public SearchingDevis(Devis devis)
        {
            this.ID = devis.ID;
            this.LibelleDevis = devis.LibelleDevis;
            this.DateCreation = devis.DateCreation;
        }

    }

    public class RechercheDevis
    {
        public int ID { get; set; }
        public string LibelleDevis { get; set; }
        public string EtatDevis { get; set; }
        public decimal PrixTotalHtDevis { get; set; }
        public decimal PrixTotalTtcDevis { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public int PlanID { get; set; }
        public int ProjetID { get; set; }

    }

    public class LignesDevis
    {
        public int PlanID { get; set; }
        public string LibelleModule { get; set; }
        public int QuantiteModule { get; set; }
        public decimal PrixModule { get; set; }
        public decimal SumModule { get; set; }
        public virtual Module Modules { get; set; }

    }

    public class ExtraDevis
    {
        public string libelleCoupePrincipal { get; set; }
        public string libelleCouverture { get; set; }
        public string libellePlancher { get; set; }
        public decimal largeurCoupePrincipal { get; set; }
        public decimal longueurCoupePrincipal { get; set; }
        public decimal prixCouverture { get; set; }
        public decimal prixPlancher { get; set; }
        public int PlanID { get; set; }
    }
}
