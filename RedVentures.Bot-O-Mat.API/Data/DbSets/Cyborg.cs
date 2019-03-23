using System;
using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Data.DbSets
{
    public class Cyborg : ErrandActor
    {
        public Gender Gender { get; set; }

        internal Cyborg Scrap()
        {
            IsActive = false;
            ModifiedDate = DateTime.Now;

            return this;
        }
    }
}
