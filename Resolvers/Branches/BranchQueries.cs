using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Utilities;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Branches {
    
    [ExtendObjectType(Name = "Query")]
    public class BranchQueries {
        private readonly string uri = "https://abdot-api.herokuapp.com/api/branch";
        private IBranchService branchService;

        public BranchQueries() {
            branchService = new BranchService();
        }

        public async Task<List<Models.Branch>> GetBranches() {
            using HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync($"{uri}/es");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();

            List<Branch> branches = (List<Branch>) CustomJsonSerialization.Deserialize(result);

            return branches;
        }

        public async Task<Models.Branch> GetBranch(int id) {
            return await branchService.GetBranchAsync(id);
        }
    }
}