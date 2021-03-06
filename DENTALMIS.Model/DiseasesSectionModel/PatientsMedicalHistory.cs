//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using DENTALMIS.Utility.HelperModel;

namespace DENTALMIS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientsMedicalHistory:SearchModel<PatientsMedicalHistory>
    {
        public int PatientHistoryId { get; set; }
        public int DiseasesId { get; set; }
        public string VitalSign { get; set; }
        public string Medicalhistory { get; set; }
        public int PatientId { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> CreatedDate { get; set; }
         [DataType(DataType.Date)]
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Disease Disease { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
