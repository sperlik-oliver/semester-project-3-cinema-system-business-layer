using System;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Play
{
    public class EditPlay
    {
        public long Id { get; set; }
        public string Date { get; set; }
        public int TimeInMinutes { get; set; }
        public int Price { get; set; }
        public long MovieId { get; set; }
        public long HallId { get; set; }
    }



}