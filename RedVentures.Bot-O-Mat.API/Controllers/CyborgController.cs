﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonPatterns.Filters;
using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Mvc;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.API.Modles;
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
        private readonly IErrandService _errandService;

        public CyborgController(HelpersManager helperManager, ICyborgService cyborgService, IErrandService errandService)
        {
            _helpersManager = helperManager;
            _cyborgService = cyborgService;
            _errandService = errandService;
        }
        #endregion

        #region public members
        [HttpGet("{id}")]
        public async Task<ActionResult<CyborgViewModel>> Get(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var robot = new CyborgViewModel(await _cyborgService.GetCyborg(id));
            if (robot == null) return NotFound();
            return new CyborgViewModel(await _cyborgService.GetCyborg(id));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CyborgViewModel>>> Get()
        {
            var cacheResponse = _helpersManager.Cache.TryGet<Tuple<DateTime, ActorType>, CyborgViewModel[]>(new Tuple<DateTime, ActorType>(DateTime.Today, ActorType.Cyborg), out bool IsFound);
            if (IsFound) return Ok(await Task.FromResult(cacheResponse));
            else return Ok(await RefreshCache());
        }

        [ServiceFilter(typeof(RefreshCyborgCacheFilter))]
        [HttpPost]
        public async Task<ActionResult<CyborgViewModel>> Post([FromBody] CyborgViewModel cyborg)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(new CyborgViewModel(await _cyborgService.CreateCyborg(cyborg.Name, cyborg.Gender)));
        }

        [ServiceFilter(typeof(RefreshCyborgCacheFilter))]
        [HttpPut]
        public async Task<ActionResult<PerformErrandResult>> Put([FromBody] PerformErrandViewModel performErrandViewModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var cyborg = await _cyborgService.GetCyborg(performErrandViewModel.ActorId);
            if (cyborg == null) return NotFound();
            return await _errandService.PerformErrand(cyborg, performErrandViewModel.ErrandType);
        }

        [ServiceFilter(typeof(RefreshCyborgCacheFilter))]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _cyborgService.ScrapCyborg(id);
            return Ok();
        }
        #endregion

        #region helpers
        private async Task<CyborgViewModel[]> RefreshCache()
        {
            var robots = await _cyborgService.GetCyborgsBy(string.Empty, null);
            return _helpersManager.Cache.Set((DateTime.Today, ActorType.Cyborg), robots.Select(e => new CyborgViewModel(e)).ToArray());
        } 
        #endregion
    }
}
