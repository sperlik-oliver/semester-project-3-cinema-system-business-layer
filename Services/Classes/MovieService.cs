using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Movie;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Utilities;
using Newtonsoft.Json;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class MovieService : IMovieService {
        private readonly string uri = "https://abdot-api.herokuapp.com/api/movie";

        public async Task<List<Movie>> GetMoviesAsync() {
            using HttpClient httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}s");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var movies = JsonConvert.DeserializeObject<List<Movie>>(result);
            return movies;
        }

        public async Task<Movie> GetMovieAsync(int id) {
            using HttpClient httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}/{id}");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var movie = JsonConvert.DeserializeObject<Movie>(result);
            return movie;
        }

        public async Task<Movie> CreateMovieAsync(AddMovie movie) {
            using HttpClient httpClient = new HttpClient();
            var content = new StringContent(
                CustomJsonConvert.SerializeObject(movie),
                Encoding.UTF8,
                "application/json"
            );

            var responseMessage = await httpClient.PostAsync($"{uri}/create", content);
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var createdMovie = JsonConvert.DeserializeObject<Movie>(result);
            return createdMovie;
        }

        public async Task<bool> DeleteMovieAsync(int id) {
            using HttpClient httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"{uri}/delete/{id}");
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            return true;
        }

        public async Task<Movie> EditMovieAsync(EditMovie movie) {
            using HttpClient httpClient = new HttpClient();
            var content = new StringContent(
                CustomJsonConvert.SerializeObject(movie),
                Encoding.UTF8,
                "application/json"
            );

            var responseMessage = await httpClient.PutAsync($"{uri}/edit/{movie.Id}", content);
            if (!responseMessage.IsSuccessStatusCode) {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            var result = await responseMessage.Content.ReadAsStringAsync();
            var editedMovie = JsonConvert.DeserializeObject<Movie>(result);
            return editedMovie;
        }
    }
}