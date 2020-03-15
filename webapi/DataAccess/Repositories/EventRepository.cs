using System;
using System.Collections.Generic;
using System.Linq;
using webapi.DataAccess.Entities;
using System.Web;

namespace webapi.DataAccess.Repositories
{
    public class EventRepository : Repository<GameEvent>
    {
        public EventRepository(StatsDbContext context) : base(context)
        {

        }
    }
}