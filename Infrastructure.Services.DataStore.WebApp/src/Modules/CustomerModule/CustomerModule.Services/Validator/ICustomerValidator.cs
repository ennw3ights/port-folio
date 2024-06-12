namespace CustomerModule.Services.Validator;

public interface ICustomerValidator
{
    IEnumerable<string> ValidateName(string customerName);
}
