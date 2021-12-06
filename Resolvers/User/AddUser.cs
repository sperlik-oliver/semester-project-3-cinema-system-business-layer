using System.Collections.Generic;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.User {
    public class AddUser
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}