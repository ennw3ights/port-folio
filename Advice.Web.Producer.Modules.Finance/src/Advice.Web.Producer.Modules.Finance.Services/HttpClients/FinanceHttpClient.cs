namespace Advice.Web.Producer.Modules.Finance.Services.HttpClients;

public sealed class FinanceHttpClient : IFinanceHttpClient
{
    private readonly BalancesDto _dummyData =
    new BalancesDto()
    {
        Balances =
        [
            new BalancesDto.BalanceDto()
            {
                Quantity = 15,
                Currency = "USD"
            },

            new BalancesDto.BalanceDto()
            {
                Quantity = 2000,
                Currency = "EUR"
            },

            new BalancesDto.BalanceDto()
            {
                Quantity = 3723115,
                Currency = "RUB"
            },

            new BalancesDto.BalanceDto()
            {
                Quantity = 1230,
                Currency = "EC"
            }
        ]
    };

    public async Task<BalancesDto> GetAsync(CancellationToken cancellationToken = default)
    {
        await Task.Delay(300, cancellationToken);
        var result = _dummyData;
        return result;
    }
}