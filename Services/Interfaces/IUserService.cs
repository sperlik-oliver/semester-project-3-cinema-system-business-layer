using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.User;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services {
    public interface IUserService {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
        Task<User> CreateUserAsync(AddUser user);
        Task<bool> DeleteUserAsync(long id);
        Task<User> EditUserAsync(EditUser user);

        Task<User> LoginAsync(Login user);
    }
}