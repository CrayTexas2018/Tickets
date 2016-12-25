using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tickets.Models
{
    public class SportViewModel
    {
        public Sport sport { get; set; }

        public List<Content> content { get; set; }

        public List<Team> teams { get; set; }

        public List<Price> prices { get; set; }
    }

    public class Sport
    {
        [Key]
        public int sport_id { get; set; }

        public string internal_name { get; set; }

        public string name { get; set; }

        public bool is_active { get; set; }

        public DateTime created { get; set; }

        public DateTime updated { get; set; }
    }

    public class Content
    {
        [Key]
        public int content_id { get; set; }

        public int sport_id { get; set; }
        
        public string head { get; set; }

        public string body { get; set; }

        public bool active { get; set; }

        public DateTime created { get; set; }

        public DateTime updated { get; set; }
    }

    public class Team
    {
        [Key]
        public int team_id { get; set; }

        public int sport_id { get; set; }

        public string internal_name { get; set; }

        public string web_name { get; set; }

        public string team_name { get; set; }

        public bool active { get; set; }

        public DateTime created { get; set; }

        public DateTime updated { get; set; }
    }

    public class Price
    {
        [Key]
        public int price_id { get; set; }

        public string user_id { get; set; }

        public int team_id { get; set; }

        public int sport_id { get; set; }

        public decimal price { get; set; }

        public bool active { get; set; }

        public bool created { get; set; }

        public bool updated { get; set; }
    }
}