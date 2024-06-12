namespace CustomerModule.WebAppModule.Components.CreateCustomerForm;

public class DropContainer
{
    public string Id { get; set; } = null!;
    public List<string> DropZones { get; set; } = null!;
    public List<DropItem> Items { get; set; } = null!;
    public bool IsDefault { get; set; }
}
