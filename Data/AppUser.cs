using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Ogani.Data
{
    public class AppUser:IdentityUser<Guid>
    {
        public List<AppUserRole> AppUserRoles { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
