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
    public partial class Commande
    {
        [DataMember]
        public int NumCmd { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateCmd { get; set; }
        [DataMember]
        public Nullable<int> QteArticle { get; set; }
        [DataMember]
        public Nullable<int> NumClient { get; set; }
        [DataMember]
        public Nullable<int> NumArticle { get; set; }
        [DataMember]

        public virtual Article Article { get; set; }
        [DataMember]
        public virtual Client Client { get; set; }
    }
}