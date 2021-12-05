using System.Collections.Generic;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Branches {
    public record BranchInput(
        int Id,
        string Street,
        string PostCode,
        string City,
        string Country,
        IList<Models.Hall> Halls,
        IList<Models.Employee> Employees
    );
}