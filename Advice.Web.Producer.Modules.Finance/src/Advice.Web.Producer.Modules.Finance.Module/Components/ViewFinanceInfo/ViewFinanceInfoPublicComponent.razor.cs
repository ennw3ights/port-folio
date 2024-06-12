using Advice.Web.Producer.Modules.Finance.Models.Components;
using Advice.Web.Producer.Modules.Finance.Models.Components.Shared;
using Advice.Web.Producer.Modules.Finance.Services.HttpClients.DTOs;

namespace Advice.Web.Producer.Modules.Finance.Module.Components.ViewFinanceInfo;

public partial class ViewFinanceInfoPublicComponent
{
    private static class Mapper
    {
        public static ViewFinanceInfoComponentModel MapToModel(BalancesDto dto) => 
        new()
        {
            Balances = dto.Balances.Select(bal => new FinanceBalance()
            {
                Quantity = bal.Quantity,
                Currency = bal.Currency
            }).ToList()
        };
    }
}