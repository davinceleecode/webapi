using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webapi.DataAccess.Entities;

namespace webapi.DataAccess.Repositories
{
    public class PlayerRepository : Repository<Player>
    {
        public PlayerRepository(StatsDbContext context) : base (context)
        {

        }
    }
}