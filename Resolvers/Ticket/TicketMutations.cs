using System;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Ticket
{
    [ExtendObjectType(Name = "Mutation")]
    public class TicketMutations
    {
        private ITicketService ticketService;
        

        public TicketMutations() {
            ticketService = new TicketService();
        }

        public async Task<Models.Ticket> CreateTicket(AddTicket ticket) {
            try
            {
                return await ticketService.CreateTicketAsync(ticket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.Ticket> EditTicket(EditTicket ticket) {
            try
            {
                return await ticketService.EditTicketAsync(ticket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> DeleteTicket(long ticketId)
        {
            try
            {
                return await ticketService.DeleteTicketAsync(ticketId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}