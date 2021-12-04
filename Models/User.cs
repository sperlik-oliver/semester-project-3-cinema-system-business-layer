﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Models{
    public class User{
        [Required] public int Id { get; private set; }
        [Required] public string Email { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        public string Password { get; set; }
        
        public IList<Ticket> TicketsPurchased { get; set; }

        public User()
        {
            TicketsPurchased = new List<Ticket>();
        }
    }
}