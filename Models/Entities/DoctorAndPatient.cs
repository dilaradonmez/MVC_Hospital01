using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Hospital.Models.Entities
{
    public class DoctorAndPatient
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}