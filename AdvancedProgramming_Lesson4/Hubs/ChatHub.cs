using System;
using System.Threading.Tasks;
using AdvancedProgramming_Lesson4.Data;
using AdvancedProgramming_Lesson4.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AdvancedProgramming_Lesson4.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;

        public ChatHub(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task SendMessage(string user, string message, string isLogin)
        {
            var messages = new Messages(user, message, isLogin);
            _context.Add(messages);
            await _context.SaveChangesAsync();
            await Clients.All.SendAsync("ReceiveMessage", user, message, isLogin);
        }
    }
}
