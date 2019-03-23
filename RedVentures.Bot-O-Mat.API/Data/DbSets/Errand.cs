using RedVentures.Bot_O_Mat.API.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedVentures.Bot_O_Mat.API.Data.DbSets
{
    /// <summary>
    /// represents an entities errent start/completion status
    /// </summary>
    public class Errand : Base
    {
        /// <summary>
        /// required for ef
        /// </summary>
        public Errand()
        {

        }

        public Errand(Robot robot, ErrandType errandType)
        {
            Actor = robot;
            Type = errandType;
            Status = ErrandStatus.Not_Started;
        }

        //[ForeignKey("Actor")]
        public int ActorId { get; set; }
        public ICanPerformErrand Actor { get; set; }
        public ErrandType Type { get; set; }
        public ErrandStatus Status { get; set; }
        public int TimeToComplete { get; set; }
    }
}
