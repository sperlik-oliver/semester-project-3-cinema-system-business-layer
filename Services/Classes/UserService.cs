using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Models;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes {
    public class UserService : IUserService {
        public Task<List<User>> GetUsersAsync() {
            throw new System.NotImplementedException();
        }

        public Task<User> GetUserAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<User> CreateUserAsync(User user) {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<User> EditUserAsync(User user) {
            throw new System.NotImplementedException();
        }

        public Task<User> LoginAsync(User user) {
            throw new System.NotImplementedException();
        }
    }
}