namespace Advice.Web.Producer.Modules.Finance.Services.HttpClients;

public interface IFinanceHttpClient
{
    Task<BalancesDto> GetAsync(CancellationToken cancellationToken = default);
}