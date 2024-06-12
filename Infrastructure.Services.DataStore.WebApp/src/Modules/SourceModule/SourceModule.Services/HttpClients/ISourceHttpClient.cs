namespace SourceModule.Services.HttpClients;

public interface ISourceHttpClient
{
    Task<PaginatedData<SourceDto>> GetAsync(QueryParameters queryParameters, CancellationToken cancellationToken = default);
    Task<SourceDto> CreateAsync(SourceDto sourceDto,  CancellationToken cancellationToken = default);

    Task<SourceDto> GetByIdAsync(string sourceId, CancellationToken cancellationToken = default);

    Task DeleteAsync(string sourceId, CancellationToken cancellationToken = default);

    Task UpdateAsync(SourceDto sourceDto, CancellationToken cancellationToken = default);

    Task<List<SourceProperty>> GetPropertiesAsync(CancellationToken cancellationToken = default);
}
