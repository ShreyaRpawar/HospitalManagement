using System;
using System.Collections.Generic;

namespace Hospital_Patient_system.Models
{
    public partial class DailyCollection
    {
        public int RecordNo { get; set; }
        public int? PatientId { get; set; }
        public DateTime? Apdate { get; set; }
        public double? Fees { get; set; }

        public virtual PatientInfo? Patient { get; set; }
    }
}
