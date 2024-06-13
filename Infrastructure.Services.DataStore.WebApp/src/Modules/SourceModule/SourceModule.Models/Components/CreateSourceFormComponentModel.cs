namespace SourceModule.Models.Components;

public class CreateSourceFormComponentModel
{
    public string Name { get; set; } = string.Empty;
    public SourceType Type { get; set; } = null!;
    public SourceTemplate Template { get; set; } = new();
    public List<string> AvailableProperties { get; set; } = [];
}
