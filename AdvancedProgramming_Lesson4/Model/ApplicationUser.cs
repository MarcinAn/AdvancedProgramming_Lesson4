using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson4.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Id { get; set; }
        public string Email { get; set; }
    }
}
