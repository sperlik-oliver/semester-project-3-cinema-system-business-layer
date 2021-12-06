using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Hall;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces {
    public interface IHallService {
        Task<List<Hall>> GetHallsAsync();
        Task<Hall> GetHallAsync(int id);
        Task<Hall> CreateHallAsync(AddHall hall);
        Task<bool> DeleteHallAsync(int id);
        Task<Hall> EditHallAsync(EditHall hall);
    }
}