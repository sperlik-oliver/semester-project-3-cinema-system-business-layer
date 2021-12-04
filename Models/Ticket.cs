using System;
using System.ComponentModel.DataAnnotations;
using ABDOTClient.Model;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Models
{
    public class Ticket
    {
        
        public int Id {private set; get; }
        
        [Required]
        public Play Play { set; get; }
        public User User { set; get; }
        public Employee Employee { set; get; }
        
        [Required]
        public Tuple<int, int> seat { get; set; }
    }
}