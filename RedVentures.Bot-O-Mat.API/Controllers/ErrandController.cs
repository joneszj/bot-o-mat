using System;
using System.Threading.Tasks;
using CommonPatterns.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Hubs;
using RedVentures.Bot_O_Mat.API.Models;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class ErrandController : ControllerBase
    {
        #region ctor && private
        private readonly BotOMatContext _botOMatContext;
        private readonly IErrandService _errandService;
        private readonly IHubContext<NotificationHub> _notificationHub;

        public ErrandController(BotOMatContext botOMatContext, IErrandService errandService, IHubContext<NotificationHub> notificationHub)
        {
            _botOMatContext = botOMatContext;
            _errandService = errandService;
            _notificationHub = notificationHub;
        }
        #endregion

        [HttpPost]
        public async Task<ActionResult<PerformErrandResultViewModel>> Post([FromBody] PerformErrandViewModel performErrandViewModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var actor = await _botOMatContext.ErrandActors.Include(e => e.Errands).FirstOrDefaultAsync(e => e.Id == performErrandViewModel.ActorId);
            if (actor == null) return NotFound();
            await NotifyTaskStarted(actor, performErrandViewModel);
            var result = await _errandService.PerformErrand(actor, performErrandViewModel.ErrandType);
            await NotifyTaskCompletionStatus(result);
            return new PerformErrandResultViewModel(result);
        }

        #region helpers
        private async Task NotifyTaskCompletionStatus(PerformErrandResult result)
        {
            if (result.PerformedErrand.Status == ErrandStatus.Completed) await NotifyTaskCompleted(result);
            else await NotifyFailedTask(result);
            if (result.TerminatedActor != null) await NotifyTerminatedUnit(result);
        }

        private async Task NotifyTaskCompleted(PerformErrandResult result)
        {
            await _notificationHub.Clients.All.SendAsync("Notify", new Notification($"{result.PerformingActor.Name} ({Enum.GetName(typeof(ActorType), result.PerformingActor.ActorType)}) completed task: { Enum.GetName(typeof(ErrandType), result.PerformedErrand.Type) }!", SeverityLevel.Success));
        }

        private async Task NotifyFailedTask(PerformErrandResult result)
        {
            await _notificationHub.Clients.All.SendAsync("Notify", new Notification($"{result.PerformingActor.Name} ({Enum.GetName(typeof(ActorType), result.PerformingActor.ActorType)}) failed task: { Enum.GetName(typeof(ErrandType), result.PerformedErrand.Type) }!", SeverityLevel.Warn));
        }

        private async Task NotifyTerminatedUnit(PerformErrandResult result)
        {
            if (result.PerformingActor.Id == result.TerminatedActor.Id) await _notificationHub.Clients.All.SendAsync("Notify", new Notification($"{result.PerformingActor.Name} ({Enum.GetName(typeof(ActorType), result.PerformingActor.ActorType)}) has destroyed... itself!", SeverityLevel.Error));
            else await _notificationHub.Clients.All.SendAsync("Notify", new Notification($"{result.PerformingActor.Name} ({Enum.GetName(typeof(ActorType), result.PerformingActor.ActorType)}) has destroyed a unit ({result.TerminatedActor.Name})!", SeverityLevel.Error));
        }

        private async Task NotifyTaskStarted(Data.DbSets.Actor actor, PerformErrandViewModel errand)
        {
            await _notificationHub.Clients.All.SendAsync("Notify", new Notification($"{actor.Name} ({Enum.GetName(typeof(ActorType), actor.ActorType)}) has started task: { Enum.GetName(typeof(ErrandType), errand.ErrandType) }!", SeverityLevel.Info));
        }
        #endregion
    }
}
