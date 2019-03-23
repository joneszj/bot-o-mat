using System;
using System.Threading.Tasks;

namespace CommonPatterns.Helpers
{
    public interface ILoggerWrapper
    {
        void Error(string message);
        Task Fatal(Exception exception, string message);
        Task Fatal<T>(Exception exception, string message, T RemoteLogPostBody) where T : class;
        void Information(string message);
    }
}