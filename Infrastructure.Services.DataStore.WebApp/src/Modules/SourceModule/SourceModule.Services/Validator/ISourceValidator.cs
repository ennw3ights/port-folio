namespace Infrastructure.Services.DataStore.Source.Services.Validator;

public interface ISourceValidator
{
    IEnumerable<string> ValidateName(string name);
}
