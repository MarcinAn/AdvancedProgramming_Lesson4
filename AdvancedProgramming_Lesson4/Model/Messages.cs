using AdvancedProgramming_Lesson4.Data;
using System;
using System.Collections.Generic;
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

        public string User { get; set; }
        public string Message { get; set; }
        public string IsLogin { get; set; }
    }
}
