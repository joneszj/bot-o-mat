using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.API.Modles;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public interface IErrandService
    {
        Task<PerformErrandResult> PerformErrand(ICanPerformErrand actor, ErrandType errandType);
    }
}
