namespace SourceModule.WebAppModule.Components.SourceTable;

public sealed class SourceTable<T> : TableAbstractComponent<T>
{
    protected override Task OnInitializedAsync()
    {
        Dense = true;
        Hover = true;
        LoadingProgressColor = Color.Primary;
        return base.OnInitializedAsync();
    }
}
