using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Movie {
    [ExtendObjectType(Name = "Query")]
    public class MovieQueries {
        private IMovieService movieService;

        public MovieQueries() {
            movieService = new MovieService();
        }

        public async Task<List<Models.Movie>> GetMovies() {
            try {
                return await movieService.GetMoviesAsync();
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.Movie> GetMovie(int id) {
            try {
                return await movieService.GetMovieAsync(id);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }
        

    }
}