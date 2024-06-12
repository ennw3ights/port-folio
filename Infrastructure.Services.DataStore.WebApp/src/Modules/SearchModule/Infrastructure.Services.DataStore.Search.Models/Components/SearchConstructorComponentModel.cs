namespace Infrastructure.Services.DataStore.Search.Models.Components;

public sealed class SearchConstructorComponentModel
{
    public Parameters SearchParameters { get; set; } = new();
    public Arguments SearchArguments { get; set; } = new();
}
