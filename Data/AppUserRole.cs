using Microsoft.AspNetCore.Identity;
using System;

namespace Ogani.Data
{
    public class AppUserRole:IdentityUserRole<Guid>
    {
        public AppUser AppUser { set; get; } 
        public AppRole AppRole { set; get; } 
    }
}
