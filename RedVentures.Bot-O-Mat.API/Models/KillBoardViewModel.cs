﻿using System.Collections.Generic;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class KillBoardViewModel
    {
        public IEnumerable<KillBoardRecord> KillBoardRecord { get; set; }
    }

    public class KillBoardRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ActorType { get; set; }
        public int KillCount { get; set; }
    }
}
