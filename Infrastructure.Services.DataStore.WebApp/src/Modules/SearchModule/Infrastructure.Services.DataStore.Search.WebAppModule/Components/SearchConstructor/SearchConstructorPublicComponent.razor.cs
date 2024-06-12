using System.Collections;

namespace Infrastructure.Services.DataStore.Search.WebAppModule.Components.SearchConstructor;

public partial class SearchConstructorPublicComponent
{
    private static class Mapper
    {
        public static SearchDto MapToDto(SearchConstructorComponentModel model) => new()
        {
            SearchParameters = model.SearchParameters,
            SearchArguments = model.SearchArguments
        };

        public static ResponseComponentModel MapToModel(ResponseDto dto) =>
            new()
            {
                Headers = dto.Headers,
                Content = dto.Content
            };
    }
}
