using System;
using System.Linq;
using System.Threading.Tasks;
using CommonPatterns.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.API.Models;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        #region ctor && private
        private readonly BotOMatContext _botOMatContext;

        public ActorController(BotOMatContext botOMatContext)
        {
            _botOMatContext = botOMatContext;
        }
        #endregion

        [HttpGet("types")]
        public ActionResult GetActoryTypes() => Ok(Enum.GetValues(typeof(ActorType)).Cast<ActorType>().Select(e => new { type = e.ToString(), id = (int)e }));

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
