using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.DataAccess.Entities
{
    public class GameEvent : EntityBase
    {
        public virtual Game Game { get; set; }
        public virtual Player Player { get; set; }

        public int  PointValue { get; set; }
    }
}