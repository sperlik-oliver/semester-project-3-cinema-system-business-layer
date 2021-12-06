using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Play;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Utilities;
using Newtonsoft.Json;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class PlayService : IPlayService {
        
        private readonly string uri = "https://abdot-api.herokuapp.com/api/play";
        
        public async Task<List<Play>> GetPlaysAsync()
        {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}s");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
            var result = await responseMessage.Content.ReadAsStringAsync();
            var plays = JsonConvert.DeserializeObject<List<Play>>(result);
            return plays;
        }

        public async Task<Play> GetPlayAsync(int id) {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}/{id}");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var play = JsonConvert.DeserializeObject<Play>(result);
            return play;
        }

        public async Task<Play> CreatePlayAsync(AddPlay play) {
            using var httpClient = new HttpClient();

            var content = new StringContent(
                CustomJsonConvert.SerializeObject(play),
                Encoding.UTF8,
                "application/json"
            );
            var responseMessage = await httpClient.PostAsync($"{uri}/create", content);

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();

            var createdPlay = JsonConvert.DeserializeObject<Play>(result);
            return createdPlay;
        }

        public async Task<bool> DeletePlayAsync(long id) {
            using var httpClient = new HttpClient();

            var responseMessage = await httpClient.DeleteAsync($"{uri}/delete/{id}");

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            return true;
        }

        public async Task<Play> EditPlayAsync(EditPlay play) {
            using var httpClient = new HttpClient();

            var content = new StringContent(
                CustomJsonConvert.SerializeObject(play),
                Encoding.UTF8,
                "application/json"
            );
            var responseMessage = await httpClient.PutAsync($"{uri}/edit/{play.Id}", content);

            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var editedPlay = JsonConvert.DeserializeObject<Play>(result);
            return editedPlay;
        }
    }
}