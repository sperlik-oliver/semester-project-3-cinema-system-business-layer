using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Ticket {
    
    [ExtendObjectType(Name = "Query")]
    public class TicketQueries {
        
        private ITicketService ticketService;

        public TicketQueries() {
            ticketService = new TicketService();
        }

        public async Task<List<Models.Ticket>> GetTickets() {
            try
            {
                return await ticketService.GetTicketsAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.Ticket> GetTicket(int id) {
            try
            {
                return await ticketService.GetTicketAsync(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        
    }
}