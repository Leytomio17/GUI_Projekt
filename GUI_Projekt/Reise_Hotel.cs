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
    
    public partial class Reise_Hotel
    {
        public long Reise_Hotel_ID { get; set; }
        public long Reise { get; set; }
        public long Hotel { get; set; }
    
        public virtual Hotel Hotel1 { get; set; }
        public virtual Reise Reise1 { get; set; }
    }
}