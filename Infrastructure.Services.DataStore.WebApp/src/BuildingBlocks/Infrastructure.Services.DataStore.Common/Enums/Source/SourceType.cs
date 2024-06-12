namespace Infrastructure.Services.DataStore.Common.Enums.Source;

public sealed class SourceType : SmartEnum<SourceType, int>
{
    public static readonly SourceType ManualLoading = new("Manual Loading", 1);
    public static readonly SourceType AutoLoading = new ("Auto Loading", 2);

    private SourceType(string name, int value) : base(name, value)
    {
        
    }
}
