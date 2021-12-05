using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Play {
    public record PlayInput(
        [Optional] int Id,
        DateTime Date,
        int TimeInMinutes,
        double Price,
        Models.Movie Movie,
        Models.Hall hall,
        List<Models.Ticket> Tickets
    );
}