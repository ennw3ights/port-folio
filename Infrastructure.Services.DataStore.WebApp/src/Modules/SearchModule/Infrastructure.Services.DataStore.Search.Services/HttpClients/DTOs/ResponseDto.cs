namespace Infrastructure.Services.DataStore.Search.Services.HttpClients.DTOs;

public sealed class ResponseDto
{
    public List<string> Headers { get; set; } = [];
    public List<string> Content { get; set; } = [];
}
