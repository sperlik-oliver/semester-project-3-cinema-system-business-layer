using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ABDOTClient.Model;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Models
{
    public class Branch
    {
        
      
        public int Id { get; private set; }
        
        [Required]
        public string City { get; set; }
        
        public IList<Hall> Halls { get; set; }

        public IList<Employee> Employees { get; set; }

        public Branch()
        {
            Halls = new List<Hall>();
            Employees = new List<Employee>();
        }
    }
}