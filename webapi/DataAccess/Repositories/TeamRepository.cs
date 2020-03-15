using System;
using System.Collections.Generic;
using System.Linq;
using webapi.DataAccess.Entities;
using System.Web;

namespace webapi.DataAccess.Repositories
{
    public class TeamRepository : Repository<Team>
    {
        public TeamRepository(StatsDbContext context) : base(context)
        {

        }
    }
}