namespace Infrastructure.Services.DataStore.Customer.WebAppModule.Components.CustomerTable;

public class CustomerTable<T> : TableAbstractComponent<T>
{
    protected override Task OnInitializedAsync()
    {
        Dense = true;
        Hover = true;
        LoadingProgressColor = Color.Primary;
        return base.OnInitializedAsync();
    }
}
