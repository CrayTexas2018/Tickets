using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tickets.Models
{
    public class Sport
    {
        public int sport_id { get; set; }

        public string internal_name { get; set; }

        public string name { get; set; }

        public bool is_active { get; set; }

        public DateTime created { get; set; }

        public DateTime updated { get; set; }
    }
}