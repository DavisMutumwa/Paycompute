using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace Paycompute_Services.Implementation
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
