namespace Infrastructure.Services.DataStore.Search.Models.Components;

public sealed class TemplatePropertyComponentModel
{
    public List<TemplateProperty> SelectedProperties { get; set; } = [];
    
    public List<TemplateProperty> AvailableProperties { get; set; } = [];

    public class TemplateProperty
    {
        public string Name { get; set; } = null!;
        
        public bool? IsRequired { get; set; }
        
        public bool? IsValid { get; set; }

        public string? Selector { get; set; }
    }
}
