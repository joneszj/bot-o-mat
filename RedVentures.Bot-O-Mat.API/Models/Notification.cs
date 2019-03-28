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

        public string Message { get; set; }
        public string SeverityLevel { get; set; }
    }

    public enum SeverityLevel
    {
        Success,
        Info,
        Warn,
        Error
    }
}
