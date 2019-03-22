using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;

namespace RedVentures.Bot_O_Mat.API.Data
{
    public class BotOMatContext : DbContext
    {
        public BotOMatContext(DbContextOptions options) : base(options) { }
    }
}
