using System;
using System.Collections.Generic;
using System.Linq;
using webapi.DataAccess.Entities;
using webapi.DataAccess.Repositories;
using System.Web;

namespace webapi.DataAccess
{
    public class StatsService : IStatsService
    {
        private Repository<Game> _games;
        private Repository<Team> _teams;
        private Repository<Player> _players;
        private Repository<GameEvent> _events;

        private StatsDbContext _context;
        public StatsService()
        {
            _context = new StatsDbContext();
        }

        public Repository<Game> Games
        {
            get
            {
                if (_games == null)
                    _games = new GameRepository(_context);

                return _games;
            }
            set => throw new NotImplementedException();
        }
        public Repository<Team> Teams
        {
            get
            {
                if (_teams == null)
                    _teams = new TeamRepository(_context);

                return _teams;
            }
            set => throw new NotImplementedException();
        }
        public Repository<Player> Players
        {
            get
            {
                if (_players == null)
                    _players = new PlayerRepository(_context);

                return _players;
            }
            set => throw new NotImplementedException();
        }
        public Repository<GameEvent> Events
        {
            get
            {
                if (_events == null)
                    _events = new EventRepository(_context);

                return _events;
            }
            set => throw new NotImplementedException();
        }
    }
}