//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NexaDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class nexaCarVarient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nexaCarVarient()
        {
            this.nexaCarPrices = new HashSet<nexaCarPrice>();
            this.nexaVarientColors = new HashSet<nexaVarientColor>();
        }
    
        public int id { get; set; }
        public string VarientName { get; set; }
        public string VarientCode { get; set; }
        public string ModelCode { get; set; }
    
        public virtual nexaCarModel nexaCarModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nexaCarPrice> nexaCarPrices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nexaVarientColor> nexaVarientColors { get; set; }
    }
}
