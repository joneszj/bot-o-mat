using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;

namespace RedVentures.Bot_O_Mat.API.Data
{
    public class BotOMatContext : DbContext
    {
        public BotOMatContext(DbContextOptions options) : base(options) { }

        public DbSet<Robot> Robots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // https://docs.microsoft.com/en-us/ef/core/modeling/value-conversions
            modelBuilder
                .Entity<Robot>()
                .Property(e => e.Type)
                .HasConversion(
                    v => v.ToString(),
                    v => (RobotType)Enum.Parse(typeof(RobotType), v));
        }
    }
}
