using System.Collections.Generic;
using System.Threading.Tasks;
using ABDOTClient.Model;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class MovieService : IMovieService{
        public Task<List<Movie>> GetMoviesAsync() {
            throw new System.NotImplementedException();
        }

        public Task<Movie> GetMovieAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<Movie> CreateMovieAsync(Movie movie) {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteMovieAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<Movie> EditMovieAsync(Movie movie) {
            throw new System.NotImplementedException();
        }
    }
}