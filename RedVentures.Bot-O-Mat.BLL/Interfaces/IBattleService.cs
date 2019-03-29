using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Interfaces
{
    public interface IBattleService
    {
        Task<ICanBeDestroyed> DestroyAnotherActor(ICanPerformErrand actor);
    }
}