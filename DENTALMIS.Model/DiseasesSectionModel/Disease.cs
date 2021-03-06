//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DENTALMIS.Model;
using DENTALMIS.Utility.HelperModel;


namespace DENTALMIS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Disease:SearchModel<Disease>
    {
        public Disease()
        {
            this.DiseasesManagements = new HashSet<DiseasesManagement>();
            this.Patients = new HashSet<Patient>();
            this.PatientConditions = new HashSet<PatientCondition>();
            this.PatientsMedicalHistories = new HashSet<PatientsMedicalHistory>();
        }
        public int DiseasesId { get; set; }
        [DisplayName("Diseases Name")]
        [Required]
        public string Name { get; set; }
            [Required]
        public string Aetiology { get; set; }
            [Required]
        public string Pathophysiology { get; set; }
        public bool IsActive { get; set; }
            [Required]
        public int DiseasesInvestigationId { get; set; }

            public virtual DiseasesInvestigation DiseasesInvestigation { get; set; }
            public virtual ICollection<DiseasesManagement> DiseasesManagements { get; set; }
            public virtual ICollection<Patient> Patients { get; set; }
            public virtual ICollection<PatientCondition> PatientConditions { get; set; }
            public virtual ICollection<PatientsMedicalHistory> PatientsMedicalHistories { get; set; }
    }
}
