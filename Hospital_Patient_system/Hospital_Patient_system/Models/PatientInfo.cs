using System;
using System.Collections.Generic;

namespace Hospital_Patient_system.Models
{
    public partial class PatientInfo
    {
        public PatientInfo()
        {
            DailyCollections = new HashSet<DailyCollection>();
            PatientReports = new HashSet<PatientReport>();
        }

        public int PatientNo { get; set; }
        public string? PatientName { get; set; }
        public int PatientAge { get; set; }
        public string? PatientMobNo { get; set; }
        public DateTime Appointment { get; set; }
        public int? Amount { get; set; }

        public virtual ICollection<DailyCollection> DailyCollections { get; set; }
        public virtual ICollection<PatientReport> PatientReports { get; set; }
    }
}
