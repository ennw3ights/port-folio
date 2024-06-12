namespace Advice.Web.Producer.Modules.Finance.Services.HttpClients.DTOs;

public class BalancesDto
{
    public List<BalanceDto> Balances { get; set; } = [];

    public class BalanceDto
    {
        public int Quantity { get; set; }
        public string Currency { get; set; } = null!;
    }
}