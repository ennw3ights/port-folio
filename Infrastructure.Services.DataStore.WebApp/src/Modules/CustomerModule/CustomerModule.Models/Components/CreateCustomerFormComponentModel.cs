namespace CustomerModule.Models.Components;

public sealed class CreateCustomerFormComponentModel
{
    public string Name { get; set; } = string.Empty;
    public CustomerTemplate DefaultTemplate { get; set; } = new();
    public List<CustomerTemplate> Templates { get; set; } = new();
}
