using System.Text.Json;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Utilities {
    public static class CustomJsonSerialization {
        private static readonly JsonSerializerOptions deserialise = new JsonSerializerOptions {
            WriteIndented = true,
            PropertyNameCaseInsensitive = false
        };

        private static readonly JsonSerializerOptions serialise = new JsonSerializerOptions {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public static string Serialise(object instance) {
            var serializedObject = JsonSerializer.Serialize(instance, serialise);
            var start = serializedObject.IndexOf('"');
            var end = serializedObject.IndexOf(',');
            return serializedObject.Remove(start, end);
        }

        public static object Deserialize(string response) {
            return JsonSerializer.Deserialize<object>(response, deserialise);
        }
    }
}