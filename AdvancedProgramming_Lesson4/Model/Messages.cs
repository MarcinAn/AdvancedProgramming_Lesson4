using AdvancedProgramming_Lesson4.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson4.Model
{
    public class Messages
    {
        public Messages(string user, string message, string isLogin)
        {
            User = user;
            Message = message;
            IsLogin = isLogin;
        }

        
        public int Id { get; set; }

        [Display(Name = "Użytkownik")]
        public string User { get; set; }
        [Display(Name = "Wiadomość")]
        public string Message { get; set; }
        [Display(Name = "Login")]
        public string IsLogin { get; set; }
    }
}
