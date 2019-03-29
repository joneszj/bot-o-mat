using System.Collections.Generic;

namespace RedVentures.Bot_O_Mat.Web.DTOs
{
    public class LeaderBoardViewModelDTO
    {
        public IEnumerable<LeaderBoardRecord> LeaderBoardRecord { get; set; }
    }

    public class LeaderBoardRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ActorType { get; set; }
        public int CompletedErrandCount { get; set; }
        public int FailedErrandCount { get; set; }
    }
}
