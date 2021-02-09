using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Hospital.Models.Entities
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string UserName { get; set; }


        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<AppUserAndRole> AppUserAndRoles { get; set; }
    }
}