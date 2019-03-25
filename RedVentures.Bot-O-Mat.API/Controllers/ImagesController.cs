﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Models;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    /// <summary>
    /// https://dotnetcoretutorials.com/2018/07/21/uploading-images-in-a-pure-json-api/
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private BotOMatContext _botOMatContext;

        public ImagesController(BotOMatContext botOMatContext)
        {
            _botOMatContext = botOMatContext;
        }

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
                return File(imageDataByteArray, "image/png");
            }
            else throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<string> GetBase64Image(int actorId)
        {
            var actor = await _botOMatContext.ErrandActors.FindAsync(actorId);
            if (actor != null) return Convert.ToBase64String(actor.Image);
            else throw new NotImplementedException();
        }
    }
}