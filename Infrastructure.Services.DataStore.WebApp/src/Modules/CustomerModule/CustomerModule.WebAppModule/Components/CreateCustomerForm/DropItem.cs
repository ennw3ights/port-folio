namespace CustomerModule.WebAppModule.Components.CreateCustomerForm;

public class DropItem
{
    public string Name { get; init; } = null!;
    public string Selector { get; set; } = null!;
    public bool IsRequired { get; set; }
    public bool IsUnique { get; set; }
    public bool IsValidOnly { get; set; }
}
