using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi.DataAccess.Entities;
using webapi.DataAccess.Repositories;
using webapi.DataAccess;
using webapi.Models;
using webapi.Filters;

namespace webapi.Controllers
{
    public class PlayerController : BaseApiController
    {
        public PlayerController(IModelFactory modelFactory, IStatsService statsService)
            : base(modelFactory, statsService)
        {
        }

        public IHttpActionResult Get()
        {
            var players = StatsService.Players.Get();
            var models = players.Select(ModelFactory.Create);

            //different method here but same results.
            //var models = players.Select((x) =>
            //{
            //    return new PlayerModel
            //    {
            //        FirstName = x.FirstName,
            //        LastName = x.LastName,
            //        PlayerId = x.ID,
            //        TeamId = x.Team.ID,
            //        TeamName = x.Team.Name
            //    };
            //});

            return Ok(models);
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                var player = StatsService.Players.Get(id);
                var model = ModelFactory.Create(player);

                return Ok(model);
            }
            catch (Exception ex)
            {
                //Logging
#if DEBUG
                return InternalServerError(ex);
#endif
                return InternalServerError();
            }
        }

        [ModelValidator]
        public IHttpActionResult Post([FromBody]PlayerModel playerModel)
        {
            //must implement it in actionfilters
            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);

            var playerEntity = ModelFactory.Create(playerModel);
            var player = StatsService.Players.Insert(playerEntity);

            var model = ModelFactory.Create(player);
            return Created($"https://localhost:44392/{model.PlayerId}", model);
        }

        [ModelValidator]
        public IHttpActionResult Put([FromBody]PlayerModel playerModel)
        {
            try
            {
                var playerEntity = ModelFactory.Create(playerModel);
                var player = StatsService.Players.Update(playerEntity);

                var model = ModelFactory.Create(player);
                return Ok(model);
            }
            catch (Exception ex)
            {
                //Logging
#if DEBUG
                return InternalServerError(ex);
#endif
                return InternalServerError();
            }
        }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                var playerEntity = StatsService.Players.Get(id);
                if (playerEntity != null)
                    StatsService.Players.Delete(playerEntity);
                else
                    return NotFound();

                return Ok();
            }
            catch (Exception ex)
            {
                //Logging
#if DEBUG
                return InternalServerError(ex);
#endif
                return InternalServerError();
            }
        }
    }
}
