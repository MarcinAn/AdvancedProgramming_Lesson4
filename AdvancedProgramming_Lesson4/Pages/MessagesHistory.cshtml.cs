using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdvancedProgramming_Lesson4.Data;
using AdvancedProgramming_Lesson4.Model;

namespace AdvancedProgramming_Lesson4.Pages
{
    public class MessagesHistoryModel : PageModel
    {
        private readonly AdvancedProgramming_Lesson4.Data.ApplicationDbContext _context;

        public MessagesHistoryModel(AdvancedProgramming_Lesson4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Messages> Messages { get;set; }

        public async Task OnGetAsync()
        {

            IQueryable<Messages> isUserLogin = from s in _context.Messages
                                             select s;

            if (!String.IsNullOrEmpty("@"))
            {
                isUserLogin = isUserLogin.Where(s => s.IsLogin.Contains("@"));
            }

            Messages = await isUserLogin.AsNoTracking().ToListAsync();
        }
    }
}
