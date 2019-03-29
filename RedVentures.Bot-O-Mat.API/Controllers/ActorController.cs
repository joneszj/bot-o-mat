using System.Threading.Tasks;
using CommonPatterns.Filters;
using Microsoft.AspNetCore.Mvc;
using RedVentures.Bot_O_Mat.API.Models;
using RedVentures.Bot_O_Mat.BLL.Interfaces;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        #region ctor && private
        private readonly IActorService _actorService;

        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        } 
        #endregion

        [HttpGet("{id}")]
        public async Task<ActionResult<ActorDetailsViewModel>> Get(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var actor = await _actorService.GetActor(id);
            if (actor == null) return NotFound();
            else return Ok(new ActorDetailsViewModel(actor));
        }
    }
}
