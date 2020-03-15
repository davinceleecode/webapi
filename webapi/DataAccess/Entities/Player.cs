using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.DataAccess.Entities
{
    public class Player : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Team Team { get; set; }
    }
}