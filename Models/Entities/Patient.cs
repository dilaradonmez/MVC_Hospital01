using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Hospital.Models.Entities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientLastName { get; set; }

        public virtual List<DoctorAndPatient> DoctorAndPatients { get; set; }
    }
}