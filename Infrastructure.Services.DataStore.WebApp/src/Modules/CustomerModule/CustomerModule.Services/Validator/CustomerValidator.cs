namespace CustomerModule.Services.Validator;

public class CustomerValidator : ICustomerValidator
{
    public IEnumerable<string> ValidateName(string customerName)
    {
        if (string.IsNullOrWhiteSpace(customerName))
        {
            yield return "Source name is required!";
            yield break;
        }

        if (customerName.Length < 3)
        {
            yield return "Source name must be at least of length 3";
        }

        if (customerName.Length > 100)
        {
            yield return "The length of the source name should not exceed 100";
        }
    }
}
