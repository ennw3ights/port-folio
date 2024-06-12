namespace CustomerModule.Services.HttpClients.DTOs;

public class CustomerPropertyDto
{
    public string Name { get; set; } = null!;
    public bool IsRequired { get; set; }
    public bool IsUnique { get; set; }
    public bool IsValidOnly { get; set; }
}
