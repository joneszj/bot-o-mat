using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonPatterns.Filters;
using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.API.Hubs;
using RedVentures.Bot_O_Mat.API.Models;
using RedVentures.Bot_O_Mat.API.Services;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class CyborgController : ControllerBase
    {
        #region constructor && private members
        private readonly HelpersManager _helpersManager;
        private readonly ICyborgService _cyborgService;
        private readonly IHubContext<NotificationHub> _notificationHub;

        public CyborgController(HelpersManager helperManager, ICyborgService cyborgService, IHubContext<NotificationHub> notificationHub)
        {
            _helpersManager = helperManager;
            _cyborgService = cyborgService;
            _notificationHub = notificationHub;
        }
        #endregion

        #region public members
        [HttpGet("{id}")]
        public async Task<ActionResult<CyborgViewModel>> Get(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var cyborg = await _cyborgService.GetCyborg(id);
            if (cyborg == null) return NotFound();
            return Ok(new CyborgViewModel(await _cyborgService.GetCyborg(id)));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CyborgViewModel>>> Get()
        {
            var cacheResponse = _helpersManager.Cache.TryGet<Tuple<DateTime, ActorType>, CyborgViewModel[]>(new Tuple<DateTime, ActorType>(DateTime.Today, ActorType.Cyborg), out bool IsFound);
            if (IsFound) return Ok(await Task.FromResult(cacheResponse));
            else return Ok(await RefreshCache());
        }

        //[ServiceFilter(typeof(RefreshCyborgCacheFilter))]
        [HttpPost]
        public async Task<ActionResult<CyborgViewModel>> Post([FromBody] CyborgViewModel cyborg)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var newCyborg = await _cyborgService.CreateCyborg(cyborg.Name, cyborg.Gender);
            await _notificationHub.Clients.All.SendAsync("Notify", new Notification($"{cyborg.Name} (Cyborg) created!", SeverityLevel.Success));
            return Ok(new CyborgViewModel(newCyborg));

        }

        //[ServiceFilter(typeof(RefreshCyborgCacheFilter))]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var cyborg = await _cyborgService.ScrapCyborg(id);
            await _notificationHub.Clients.All.SendAsync("Notify", new Notification($"{cyborg.Name} deactivated!", SeverityLevel.Info));
            return Ok();
        }
        #endregion

        #region helpers
        private async Task<CyborgViewModel[]> RefreshCache()
        {
            var cyborgs = await _cyborgService.GetCyborgsBy(string.Empty, null);
            return cyborgs.Select(e => new CyborgViewModel(e)).ToArray();
            //TODO: determine better caching process, perhaps at the services layer instead the api boundary
            //return _helpersManager.Cache.Set((DateTime.Today, ActorType.Cyborg), robots.Select(e => new CyborgViewModel(e)).ToArray());
        } 
        #endregion
    }
}
