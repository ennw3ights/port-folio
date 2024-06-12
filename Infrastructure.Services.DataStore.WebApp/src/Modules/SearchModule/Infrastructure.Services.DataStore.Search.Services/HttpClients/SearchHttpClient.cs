namespace Infrastructure.Services.DataStore.Search.Services.HttpClients;

public class SearchHttpClient : ISearchHttpClient
{
    public Task<ResponseDto> GetAsync(SearchDto searchData, CancellationToken cancellationToken = default)
    {
        var data = new ResponseDto();
    
        foreach (Property property in searchData.SearchArguments.Templates.SelectMany(template => template.Properties))
        {
            if (!data.Headers.Contains(property.Name))
            {
                data.Headers.Add(property.Name);
            }
        }

        for (int i = 0; i < 200; i++)
        {
            data.Content.Add($"Test {i + 1}");
        }

        return Task.FromResult(data);
    }
}
