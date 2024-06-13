namespace SourceModule.Models.Components;

public class ImportSourceComponentModel
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public SourceType Type { get; set; } = null!;
    public SourceTemplate Template { get; set; } = null!;
    public List<string> FilePreview { get; set; } = null!;
}
