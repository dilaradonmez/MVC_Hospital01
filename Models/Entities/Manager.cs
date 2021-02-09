using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Hospital.Models.Entities
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string ManagerLastName{ get; set; }

        public virtual List<Doctor> Doctors { get; set; }
    }
}