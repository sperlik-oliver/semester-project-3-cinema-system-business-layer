using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Models {
    public class User : Person {
        public IList<Ticket> TicketsPurchased { get; set; }

        public User() {
            TicketsPurchased = new List<Ticket>();
        }
    }
}