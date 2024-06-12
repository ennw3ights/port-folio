namespace Infrastructure.Services.DataStore.Search.Services.HttpClients.DTOs;

public class SearchDto
{
    public Parameters SearchParameters { get; set; } = new();
    public Arguments SearchArguments { get; set; } = new();
}
