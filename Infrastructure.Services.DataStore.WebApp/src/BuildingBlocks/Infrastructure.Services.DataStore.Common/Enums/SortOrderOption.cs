namespace Infrastructure.Services.DataStore.Common.Enums;

public sealed class SortOrderOption : SmartEnum<SortOrderOption, string>
{
    public static readonly SortOrderOption Ascending = new("Ascending", "asc");
    public static readonly SortOrderOption Descending = new("Descending", "desc");
    
    private SortOrderOption(string name, string value) : base(name, value)
    {
        
    }
}
