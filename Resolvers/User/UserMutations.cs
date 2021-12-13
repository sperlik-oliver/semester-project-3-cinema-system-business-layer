using System;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.User
{
    [ExtendObjectType(Name = "Mutation")]
    public class UserMutations
    {
        private IUserService userService;
        

        public UserMutations() {
            userService = new UserService();
        }

        public async Task<Models.User> CreateUser(AddUser user) {
            try
            {
                return await userService.CreateUserAsync(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.User> EditUser(EditUser user) {
            try
            {
                return await userService.EditUserAsync(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.User> Login(Login login)
        {
            Console.WriteLine(login.Email);
            Console.WriteLine(login.Password);
            try
            {
                Models.User userToReturn = await userService.LoginAsync(login);
                Console.WriteLine(userToReturn.Id);
                Console.WriteLine(userToReturn.Email);
                Console.WriteLine(userToReturn.Password);
                Console.WriteLine(userToReturn.TicketsPurchased);
                Console.WriteLine(userToReturn.FirstName);
                Console.WriteLine(userToReturn.LastName);
                return await userService.LoginAsync(login);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> DeleteUser(long userId)
        {
            try
            {
                return await userService.DeleteUserAsync(userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}