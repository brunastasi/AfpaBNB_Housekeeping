//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AFPABNBADMIN
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hebergement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hebergement()
        {
            this.DispoHebergs = new HashSet<DispoHeberg>();
            this.Saisons = new HashSet<Saison>();
        }
    
        public int IdHebergement { get; set; }
        public string Nom { get; set; }
        public string Photo { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int IdAdresse { get; set; }
        public int IdClient { get; set; }
        public bool Etat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DispoHeberg> DispoHebergs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Saison> Saisons { get; set; }
    }
}
