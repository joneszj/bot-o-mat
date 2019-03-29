using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Hubs
{
    public interface INotificationHub
    {
        Task OnConnectedAsync();
        Task SendMessage(string message);
    }
}