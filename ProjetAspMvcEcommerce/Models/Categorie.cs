//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetAspMvcEcommerce.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]
    public partial class Categorie
    {
        public Categorie()
        {
            this.Articles = new HashSet<Article>();
        }
        [DataMember]
        public int RefCat { get; set; }
        [DataMember]
        public string Nomcatg { get; set; }
        [DataMember]

        public virtual ICollection<Article> Articles { get; set; }
    }
}
