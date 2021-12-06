using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Movie;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces {
    public interface IMovieService {
        Task<List<Movie>> GetMoviesAsync();
        Task<Movie> GetMovieAsync(int id);
        Task<Movie> CreateMovieAsync(AddMovie movie);
        Task<bool> DeleteMovieAsync(int id);
        Task<Movie> EditMovieAsync(EditMovie movie);
        
    }
}