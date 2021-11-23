using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class UserResolver
    {

        private static readonly HttpClient _httpClient = new HttpClient();
        
        public async Task<String> GetUsers()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("https://abdot-api.herokuapp.com/api/users");
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {httpResponseMessage.StatusCode}, {httpResponseMessage.ReasonPhrase}");
            }

            return await httpResponseMessage.Content.ReadAsStringAsync();
        }
        
    }
}