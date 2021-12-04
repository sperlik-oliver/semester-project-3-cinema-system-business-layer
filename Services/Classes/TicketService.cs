using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class TicketService : ITicketService {
        public Task<List<Ticket>> GetTicketsAsync() {
            throw new System.NotImplementedException();
        }

        public Task<Ticket> GetTicketAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<Ticket> CreateTicketAsync(Ticket ticket) {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteTicketAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<Ticket> EditTicketAsync(Ticket ticket) {
            throw new System.NotImplementedException();
        }
    }
}