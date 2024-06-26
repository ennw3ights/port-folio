namespace CustomerModule.Models.Components;

public sealed class CustomerInfoFormComponentModel
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public DateTime DateTimeCreate { get; set; }
    public DateTime DateTimeLastModified { get; set; }
    public CustomerTemplate DefaultTemplate { get; set; } = new();
    public List<CustomerTemplate>? Templates { get; set; }
}
