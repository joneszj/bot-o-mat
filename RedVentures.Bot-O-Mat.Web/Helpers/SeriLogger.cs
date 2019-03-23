using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CommonPatterns.Helpers
{
    /// <summary>
    /// Logging Service. Fatal will use send an Email and write to Logging Db
    /// </summary>
    /// Install-Package Serilog
    /// Install-Package Serilog.Sinks.Console
    /// Install-Package Serilog.Sinks.File
    public class SeriLogger : ILoggerWrapper
    {
        #region ctor && private
        private ILogger _logger { get; set; }
        private readonly string _outputTemplate;
        private readonly IConfiguration _configuration;
        private IEmailHelper _emailHelper;
        private readonly IHttpHelper _httpHelper;
        private readonly string _correlationId;

        public SeriLogger(Guid correlationId, IEmailHelper emailHelper, IHttpHelper httpHelper, IConfiguration configuration)
        {
            _configuration = configuration;
            _emailHelper = emailHelper;
            _httpHelper = httpHelper;
            _correlationId = correlationId.ToString();
            _outputTemplate = _configuration["SeriLogger:Template"];

            _logger = new LoggerConfiguration()
                .WriteTo.Console(outputTemplate: _outputTemplate)
                .WriteTo.File(configuration["SeriLogger:LogsDirectory"],
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 365,
                    outputTemplate: _outputTemplate,
                    shared: true)
                .CreateLogger()
                .ForContext("CorrelationId", _correlationId);
        }
        #endregion
        #region public
        public void Information(string message) => _logger.Information(message);
        public void Error(string message) => _logger.Error(message);
        /// <summary>
        /// local file log, email notification, remote api 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        /// <param name="RemoteLogPostBody"></param>
        /// <returns></returns>
        public async Task Fatal<T>(Exception exception, string message, T RemoteLogPostBody) where T : class
        {
            _logger.Fatal(exception, message);
            await _emailHelper.SendEmail(new MailMessage());
            var response = await _httpHelper.Post(_configuration["SeriLogger:RemoteLogAPI"], RemoteLogPostBody);
        }
        /// <summary>
        /// local file log, email notification
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        public async Task Fatal(Exception exception, string message)
        {
            _logger.Fatal(exception, message);
            await _emailHelper.SendEmail(new MailMessage());
        }
        #endregion
    }
}