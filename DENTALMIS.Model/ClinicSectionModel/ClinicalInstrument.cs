//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DENTALMIS.Utility.HelperModel;

namespace DENTALMIS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClinicalInstrument :SearchModel<ClinicalInstrument>
    {
        public int InstrumentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Market { get; set; }
        public bool IsActive { get; set; }
    }
}
