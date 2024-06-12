namespace CustomerModule.Services.HttpClients;

public interface ICustomerHttpClient
{
    public Task<List<CustomerPropertyDto>> GetAvailablePropertiesAsync(CancellationToken cancellationToken = default);

    public Task CreateAsync(CustomerDto customerDto, CancellationToken cancellationToken = default);

    public Task DeleteAsync(string id, CancellationToken cancellationToken = default);

    public Task UpdateAsync(CustomerDto customerDto, CancellationToken cancellationToken = default);

    public Task<CustomerDto> GetCustomerAsync(string id, CancellationToken cancellationToken = default);

    Task<PaginatedData<CustomerDto>> GetAsync(QueryParameters queryParameters, CancellationToken cancellationToken = default);
}
