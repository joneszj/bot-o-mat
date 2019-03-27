using RedVentures.Bot_O_Mat.API.Models;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public interface IKillBoardService
    {
        Task<KillBoardViewModel> GetKillCounts();
    }
}
