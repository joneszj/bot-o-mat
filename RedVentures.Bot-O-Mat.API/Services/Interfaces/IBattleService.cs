using RedVentures.Bot_O_Mat.API.Data;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public interface IBattleService
    {
        Task<ICanPerformErrand> KillAnotherActor(ICanPerformErrand actor);
    }
}