using RedVentures.Bot_O_Mat.API.Data.Enums;

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

        public Errand(Actor actor, ErrandType errandType)
        {
            Actor = actor;
            Type = errandType;
            Status = ErrandStatus.Not_Started;
        }

        //[ForeignKey("Actor")]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public ErrandType Type { get; set; }
        public ErrandStatus Status { get; set; }
        public int TimeToComplete { get; set; }
    }
}
