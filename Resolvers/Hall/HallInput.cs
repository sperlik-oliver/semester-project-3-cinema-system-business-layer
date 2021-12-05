using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Hall {
    public record HallInput(
        [Optional] int Id,
        int HallSize,
        Branch Branch,
        List<Models.Play> Programme,
        List<Tuple<int, int>> Seats
    );
}