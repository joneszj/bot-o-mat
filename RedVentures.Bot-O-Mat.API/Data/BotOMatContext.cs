using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RedVentures.Bot_O_Mat.API.Data
{
    public class BotOMatContext : DbContext
    {
        public BotOMatContext(DbContextOptions options) : base(options) { }

        public DbSet<Robot> Robots { get; set; }
        public DbSet<Cyborg> Cyborgs { get; set; }
        public DbSet<Errand> Errands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region enum conversions
            // https://docs.microsoft.com/en-us/ef/core/modeling/value-conversions
            modelBuilder
                .Entity<Robot>()
                .Property(e => e.Type)
                .HasConversion(
                    v => v.ToString(),
                    v => (RobotType)Enum.Parse(typeof(RobotType), v));

            modelBuilder
                .Entity<Cyborg>()
                .Property(e => e.Gender)
                .HasConversion(
                    v => v.ToString(),
                    v => (Gender)Enum.Parse(typeof(Gender), v));

            modelBuilder
                .Entity<Errand>()
                .Property(e => e.Status)
                .HasConversion(
                    v => v.ToString(),
                    v => (ErrandStatus)Enum.Parse(typeof(ErrandStatus), v)); 
            #endregion

            #region relationship maps
            modelBuilder
                .Entity<Robot>()
                .HasMany(e => e.Errands)
                .WithOne(e => (Robot)e.Actor)
                .HasForeignKey(e => e.ActorId);

            modelBuilder
                .Entity<Cyborg>()
                .HasMany(e => e.Errands)
                .WithOne(e => (Cyborg)e.Actor)
                .HasForeignKey(e => e.ActorId);
            #endregion

            #region discriminator maps
            //https://www.learnentityframeworkcore.com/configuration/fluent-api/hasdiscriminator-method
            modelBuilder.Entity<ErrandActor>()
                .HasDiscriminator<ActorType>("ActorType")
                .HasValue<Robot>(ActorType.Robot)
                .HasValue<Cyborg>(ActorType.Cyborg); 
            #endregion

            //Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            var robots = new List<Robot>();

            Array errandTypeValues = Enum.GetValues(typeof(ErrandType));
            Array errandStatusValues = Enum.GetValues(typeof(ErrandType));
            Random random = new Random();

            var errands = new List<Errand>();
            var errandId = 0;

            foreach (var i in Enumerable.Range(1, 200))
            {
                var robot = new Robot
                {
                    Id = i,
                    Name = Faker.Name.FullName(),
                    Errands = errands
                };

                foreach (var y in Enumerable.Range(2, random.Next(1, 10)))
                {
                    errands.Add(new Errand
                    {
                        Id = ++errandId,
                        ActorId = robot.Id,
                        Actor = robot,
                        Type = (ErrandType)errandTypeValues.GetValue(random.Next(errandTypeValues.Length)),
                        Status = (ErrandStatus)errandStatusValues.GetValue(random.Next(errandStatusValues.Length))
                    });
                };

                robots.Add(robot);
            };

            modelBuilder.Entity<Robot>().HasData(robots);
        }
    }
}
