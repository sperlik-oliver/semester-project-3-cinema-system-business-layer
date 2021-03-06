using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Models {
    public class Branch {
        public long Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public IList<Hall> Halls { get; set; }
        public IList<Employee> Employees { get; set; }

        public Branch() {
            Halls = new List<Hall>();
            Employees = new List<Employee>();
        }
    }
}