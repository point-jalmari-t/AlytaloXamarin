//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlytaloMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Termostaatti
    {
        public int LampotilaID { get; set; }
        public Nullable<int> TalonTavoiteLampotila { get; set; }
        public Nullable<int> TalonNykyLampotila { get; set; }
    }
}
