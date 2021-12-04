using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces {
    public interface IPlayService {
        Task<List<Play>> GetPlaysAsync();
        Task<Play> GetPlayAsync(int id);
        Task<Play> CreatePlayAsync(Play play);
        Task<bool> DeletePlayAsync(int id);
        Task<Play> EditPlayAsync(Play play);
    }
}