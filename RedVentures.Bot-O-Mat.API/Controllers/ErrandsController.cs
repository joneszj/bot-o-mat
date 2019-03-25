using System.Threading.Tasks;
using CommonPatterns.Filters;
using Microsoft.AspNetCore.Mvc;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Models;
using RedVentures.Bot_O_Mat.API.Services;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class ErrandsController : ControllerBase
    {
        private readonly BotOMatContext _botOMatContext;
        private readonly IErrandService _errandService;

        public ErrandsController(BotOMatContext botOMatContext, IErrandService errandService)
        {
            _botOMatContext = botOMatContext;
            _errandService = errandService;
        }

        // POST: api/Errands
        [HttpPost]
        public async Task<ActionResult<PerformErrandResult>> Post([FromBody] PerformErrandViewModel performErrandViewModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var actor = await _botOMatContext.ErrandActors.FindAsync(performErrandViewModel.ActorId);
            if (actor == null) return NotFound();
            return Ok(await _errandService.PerformErrand(actor, performErrandViewModel.ErrandType));
        }
    }
}
