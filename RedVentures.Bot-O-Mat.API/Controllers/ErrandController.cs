using System.Threading.Tasks;
using CommonPatterns.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Models;
using RedVentures.Bot_O_Mat.API.Services;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class ErrandController : ControllerBase
    {
        private readonly BotOMatContext _botOMatContext;
        private readonly IErrandService _errandService;

        public ErrandController(BotOMatContext botOMatContext, IErrandService errandService)
        {
            _botOMatContext = botOMatContext;
            _errandService = errandService;
        }

        [HttpPost]
        public async Task<ActionResult<PerformErrandResultViewModel>> Post([FromBody] PerformErrandViewModel performErrandViewModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var actor = await _botOMatContext.ErrandActors.Include(e=>e.Errands).FirstOrDefaultAsync(e=>e.Id == performErrandViewModel.ActorId);
            if (actor == null) return NotFound();
            return (new PerformErrandResultViewModel(await _errandService.PerformErrand(actor, performErrandViewModel.ErrandType)));
        }
    }
}
