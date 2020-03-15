using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webapi.DataAccess.Entities;

namespace webapi.Models
{
    public interface IModelFactory
    {
        PlayerModel Create(Player player);
        Player Create(PlayerModel playerModel);
    }

    public class ModelFactory : IModelFactory
    {
        public PlayerModel Create(Player player)
        {
            return new PlayerModel
            {
                FirstName = player.FirstName,
                LastName = player.LastName,
                PlayerId = player.ID,
                TeamId = player.Team != null ? player.Team.ID : 0,
                TeamName = player.Team != null ? player.Team.Name : null
            };
        }

        public Player Create(PlayerModel playerModel)
        {
            if (playerModel.PlayerId == 0)
            {
                return new Player
                {
                    FirstName = playerModel.FirstName,
                    LastName = playerModel.LastName,
                    UpdatedDate = DateTime.Now
                };
            }
            return new Player
            {
                ID = playerModel.PlayerId,
                FirstName = playerModel.FirstName,
                LastName = playerModel.LastName,
                UpdatedDate = DateTime.Now
            };
        }


    }
}