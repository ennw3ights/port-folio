namespace SourceModule.Models.Components;

public class SourceInfoFormComponentModel
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public SourceType Type { get; set; } = SourceType.ManualLoading;
    public DateTime DateTimeCreated { get; set; }
    public DateTime DateTimeModified { get; set; }
    public SourceTemplate Template { get; set; } = new SourceTemplate();
}
