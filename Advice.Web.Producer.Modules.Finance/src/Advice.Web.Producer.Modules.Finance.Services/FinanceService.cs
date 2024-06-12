namespace Advice.Web.Producer.Modules.Finance.Services;

public sealed class FinanceService(IFinanceHttpClient httpClient) : IFinanceHttpClient
{
    public async Task<BalancesDto> GetAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await httpClient.GetAsync(cancellationToken);
            return response;
        }
        catch (Exception)
        {
            return new BalancesDto();
        }
    }
}