using System.Collections.Generic;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Branches {
    public record BranchInput(
        int Id,
        string City,
        IList<Models.Hall> Halls,
        IList<Models.Employee> Employees
    );
}