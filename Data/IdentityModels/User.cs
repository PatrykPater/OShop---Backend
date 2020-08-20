using Microsoft.AspNetCore.Identity;
using System;

namespace Data.IdentityModels
{
    public class User : IdentityUser
    {
        public User() : base()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
