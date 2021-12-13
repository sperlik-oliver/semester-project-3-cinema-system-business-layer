using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Models
{
    public class Play
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int TimeInMinutes { get; set; }
        public int Price { get; set; }
        public Movie Movie { get; set; }
        public Hall Hall { get; set; }
        public IList<Ticket> Tickets { get; set; }

        public Play()
        {
            Tickets = new List<Ticket>();
        }
    }
}