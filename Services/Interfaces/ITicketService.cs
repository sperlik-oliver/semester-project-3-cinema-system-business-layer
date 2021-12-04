using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces {
    public interface ITicketService {
        Task<List<Ticket>> GetTicketsAsync();
        Task<Ticket> GetTicketAsync(int id);
        Task<Ticket> CreateTicketAsync(Ticket ticket);
        Task<bool> DeleteTicketAsync(int id);
        Task<Ticket> EditTicketAsync(Ticket ticket);
    }
}