using Newtonsoft.Json;
using System;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class Notification
    {
        public Notification(string message, SeverityLevel severityLevel)
        {
            Message = message;
            SeverityLevel = Enum.GetName(typeof(SeverityLevel), severityLevel);
        }

        public Notification(string message, SeverityLevel severityLevel, PerformErrandResult result) : this(message, severityLevel)
        {
            Output = JsonConvert.SerializeObject(new PerformanceUpdateNotification(result));
            OutputTyped = new PerformanceUpdateNotification(result);
        }

        public string Message { get; set; }
        public string SeverityLevel { get; set; }
        public string Output { get; set; }
        public PerformanceUpdateNotification OutputTyped { get; set; }
    }

    public enum SeverityLevel
    {
        Success,
        Info,
        Warn,
        Error
    }
}
