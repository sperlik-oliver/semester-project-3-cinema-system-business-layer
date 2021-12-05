using System.Collections.Generic;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.User {
    public record UserInput(
        int Id,
        string Email,
        string FirstName,
        string LastName,
        string Password,
        List<Models.Ticket> TicketsPurchased
    );
}