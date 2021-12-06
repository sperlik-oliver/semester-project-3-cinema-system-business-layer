using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.User;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Utilities;
using Newtonsoft.Json;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class UserService : IUserService {
        private readonly string uri = "https://abdot-api.herokuapp.com/api/user";
        
        public async Task<List<User>> GetUsersAsync()
        {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}s");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
            var result = await responseMessage.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<List<User>>(result);
            return users;
        }

        public async Task<User> GetUserAsync(int id) {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}/{id}");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<User>(result);
            return user;
        }

        public async Task<User> CreateUserAsync(AddUser user) {
            using var httpClient = new HttpClient();

            var content = new StringContent(
                CustomJsonConvert.SerializeObject(user),
                Encoding.UTF8,
                "application/json"
            );
            var responseMessage = await httpClient.PostAsync($"{uri}/register", content);

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();

            var createdUser = JsonConvert.DeserializeObject<User>(result);
            return createdUser;
        }

        public async Task<bool> DeleteUserAsync(long id) {
            using var httpClient = new HttpClient();

            var responseMessage = await httpClient.DeleteAsync($"{uri}/delete/{id}");

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            return true;
        }

        public async Task<User> EditUserAsync(EditUser user) {
            using var httpClient = new HttpClient();

            var content = new StringContent(
                CustomJsonConvert.SerializeObject(user),
                Encoding.UTF8,
                "application/json"
            );
            var responseMessage = await httpClient.PutAsync($"{uri}/edit/{user.Id}", content);

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var editedUser = JsonConvert.DeserializeObject<User>(result);
            return editedUser;
        }

        public async Task<User> LoginAsync(Login login)
        {
            using var httpClient = new HttpClient();
            var content = new StringContent(
                CustomJsonConvert.SerializeObject(login),
                Encoding.UTF8,
                "application/json"
            );
            var responseMessage = await httpClient.PostAsync($"{uri}/login", content);

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var loggedInUser = JsonConvert.DeserializeObject<User>(result);
            return loggedInUser;
        }
    }
}