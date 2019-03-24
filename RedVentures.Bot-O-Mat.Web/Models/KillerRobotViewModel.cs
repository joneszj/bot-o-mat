using RedVentures.Bot_O_Mat.Web.DTOs;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class KillerRobotViewModel : RobotViewModel
    {
        public KillerRobotViewModel(KillBoardRecord killboardRecord) : base (killboardRecord)
        {
            KillCount = killboardRecord.KillCount;
        }

        public int KillCount { get; set; }
    }
}