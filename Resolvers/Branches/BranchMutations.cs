using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Branches {
    [ExtendObjectType(Name = "Mutation")]
    public class BranchMutations {
        private IBranchService branchService;
        

        public BranchMutations() {
            branchService = new BranchService();
        }

        public async Task<Branch> CreateBranch(BranchInput input) {
            
            var branch = new Branch {
                City = input.City,
                Street = input.Street,
                Postcode = input.PostCode,
                Country = input.Street,
                Halls = input.Halls,
                Employees = input.Employees,
            };
            return await branchService.CreateBranchAsync(branch);
        }

        public async Task<Branch> EditBranch(BranchInput input) {
            var branch = new Branch {
                City = input.City,
                Street = input.Street,
                Postcode = input.PostCode,
                Country = input.Street,
                Halls = input.Halls,
                Employees = input.Employees,
            };
            return await branchService.EditBranchAsync(branch);
        }
    }
}