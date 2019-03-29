using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.BLL.DTOs;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Interfaces
{
    public interface IErrandService
    {
        Task<ErrandDTO> PerformErrand(ICanPerformErrand actor, ErrandType errandType);
    }
}
