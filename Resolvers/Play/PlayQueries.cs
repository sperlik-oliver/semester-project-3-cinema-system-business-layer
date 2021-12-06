using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Play {
    
    [ExtendObjectType(Name = "Query")]
    public class PlayQueries {
        private IPlayService playService;

        public PlayQueries() {
            playService = new PlayService();
        }

        public async Task<List<Models.Play>> GetPlays() {
            try
            {
                return await playService.GetPlaysAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Models.Play> GetPlay(int id) {
            try
            {
                return await playService.GetPlayAsync(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}