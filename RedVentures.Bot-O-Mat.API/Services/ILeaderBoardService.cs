using System.Threading.Tasks;
using RedVentures.Bot_O_Mat.API.Modles;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public interface ILeaderBoardService
    {
        Task<LeaderBoardViewModel> GetLeaderBoard();
    }
}