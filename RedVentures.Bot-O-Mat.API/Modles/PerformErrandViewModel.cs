using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Modles
{
    public class PerformErrandViewModel
    {
        public int RobotId { get; set; }
        public ErrandType ErrandType { get; set; }
    }
}
