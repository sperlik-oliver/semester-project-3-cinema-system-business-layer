using System;
using System.Collections.Generic;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Employee {
    public record EmployeeInput(
        int Id,
    string Email,
    string FirstName,
    string LastName,
    string Password,
    int Role,
    string CPR,
    string Street,
    string City,
    string Postcode,
    string Country,
    DateTime BirthDate,
    Branch Branch,
    List<Models.Ticket> TicketsSold
    );
}