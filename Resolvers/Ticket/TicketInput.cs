using System;
using System.Runtime.InteropServices;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Ticket {
    public record TicketInput(
        [Optional] int Id,
        Models.Play Play,
        Models.User User,
        Models.Employee Employee,
        Tuple<int, int> Seat
    );
}