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

            #region seed
            Random random = new Random();
            int actorId = 0;
            int errandId = 0;

            //https://stackoverflow.com/a/3132151
            Array RobotTypevalues = Enum.GetValues(typeof(RobotType));
            Array ErrandStatusvalues = Enum.GetValues(typeof(ErrandStatus));
            Array ErrandTypevalues = Enum.GetValues(typeof(ErrandType));
            Array Gendervalues = Enum.GetValues(typeof(Gender));

            while (actorId <= 100)
            {
                actorId++;
                var errandcount = random.Next(1, 7);
                if (random.Next(1, 10) < 5)
                {
                    modelBuilder.Entity<Robot>().HasData(new Robot { ActorType = ActorType.Robot, Id = actorId, Name = Faker.Name.FullName(), Type = (RobotType)RobotTypevalues.GetValue(random.Next(RobotTypevalues.Length)) });
                    for (int y = 0; y < errandcount; y++)
                    {
                        modelBuilder.Entity<Errand>().HasData(new Errand { ActorId = actorId, Id = ++errandId, Status = (ErrandStatus)ErrandStatusvalues.GetValue(random.Next(ErrandStatusvalues.Length)), Type = (ErrandType)ErrandTypevalues.GetValue(random.Next(ErrandTypevalues.Length)), TimeToComplete = random.Next(1000, 25000) });
                    }
                }
                else
                {
                    modelBuilder.Entity<Cyborg>().HasData(new Cyborg { ActorType = ActorType.Cyborg, Id = actorId, Name = Faker.Name.FullName(), Gender = (Gender)Gendervalues.GetValue(random.Next(Gendervalues.Length)) });
                    for (int y = 0; y < errandcount; y++)
                    {
                        modelBuilder.Entity<Errand>().HasData(new Errand { ActorId = actorId, Id = ++errandId, Status = (ErrandStatus)ErrandStatusvalues.GetValue(random.Next(ErrandStatusvalues.Length)), Type = (ErrandType)ErrandTypevalues.GetValue(random.Next(ErrandTypevalues.Length)), TimeToComplete = random.Next(1000, 25000) });
                    }
                }
            } 
            #endregion
        }
    }
}
