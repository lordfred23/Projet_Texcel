//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_Texcel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEmploye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEmploye()
        {
            this.tblEquipe = new HashSet<tblEquipe>();
        }
    
        public string matricule { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string dateNaissance { get; set; }
        public string adresse { get; set; }
        public string noTelephone { get; set; }
        public string posteTelephone { get; set; }
        public string noTelephoneMaison { get; set; }
        public int idRole { get; set; }
        public string tag { get; set; }
    
        public virtual tblRole tblRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEquipe> tblEquipe { get; set; }
    }
}
