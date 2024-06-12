namespace Advice.Web.Producer.Modules.Finance.Services.Exceptions;

public class DeserializationException(string jsonString, Type type) : Exception($"Failed to deserialize json string to {type.Name}")
{
    public string JsonString { get; } = jsonString;
    public Type Type { get; } = type;
}