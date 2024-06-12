namespace SourceModule.Services;

public sealed class SourceService(ISourceHttpClient sourceHttpClient, LoggingService loggingService) : ISourceHttpClient
{
    public async Task<PaginatedData<SourceDto>> GetAsync(QueryParameters queryParameters, CancellationToken cancellationToken = default)
    {
        try
        {
            PaginatedData<SourceDto> response = await sourceHttpClient.GetAsync(queryParameters, cancellationToken);

            return response;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return new PaginatedData<SourceDto>(new List<SourceDto>(), 0, 0, 0);
        }
    }

    public async Task<SourceDto> GetByIdAsync(string sourceId, CancellationToken cancellationToken = default)
    {
        try
        {
            SourceDto response = await sourceHttpClient.GetByIdAsync(sourceId, cancellationToken);

            return response;
        }
        catch (Exception e)
        {
            loggingService.LogError(e.Message, e);

            return new SourceDto();
        }
    }

    public async Task DeleteAsync(string sourceId, CancellationToken cancellationToken = default)
    {
        try
        {
            await sourceHttpClient.DeleteAsync(sourceId, cancellationToken);
        }
        catch (Exception e)
        {
            loggingService.LogError(e.Message, e);
        }
    }

    public async Task UpdateAsync(SourceDto sourceDto, CancellationToken cancellationToken = default)
    {
        try
        {
            await sourceHttpClient.UpdateAsync(sourceDto, cancellationToken);
        }
        catch (Exception e)
        {
            loggingService.LogError(e.Message, e);
        }
    }

    public async Task<List<SourceProperty>> GetPropertiesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            List<SourceProperty> response = await sourceHttpClient.GetPropertiesAsync(cancellationToken);

            return response;
        }
        catch (Exception e)
        {
            loggingService.LogError(e.Message, e);

            return new List<SourceProperty>();
        }
    }

    public async Task<SourceDto> CreateAsync(SourceDto sourceDto, CancellationToken cancellationToken = default)
    {
        try
        {
            SourceDto response = await sourceHttpClient.CreateAsync(sourceDto, cancellationToken);
            
            return response;
        }
        catch (Exception e)
        {
            loggingService.LogError(e.Message, e);

            return new SourceDto();
        }
    }
}
