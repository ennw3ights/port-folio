namespace SourceModule.Services.HttpClients.DTOs;

public class SourceDto
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public SourceType Type { get; set; }
    public DateTime DateTimeCreate { get; set; }
    public DateTime DateTimeModified { get; set; }
    public SourceTemplate Template { get; set; }
    
}
