using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Branches;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Utilities;
using Newtonsoft.Json;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class BranchService : IBranchService {
        private readonly string uri = "https://abdot-api.herokuapp.com/api/branch";

        public async Task<List<Branch>> GetBranchesAsync() {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}es");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var branches = JsonConvert.DeserializeObject<List<Branch>>(result);
            
            return branches;
        }

        public async Task<Branch> GetBranchAsync(int id) {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}/{id}");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var branch = JsonConvert.DeserializeObject<Branch>(result);
            return branch;
        }

        public async Task<Branch> CreateBranchAsync(AddBranch branch) {
            using var httpClient = new HttpClient();

            var content = new StringContent(
                CustomJsonConvert.SerializeObject(branch),
                Encoding.UTF8,
                "application/json"
            );
            Console.WriteLine(CustomJsonConvert.SerializeObject(branch));
            var responseMessage = await httpClient.PostAsync($"{uri}/create", content);

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();

            var createdBranch = JsonConvert.DeserializeObject<Branch>(result);
            return createdBranch;
        }

        public async Task<bool> DeleteBranchAsync(long id) {
            using var httpClient = new HttpClient();

            var responseMessage = await httpClient.DeleteAsync($"{uri}/delete/{id}");

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            return true;
        }

        public async Task<Branch> EditBranchAsync(EditBranch branch) {
            using var httpClient = new HttpClient();

            var content = new StringContent(
                CustomJsonConvert.SerializeObject(branch),
                Encoding.UTF8,
                "application/json"
            );
            var responseMessage = await httpClient.PutAsync($"{uri}/edit/{branch.Id}", content);

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var editedBranch = JsonConvert.DeserializeObject<Branch>(result);
            return editedBranch;
        }
    }
}