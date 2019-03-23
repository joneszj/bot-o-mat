using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public interface IErrandService
    {
        Task<ICanPerformErrand> PerformErrand(ICanPerformErrand actor, ErrandType errandType);
    }
}
