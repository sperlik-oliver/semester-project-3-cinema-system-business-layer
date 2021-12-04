using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces {
    public interface IBranchService {
        Task<List<Branch>> GetBranchesAsync();
        Task<Branch> GetBranchAsync(int id);
        Task<Branch> CreateBranchAsync(Branch branch);
        Task<bool> DeleteBranchAsync(int id);
        Task<Branch> EditBranchAsync(Branch branch);
    }
}