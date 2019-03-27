using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonPatterns.Filters;
using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Models;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly HelpersManager _helperManager;
        private readonly BotOMatContext _botOMatContext;

        public ActorController(HelpersManager helperManager, BotOMatContext botOMatContext)
        {
            _helperManager = helperManager;
            _botOMatContext = botOMatContext;
        }

        // GET: api/Actor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActorDetailsViewModel>> Get(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var actor = await _botOMatContext.ErrandActors.Include(e=>e.Errands).FirstOrDefaultAsync(e=>e.Id == id);
            if (actor == null) return NotFound();
            else return Ok(new ActorDetailsViewModel(actor));
        }
    }
}
