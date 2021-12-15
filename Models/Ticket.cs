using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Models {
    public class Ticket {
        public int Id { set; get; }
        public Play Play { set; get; }
        public Employee Employee { set; get; }
        public int row { get; set; }
        public int column { get; set; }
    }
}