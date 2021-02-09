using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Hospital.Models.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorLastName { get; set; }
        public int ManagerId { get; set; }
        public int DepartmentId { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<DoctorAndPatient> DoctorAndPatients { get; set; }
    }
}