namespace SourceModule.Services.Helpers.DummyData;

public static class SourcePropertyGenerator
{
    public static List<SourceProperty> GenerateSourceProperties()
    {
        List<SourceProperty> sourceProperties = 
        [
        new SourceProperty
        {
            Name = "Name",
            IsValidByDefault = true
        },

        new SourceProperty
        {
            Name = "Phone",
            IsValidByDefault = false
        },

        new SourceProperty
        {
            Name = "Email",
            IsValidByDefault = true
        },

        new SourceProperty
        {
            Name = "Address",
            IsValidByDefault = true
        },

        new SourceProperty
        {
            Name = "Region",
            IsValidByDefault = false
        },

        new SourceProperty
        {
            Name = "Country",
            IsValidByDefault = true
        },

        new SourceProperty
        {
            Name = "Age",
            IsValidByDefault = true
        },
        ];

        return sourceProperties;
    }
}
