using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class BranchService : IBranchService {
        private readonly string uri = "https://abdot-api.herokuapp.com/api/branch";
        
        public async Task<List<Branch>> GetBranchesAsync() {
            using HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync($"{uri}/es");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            
            List<Branch> branches = new List<Branch>();
        }

        public async Task<Branch> GetBranchAsync(int id) {
            throw new System.NotImplementedException();
        }

        public async Task<Branch> CreateBranchAsync(Branch branch) {
            throw new System.NotImplementedException();
        }

        public async Task<bool> DeleteBranchAsync(int id) {
            throw new System.NotImplementedException();
        }

        public async Task<Branch> EditBranchAsync(Branch branch) {
            throw new System.NotImplementedException();
        }
    }
}