using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Ticket;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces {
    public interface ITicketService {
        Task<List<Ticket>> GetTicketsAsync();
        Task<Ticket> GetTicketAsync(int id);
        Task<Ticket> CreateTicketAsync(AddTicket ticket);
        Task<bool> DeleteTicketAsync(long id);
        Task<Ticket> EditTicketAsync(EditTicket ticket);
    }
}