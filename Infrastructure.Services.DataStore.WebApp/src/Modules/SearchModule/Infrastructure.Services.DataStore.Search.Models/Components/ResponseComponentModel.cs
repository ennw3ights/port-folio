namespace Infrastructure.Services.DataStore.Search.Models.Components;

public sealed class ResponseComponentModel
{
    public List<string> Headers { get; set; } = [];
    public List<string> Content { get; set; } = [];
}
