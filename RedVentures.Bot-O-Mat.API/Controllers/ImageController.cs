using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Hubs;
using RedVentures.Bot_O_Mat.API.Models;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    /// <summary>
    /// https://dotnetcoretutorials.com/2018/07/21/uploading-images-in-a-pure-json-api/
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        #region ctor && private
        private BotOMatContext _botOMatContext;
        private readonly IHubContext<NotificationHub> _notificationHub;

        public ImageController(BotOMatContext botOMatContext, IHubContext<NotificationHub> notificationHub)
        {
            _botOMatContext = botOMatContext;
            _notificationHub = notificationHub;
        }
        #endregion

        #region public
        [HttpPost]
        public async Task<FileContentResult> UploadImage([FromBody] ImageViewModel model)
        {
            //Depending on if you want the byte array or a memory stream, you can use the below. 
            var imageDataByteArray = Convert.FromBase64String(model.ImageData);

            var actor = await _botOMatContext.ErrandActors.FindAsync(model.ActorId);
            if (actor != null)
            {
                actor.Image = imageDataByteArray;
                await _botOMatContext.SaveChangesAsync();
                await NotifyImageUploaded();

                return File(imageDataByteArray, "image/png");
            }
            else throw new NotImplementedException();
        }

        [HttpGet("{actorId}")]
        public async Task<string> GetBase64Image(int actorId)
        {
            var actor = await _botOMatContext.ErrandActors.FindAsync(actorId);
            if (actor != null) return Convert.ToBase64String(actor.Image);
            else throw new NotImplementedException();
        } 
        #endregion

        #region helpers
        private async Task NotifyImageUploaded()
        {
            await _notificationHub.Clients.All.SendAsync("Notify", new Notification($"Image uploaded!", SeverityLevel.Success));
        } 
        #endregion
    }
}