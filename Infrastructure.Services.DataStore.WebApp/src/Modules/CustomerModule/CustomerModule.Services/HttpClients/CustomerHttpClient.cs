namespace CustomerModule.Services.HttpClients;

public class CustomerHttpClient : ICustomerHttpClient
{
    public async Task<List<CustomerPropertyDto>> GetAvailablePropertiesAsync(CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
        List<CustomerPropertyDto> response = CustomerPropertyGenerator.GenerateDummyProperties();

        return response;
    }

    public async Task CreateAsync(CustomerDto customerDto, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
    }

    public async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
    }

    public async Task UpdateAsync(CustomerDto customerDto, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
    }

    public async Task<CustomerDto> GetCustomerAsync(string id, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
        CustomerDto response = CustomerGenerator.GenerateCustomer(id);

        return response;
    }

    public async Task<PaginatedData<CustomerDto>> GetAsync(QueryParameters queryParameters, CancellationToken cancellationToken = default)
    {
        await Task.Delay(200, cancellationToken);
        List<CustomerDto> DummyDto = CustomerGenerator.GenerateCustomerList();
        var data = new PaginatedData<CustomerDto>(DummyDto, DummyDto.Count, queryParameters.Page,
            queryParameters.PageSize);
        return data;
    }
}
