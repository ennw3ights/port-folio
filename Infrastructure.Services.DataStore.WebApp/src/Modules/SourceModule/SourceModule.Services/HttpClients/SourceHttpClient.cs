namespace SourceModule.Services.HttpClients;

public class SourceHttpClient : ISourceHttpClient
{

    public async Task<PaginatedData<SourceDto>> GetAsync(QueryParameters queryParameters, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
        List<SourceDto> dummyDtos = SourceGenerator.GenerateSourceDtos();
        var data = new PaginatedData<SourceDto>(dummyDtos, dummyDtos.Count, queryParameters.Page, queryParameters.PageSize);
        return data;
    }


    public async Task<SourceDto> GetByIdAsync(string sourceId, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
        var data = new SourceDto()
        {
            Id = sourceId,
            Name = "name",
            Type = SourceType.ManualLoading,
            DateTimeCreate = DateTime.SpecifyKind(DateTime.Now.AddDays(1), DateTimeKind.Local),
            DateTimeModified = DateTime.SpecifyKind(DateTime.Now.AddDays(2), DateTimeKind.Local),
            Template = new SourceTemplate()
            {
                Properties = SourcePropertyGenerator.GenerateSourceProperties(),
            }
        };

        return data;
    }

    public Task<SourceDto> CreateAsync(SourceDto sourceDto, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(new SourceDto());
    }
    
    public async Task DeleteAsync(string sourceId, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
    }

    public async Task UpdateAsync(SourceDto sourceDto, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
    }

    public async Task<List<SourceProperty>> GetPropertiesAsync(CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
        List<SourceProperty> data = SourcePropertyGenerator.GenerateSourceProperties();

        return data;
    }
}
