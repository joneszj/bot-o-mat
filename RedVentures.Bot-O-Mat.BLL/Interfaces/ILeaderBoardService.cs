using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Interfaces
{
    public interface ILeaderBoardService
    {
        Task<LeaderBoardViewModel> GetLeaderBoard();
    }
}