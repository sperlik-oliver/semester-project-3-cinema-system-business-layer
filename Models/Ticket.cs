using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Models {
    public class Ticket {
        public int Id { private set; get; }
        public Play Play { set; get; }
        public User User { set; get; }
        public Employee Employee { set; get; }
        public Tuple<int, int> Seat { get; set; }
    }
}