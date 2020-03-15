using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using webapi.DataAccess.Entities;


namespace webapi.DataAccess
{
    public class StatsDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<GameEvent> Events { get; set; }

    }
}