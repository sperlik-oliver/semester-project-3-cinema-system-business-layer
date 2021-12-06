using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Hall;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Utilities;
using Newtonsoft.Json;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class HallService : IHallService {
        private readonly string uri = "https://abdot-api.herokuapp.com/api/hall";


        public async Task<List<Hall>> GetHallsAsync() {
            using HttpClient httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}s");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();

            var halls = JsonConvert.DeserializeObject<List<Hall>>(result);
            Console.WriteLine(halls);
            foreach (var hall in halls) {
                hall.SetSeats();
            }

            return halls;
        }

        public async Task<Hall> GetHallAsync(int id) {
            using HttpClient httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}/{id}");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var hall = JsonConvert.DeserializeObject<Hall>(result);
            hall.SetSeats();
            return hall;
        }

        public async Task<Hall> CreateHallAsync(AddHall hall) {
            using HttpClient httpClient = new HttpClient();
            var content = new StringContent(
                CustomJsonConvert.SerializeObject(hall),
                Encoding.UTF8,
                "application/json"
            );

            var responseMessage = await httpClient.PostAsync($"{uri}/create", content);
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var createdHall = JsonConvert.DeserializeObject<Hall>(result);
            return createdHall;
        }

        public async Task<bool> DeleteHallAsync(int id) {
            using HttpClient httpClient = new HttpClient();

            var responseMessage = await httpClient.DeleteAsync($"{uri}/delete/{id}");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            return true;

        }

        public async Task<Hall> EditHallAsync(EditHall hall) {
            using HttpClient httpClient = new HttpClient();
            var content = new StringContent(
                CustomJsonConvert.SerializeObject(hall),
                Encoding.UTF8,
                "application/json"
            );

            var responseMessage = await httpClient.PutAsync($"{uri}/edit/{hall.Id}", content);
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var editedHall = JsonConvert.DeserializeObject<Hall>(result);
            return editedHall;
        }
    }
}