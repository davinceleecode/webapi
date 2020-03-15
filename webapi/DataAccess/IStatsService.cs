using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using webapi.DataAccess.Entities;
using webapi.DataAccess.Repositories;
using System.Threading.Tasks;

namespace webapi.DataAccess
{
    public interface IStatsService
    {
        Repository<Game> Games { get; set; }
        Repository<Team> Teams { get; set; }
        Repository<Player> Players { get; set; }
        Repository<GameEvent> Events { get; set; }
    }
}
