namespace Advice.Web.Producer.Modules.Finance.Models.Components.Shared;

public sealed class FinanceBalance
{
    public int Quantity { get; set; }
    public string Currency { get; set; } = null!;
}