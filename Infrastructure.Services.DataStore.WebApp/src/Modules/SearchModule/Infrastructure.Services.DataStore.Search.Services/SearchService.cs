namespace Infrastructure.Services.DataStore.Search.Services;

public class SearchService(HttpClients.SearchHttpClient httpClient) : ISearchHttpClient
{
    public async Task<ResponseDto> GetAsync(
        SearchDto searchData,
        CancellationToken cancellationToken = default)
    {
        try
        {
            ResponseDto response = await httpClient.GetAsync(searchData, cancellationToken);
            return response;
        }
        catch(Exception)
        {
            return null!;
        }
    }
}
