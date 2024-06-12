namespace Infrastructure.Services.DataStore.Search.Services.HttpClients;

public interface ISearchHttpClient
{
    Task<ResponseDto> GetAsync(SearchDto searchData, CancellationToken cancellationToken = default);
}
