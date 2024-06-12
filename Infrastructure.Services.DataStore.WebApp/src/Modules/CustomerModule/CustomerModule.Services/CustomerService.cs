namespace CustomerModule.Services;

public sealed class CustomerService(ICustomerHttpClient customerHttpClient, ILoggingService loggingService) : ICustomerHttpClient
{
    public async Task<PaginatedData<CustomerDto>> GetAsync(QueryParameters queryParameters, CancellationToken cancellationToken = default)
    {
        try
        {
            PaginatedData<CustomerDto> response = await customerHttpClient.GetAsync(queryParameters, cancellationToken);

            return response;
        }
        catch (Exception e)
        {
            loggingService.LogError(e.Message, e);

            return new PaginatedData<CustomerDto>(new List<CustomerDto>(), 0, 0, 0);
        }
    }

    public async Task<List<CustomerPropertyDto>> GetAvailablePropertiesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            List<CustomerPropertyDto> response = await customerHttpClient.GetAvailablePropertiesAsync(cancellationToken);

            return response;
        }
        catch (Exception e)
        {
            loggingService.LogError(e.Message, e);

            return new List<CustomerPropertyDto>();
        }
    }

    public async Task CreateAsync(CustomerDto customerDto, CancellationToken cancellationToken = default)
    {
        try
        {
            await customerHttpClient.CreateAsync(customerDto, cancellationToken);
        }
        catch (Exception e)
        {
            loggingService.LogError(e.Message, e);
        }
    }

    public async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        try
        {
            await customerHttpClient.DeleteAsync(id, cancellationToken);
        }
        catch (Exception e)
        {
            loggingService.LogError(e.Message, e);
        }
    }

    public async Task UpdateAsync(CustomerDto customerDto, CancellationToken cancellationToken = default)
    {
        try
        {
            await customerHttpClient.UpdateAsync(customerDto, cancellationToken);
        }
        catch (Exception e)
        {
            loggingService.LogError(e.Message, e);
        }
    }

    public async Task<CustomerDto> GetCustomerAsync(string id, CancellationToken cancellationToken = default)
    {
        try
        {
            CustomerDto response = await customerHttpClient.GetCustomerAsync(id, cancellationToken);

            return response;
        }
        catch (Exception e)
        {
            loggingService.LogError(e.Message, e);

            return new CustomerDto();
        }
    }
}
