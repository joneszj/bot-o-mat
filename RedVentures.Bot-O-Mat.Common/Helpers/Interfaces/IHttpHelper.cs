using System.Net.Http;
using System.Threading.Tasks;

namespace CommonPatterns.Helpers
{
    public interface IHttpHelper
    {
        Task<ReturnType> Get<ReturnType>(string URI);
        Task<ReturnType> Post<PostBody, ReturnType>(string URI, PostBody httpBody, string contentType = ContentTypes.Json);
        Task<HttpResponseMessage> Post<PostBody>(string URI, PostBody httpBody, string contentType = ContentTypes.Json);
    }
}