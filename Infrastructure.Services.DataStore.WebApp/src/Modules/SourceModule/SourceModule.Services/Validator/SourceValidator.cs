namespace Infrastructure.Services.DataStore.Source.Services.Validator;

public class SourceValidator : ISourceValidator
{
    public IEnumerable<string> ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            yield return "Source name is required!";
            yield break;
        }

        if (name.Length < 3)
        {
            yield return "Source name must be at least of length 3";
        }

        if (name.Length > 100)
        {
            yield return "The length of the source name should not exceed 100";
        }
    }
}
