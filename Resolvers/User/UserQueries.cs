using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.User {
    
    [ExtendObjectType(Name = "Query")]
    public class UserQueries {
        
        private IUserService userService;

        public UserQueries() {
            userService = new UserService();
        }

        public async Task<List<Models.User>> GetUsers() {
            try
            {
                return await userService.GetUsersAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.User> GetUser(int id) {
            try
            {
                return await userService.GetUserAsync(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
    }
}