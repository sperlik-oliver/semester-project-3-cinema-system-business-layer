using System.Runtime.InteropServices;

namespace dotnet_graphql_hotchocolate_abdot_middleware_api.Resolvers.Movie {
    public record MovieInput(
        [Optional] int Id,
        string Title,
        string Description,
        string Genre,
        string Director,
        string Language,
        string SubtitleLanguage,
        int Year,
        int Lenght,
        string PosterSrc
    );
}