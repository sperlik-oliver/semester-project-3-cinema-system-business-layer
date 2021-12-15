namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Ticket
{
    public class EditTicket
    {
        public long Id { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public long EmployeeId { get; set; }
        public long PlayId { get; set; }
    }
}