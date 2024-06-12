namespace CustomerModule.Models.Components.Shared;

public class CustomerProperty
{
    public string Name { get; set; } = null!;
    public bool IsRequired { get; set; }
    public bool IsValidByDefault { get; set; }
    public bool IsUnique { get; set; }
}
