//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI_Projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hotel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hotel()
        {
            this.HotelBild = new HashSet<HotelBild>();
            this.Reise_Hotel = new HashSet<Reise_Hotel>();
        }
    
        public long HotelID { get; set; }
        public string Name { get; set; }
        public string Ort { get; set; }
        public long Land { get; set; }
        public byte Sterne { get; set; }
        public string Manager { get; set; }
        public short AnzahlZimmer { get; set; }
        public decimal TagesPreis { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
    
        public virtual Land Land1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelBild> HotelBild { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reise_Hotel> Reise_Hotel { get; set; }
    }
}