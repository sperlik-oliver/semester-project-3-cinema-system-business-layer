using System.Collections.Generic;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Branch {
    public record BranchInput(
        int Id,
        string City,
        IList<Hall> Halls,
        IList<Employee> Employees
    );
}