using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Hubs
{
    public class NotificationHub : Hub, INotificationHub
    {
        public async Task SendMessage(string message)
        {
            await Clients.Group("SignalR Users").SendAsync("Send", message);
            await Clients.All.SendAsync("Send", message);
        }

        public override async Task OnConnectedAsync()
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, "SignalR Users");
            await base.OnConnectedAsync();
        }
    }
}
