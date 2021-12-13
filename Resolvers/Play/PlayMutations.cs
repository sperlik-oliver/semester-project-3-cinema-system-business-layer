using System;
using System.Threading.Tasks;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Classes;
using dotnet_graphql_hotchocolate_abdot_middleware_api.Services.Interfaces;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Play
{
    [ExtendObjectType(Name = "Mutation")]

        public class PlayMutations {
            private IPlayService playService;
        

            public PlayMutations() {
                playService = new PlayService();
            }

            public async Task<Models.Play> CreatePlay(AddPlay play)
            {

                
                try
                {
                    return await playService.CreatePlayAsync(play);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            public async Task<Models.Play> EditPlay(EditPlay play) {
                Console.WriteLine(play.Date);
                Console.WriteLine(play.Price);
                Console.WriteLine(play.HallId);
                Console.WriteLine(play.MovieId);
                Console.WriteLine(play.TimeInMinutes);
                try
                {
                    return await playService.EditPlayAsync(play);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            public async Task<bool> DeletePlay(long playId)
            {
                try
                {
                    return await playService.DeletePlayAsync(playId);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
    }
}