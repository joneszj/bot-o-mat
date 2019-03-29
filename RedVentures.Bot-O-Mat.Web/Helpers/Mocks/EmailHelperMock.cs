using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CommonPatterns.Helpers.Mocks
{
    /// <summary>
    /// mocked email helper
    /// </summary>
    public class EmailHelperMock : IEmailHelper
    {
        private readonly IConfiguration _configuration;

        public EmailHelperMock(IConfiguration configuration) => _configuration = configuration;

        public async Task SendEmail(MailMessage mailMessage) => await Task.CompletedTask;
    }
}
