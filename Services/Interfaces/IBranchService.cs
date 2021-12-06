using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Branches;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces {
    public interface IBranchService {
        Task<List<Branch>> GetBranchesAsync();
        Task<Branch> GetBranchAsync(int id);
        Task<Branch> CreateBranchAsync(AddBranch branch);
        Task<bool> DeleteBranchAsync(long id);
        Task<Branch> EditBranchAsync(EditBranch branch);
    }
}