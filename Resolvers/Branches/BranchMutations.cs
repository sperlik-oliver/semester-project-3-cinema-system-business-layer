using System;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Branches {
    [ExtendObjectType(Name = "Mutation")]
    public class BranchMutations {
        private IBranchService branchService;
        
        public BranchMutations() {
            branchService = new BranchService();
        }

        public async Task<Branch> CreateBranch(AddBranch branch)
        {
            try
            {
                return await branchService.CreateBranchAsync(branch);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Branch> EditBranch(EditBranch branch) {
            try
            {
                return await branchService.EditBranchAsync(branch);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> DeleteBranch(long branchId)
        {
            try
            {
                return await branchService.DeleteBranchAsync(branchId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}