using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Utilities {
    public static class CustomJsonConvert {
        private static readonly DefaultContractResolver defaultContractResolver = new DefaultContractResolver {
            NamingStrategy = new CamelCaseNamingStrategy()
        };

        public static string SerializeObject(object o) {
            return JsonConvert.SerializeObject(o, new JsonSerializerSettings {
                ContractResolver = defaultContractResolver,
                Formatting = Formatting.Indented
            });
        }
    }
}