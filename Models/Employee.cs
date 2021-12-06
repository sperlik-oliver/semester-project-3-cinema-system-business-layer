using System;
using System.Collections.Generic;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Models
{
    public class Employee : Person
    {

        public int Role { get; set; }
        
         public string CPR { get; set; }

         public string Street { get; set; }
        
         public string City { get; set; }
        
         public string Postcode { get; set; }
        
         public string Country { get; set; }

         public DateTime BirthDate { get; set; }
        public IList<Ticket> TicketsSold { get; set; }

        public Branch Branch { get; set; }

        public Employee()
        {
            TicketsSold = new List<Ticket>();
        }
        
        
    }
}