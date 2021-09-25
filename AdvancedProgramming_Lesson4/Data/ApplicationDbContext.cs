using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AdvancedProgramming_Lesson4.Model;
using Microsoft.AspNetCore.Identity;

namespace AdvancedProgramming_Lesson4.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AdvancedProgramming_Lesson4.Model.Messages> Messages { get; set; }

    }
}
