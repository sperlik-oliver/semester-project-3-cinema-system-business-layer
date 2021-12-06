using System;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Movie {
    [ExtendObjectType(Name = "Mutation")]
    public class MovieMutations {
        private IMovieService movieService;

        public MovieMutations() {
            movieService = new MovieService();
        }

        public async Task<Models.Movie> CreateMovie(AddMovie input) {
            try {
                return await movieService.CreateMovieAsync(input);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.Movie> EditMovie(EditMovie input) {
            try {
                return await movieService.EditMovieAsync(input);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> DeleteMovie(int id) {
            try {
                return await movieService.DeleteMovieAsync(id);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}