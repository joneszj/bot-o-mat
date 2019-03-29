using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CommonPatterns.Helpers
{
    /// <summary>
    /// SMTP Manager. <para>Requires configuration settings: Email:Host, Email:Port, Email:UserName, Email:Password</para>
    /// </summary>
    public class EmailHelper : IEmailHelper
    {
        #region ctor && private
#pragma warning disable IDE0052 // Remove unread private members
        private Guid _correlationId;
#pragma warning restore IDE0052 // Remove unread private members
        private readonly SmtpClient _smtpClient;
        public EmailHelper(Guid correlationId, IConfiguration configuration)
        {
            _correlationId = correlationId;
            _smtpClient = new SmtpClient
            {
                Host = configuration["EmailHelper:Host"],
                Port = int.Parse(configuration["EmailHelper:Port"]),
                EnableSsl = true,
                Credentials = new NetworkCredential(configuration["EmailHelper:UserName"], configuration["EmailHelper:Password"])
            };
        }
        #endregion
        #region public
        public async Task SendEmail(MailMessage mailMessage)
        {
            using (mailMessage)
            {
                await _smtpClient.SendMailAsync(mailMessage);
            }
        } 
        #endregion
    }
}
