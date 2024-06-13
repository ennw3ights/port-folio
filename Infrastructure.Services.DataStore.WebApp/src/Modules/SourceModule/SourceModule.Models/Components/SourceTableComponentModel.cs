namespace SourceModule.Models.Components;

public class SourceTableComponentModel
{
    public List<SourceItem> Items { get; set; } = [];

    public class SourceItem
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public SourceType Type { get; set; } = null!;
        public DateTime DateTimeCreate { get; set; }
        public DateTime DateTimeModified { get; set; }
        public SourceTemplate Template { get; set; } = null!;
    }
}
