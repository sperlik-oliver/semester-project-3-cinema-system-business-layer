using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class HallService : IHallService{
        public Task<List<Hall>> GetHallsAsync() {
            throw new System.NotImplementedException();
        }

        public Task<Hall> GetHallAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<Hall> CreateHallAsync(Hall hall) {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteHallAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<Hall> EditHallAsync(Hall hall) {
            throw new System.NotImplementedException();
        }
    }
}