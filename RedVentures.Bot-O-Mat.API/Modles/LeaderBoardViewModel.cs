﻿using System.Collections.Generic;

namespace RedVentures.Bot_O_Mat.API.Modles
{
    public class LeaderBoardViewModel
    {
        public IEnumerable<LeaderBoardRecord> LeaderBoardRecord { get; set; }
    }

    public class LeaderBoardRecord
    {
        public string Name { get; set; }
        public string ActorType { get; set; }
        public int CompletedErrandCount { get; set; }
        public int FailedErrandCount { get; set; }
    }
}
