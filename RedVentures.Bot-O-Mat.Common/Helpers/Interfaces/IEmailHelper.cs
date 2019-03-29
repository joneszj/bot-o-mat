using System.Net.Mail;
using System.Threading.Tasks;

namespace CommonPatterns.Helpers
{
    public interface IEmailHelper
    {
        Task SendEmail(MailMessage mailMessage);
    }
}