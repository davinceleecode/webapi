using System;
using System.Collections.Generic;
using System.Linq;
using webapi.DataAccess.Entities;
using System.Web;

namespace webapi.DataAccess.Repositories
{
    public class GameRepository : Repository<Game>
    {
        public GameRepository(StatsDbContext context) : base(context)
        {

        }
    }
}