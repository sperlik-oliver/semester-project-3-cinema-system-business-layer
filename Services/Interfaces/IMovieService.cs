using System.Collections.Generic;
using System.Threading.Tasks;
using ABDOTClient.Model;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces {
    public interface IMovieService {
        Task<List<Movie>> GetMoviesAsync();
        Task<Movie> GetMovieAsync(int id);
        Task<Movie> CreateMovieAsync(Movie movie);
        Task<bool> DeleteMovieAsync(int id);
        Task<Movie> EditMovieAsync(Movie movie);
        
    }
}