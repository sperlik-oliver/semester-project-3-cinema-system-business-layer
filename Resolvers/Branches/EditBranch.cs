using System.Collections.Generic;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Branches {
    public class EditBranch
    {
        public long Id { get; set; } 
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}