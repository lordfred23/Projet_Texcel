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
    
    public partial class tblProjet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProjet()
        {
            this.tblTravail = new HashSet<tblTravail>();
        }
    
        public int idProjet { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
        public int idJeu { get; set; }
        public string tag { get; set; }
    
        public virtual tblJeu tblJeu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTravail> tblTravail { get; set; }
    }
}