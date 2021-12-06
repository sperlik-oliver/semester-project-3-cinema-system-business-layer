using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Play;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces {
    public interface IPlayService {
        Task<List<Play>> GetPlaysAsync();
        Task<Play> GetPlayAsync(int id);
        Task<Play> CreatePlayAsync(AddPlay play);
        Task<bool> DeletePlayAsync(long id);
        Task<Play> EditPlayAsync(EditPlay play);
    }
}