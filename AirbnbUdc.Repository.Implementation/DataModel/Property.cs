//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirbnbUdc.Repository.Implementation.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            this.Reservation = new HashSet<Reservation>();
            this.PropertyMultimedia = new HashSet<PropertyMultimedia>();
        }
    
        public long Id { get; set; }
        public string PropertyAddress { get; set; }
        public int CityId { get; set; }
        public int CustomerAmount { get; set; }
        public decimal Price { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public long OwnerId { get; set; }
        public string CheckinData { get; set; }
        public string CheckoutData { get; set; }
        public string Details { get; set; }
        public bool Pets { get; set; }
        public bool Freezer { get; set; }
        public bool LaundryService { get; set; }
    
        public virtual City City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyMultimedia> PropertyMultimedia { get; set; }
        public virtual PropertyOwner PropertyOwner { get; set; }
    }
}
