using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Utilities;

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
            Console.WriteLine((List<Branch>) CustomJsonSerialization.Deserialize(result));
            List<Branch> branches = (List<Branch>) CustomJsonSerialization.Deserialize(result);

            return branches;
        }

        public async Task<Branch> GetBranchAsync(int id) {
            using HttpClient httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}/{id}");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            Branch branch = (Branch) CustomJsonSerialization.Deserialize(result);
            return branch;
        }

        public async Task<Branch> CreateBranchAsync(Branch branch) {
            using HttpClient httpClient = new HttpClient();

            var content = new StringContent(
                CustomJsonSerialization.Serialise(branch),
                Encoding.UTF8,
                "application/json"
            );
            var responseMessage = await httpClient.PostAsync($"{uri}/create", content);

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            
            Branch tmp = (Branch) CustomJsonSerialization.Deserialize(result);
            return tmp;
        }

        public async Task<bool> DeleteBranchAsync(int id) {
            using HttpClient httpClient = new HttpClient();

            var responseMessage = await httpClient.DeleteAsync($"{uri}/delete/{id}");

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            return true;
        }

        public async Task<Branch> EditBranchAsync(Branch branch) {
            using HttpClient httpClient = new HttpClient();

            var content = new StringContent(
                CustomJsonSerialization.Serialise(branch),
                Encoding.UTF8,
                "application/json"
            );
            var responseMessage = await httpClient.PostAsync($"{uri}/edit/{branch.Id}", content);

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            Branch tmp = (Branch) CustomJsonSerialization.Deserialize(result);
            return tmp;
        }
    }
}