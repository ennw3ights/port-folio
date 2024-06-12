namespace Infrastructure.Services.DataStore.Common.Enums;

public sealed class FileExtension : SmartEnum<FileExtension, int>
{
    public static readonly FileExtension Xlsx = new("xlsx", 1);
    public static readonly FileExtension Csv = new("csv", 2);
    
    private FileExtension(string name, int value) : base(name, value)
    {
        
    }
}
