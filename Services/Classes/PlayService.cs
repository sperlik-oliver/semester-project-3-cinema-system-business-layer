using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class PlayService : IPlayService {
        public Task<List<Play>> GetPlaysAsync() {
            throw new System.NotImplementedException();
        }

        public Task<Play> GetPlayAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<Play> CreatePlayAsync(Play play) {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeletePlayAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<Play> EditPlayAsync(Play play) {
            throw new System.NotImplementedException();
        }
    }
}