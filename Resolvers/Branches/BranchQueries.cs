using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Branches {
    [ExtendObjectType(Name = "Query")]
    public class BranchQueries {
        private IBranchService branchService;

        public BranchQueries() {
            branchService = new BranchService();
        }

        public async Task<List<Models.Branch>> GetBranches() {
            return await branchService.GetBranchesAsync();
        }

        public async Task<Models.Branch> GetBranch(int id) {
            return await branchService.GetBranchAsync(id);
        }
    }
}