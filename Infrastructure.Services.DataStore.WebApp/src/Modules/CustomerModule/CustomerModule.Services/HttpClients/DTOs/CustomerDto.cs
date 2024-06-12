namespace CustomerModule.Services.HttpClients.DTOs;

public class CustomerDto
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public DateTime DateTimeCreated { get; set; }
    public DateTime DateTimeLastModified { get; set; }
    public CustomerTemplate DefaultTemplate { get; set; }
    public List<CustomerTemplate>? Templates { get; set; }

}
