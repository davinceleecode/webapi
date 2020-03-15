namespace webapi.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using webapi.DataAccess.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<webapi.DataAccess.StatsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(webapi.DataAccess.StatsDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            var p1 = new Player { FirstName = "Vincent", LastName = "Flores", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p2 = new Player { FirstName = "Romeo", LastName = "Patindol", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p3 = new Player { FirstName = "Rio", LastName = "Cinco", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p4 = new Player { FirstName = "Eco", LastName = "Gutierrez", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };


            var t1 = new Team { Name = "Rhinos", CreatedDate = DateTime.Now, Players = new List<Player> { p1, p2 }, UpdatedDate = DateTime.Now };
            var t2 = new Team { Name = "Eagles", CreatedDate = DateTime.Now, Players = new List<Player> { p3, p4 }, UpdatedDate = DateTime.Now };

            p1.Team = t1;
            p2.Team = t1;
            p3.Team = t2;
            p4.Team = t2;


            var game = new Game { AwayTeam = t1, HomeTeam = t2, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, StartTime = DateTime.Now };

            context.Players.Add(p1);
            context.Players.Add(p2);
            context.Players.Add(p3);
            context.Players.Add(p4);
            context.Teams.Add(t1);
            context.Teams.Add(t2);
            context.Games.Add(game);
        }
    }
}
