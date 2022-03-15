using System;
using System.Collections.Generic;

namespace Hospital_Patient_system.Models
{
    public partial class PatientReport
    {
        public int ReportNo { get; set; }
        public int? PatientNo { get; set; }
        public double PatientWeight { get; set; }
        public string? BloodPressure { get; set; }
        public int? CholestrolHdl { get; set; }
        public int? CholestrolLdl { get; set; }
        public int? SugarFasting { get; set; }
        public int? SugarPostFasting { get; set; }
        public string? MedicineSubscribed { get; set; }
        public DateTime NextAppointmentDate { get; set; }
        public int? NextAppointmentFees { get; set; }

        public virtual PatientInfo? PatientNoNavigation { get; set; }
    }
}
