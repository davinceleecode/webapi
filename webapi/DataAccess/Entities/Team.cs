using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.DataAccess.Entities
{
    public class Team : EntityBase
    {
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}