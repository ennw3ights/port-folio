namespace SourceModule.Models.Components;

public class ImportSourceComponentModel
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public SourceType Type { get; set; }
    public SourceTemplate Template { get; set; }
    public List<string> FilePreview { get; set; }
}
