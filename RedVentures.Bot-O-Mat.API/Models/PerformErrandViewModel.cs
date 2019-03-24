﻿using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class PerformErrandViewModel
    {
        public int ActorId { get; set; }
        public ErrandType ErrandType { get; set; }
    }
}