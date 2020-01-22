using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAPI.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }

        public Ailment Ailments { get; set; }
        public Medication Medications { get; set; }
    }
}
