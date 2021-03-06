using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Hall {
    [ExtendObjectType(Name = "Query")]
    public class HallQueries {
        private IHallService hallService;

        public HallQueries() {
            hallService = new HallService();
        }

        public async Task<List<Models.Hall>> GetHalls() {
            try {
                return await hallService.GetHallsAsync();
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.Hall> GetHall(int id) {
            try {
                return await hallService.GetHallAsync(id);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}