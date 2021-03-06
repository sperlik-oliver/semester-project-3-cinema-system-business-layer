using System;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Hall {
    [ExtendObjectType(Name="Mutation")]
    public class HallMutations {
        private IHallService hallService;

        public HallMutations() {
            hallService = new HallService();
        }

        public async Task<Models.Hall> CreateHall(AddHall input) {

            try {
                return await hallService.CreateHallAsync(input);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.Hall> EditHall(EditHall input) {
            try {
                return await hallService.EditHallAsync(input);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> DeleteHall(int id) {
            try {
                return await hallService.DeleteHallAsync(id);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}