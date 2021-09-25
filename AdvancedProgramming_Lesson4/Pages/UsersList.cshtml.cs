using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedProgramming_Lesson4.Data;
using AdvancedProgramming_Lesson4.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdvancedProgramming_Lesson4.Pages
{
    public class UsersListModel : PageModel
    {
        private ApplicationDbContext _context;

        public UsersListModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<IdentityUser> ApplicationUser { get; set; }

        public void OnGetAsync()
        {
            ApplicationUser = _context.Users.ToList();
        }
    }
}
