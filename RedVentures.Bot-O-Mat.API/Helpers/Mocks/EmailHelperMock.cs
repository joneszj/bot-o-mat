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
        #region ctor && private
#pragma warning disable IDE0052 // Remove unread private members
        private readonly IConfiguration _configuration;
#pragma warning restore IDE0052 // Remove unread private members
        public EmailHelperMock(IConfiguration configuration) => _configuration = configuration; 
        #endregion

        public async Task SendEmail(MailMessage mailMessage) => await Task.CompletedTask;
    }
}
