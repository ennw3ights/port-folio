namespace CustomerModule.Services.HttpClients.Helpers.DummyData;

public static class CustomerPropertyGenerator
{
    public static List<CustomerPropertyDto> GenerateDummyProperties()
    {
        List<CustomerPropertyDto> dummyCustomerProperties = 
        [
            new CustomerPropertyDto
            {
                Name = "Age",
                IsRequired = true,
                IsUnique = false,
                IsValidOnly = true
            },
            new CustomerPropertyDto
            {
                Name = "Name",
                IsRequired = false,
                IsUnique = false,
                IsValidOnly = true
            },
            new CustomerPropertyDto
            {
                Name = "Gender",
                IsRequired = true,
                IsUnique = false,
                IsValidOnly = false
            },
            new CustomerPropertyDto
            {
                Name = "Height",
                IsRequired = true,
                IsUnique = true,
                IsValidOnly = true
            }

        ];

        return dummyCustomerProperties;
    }

    public static List<CustomerProperty> GenerateTemplateProperties()
    {
        List<CustomerProperty> dummyCustomerProperties =
        [
            new CustomerProperty
            {
                Name = "Age",
                IsRequired = true,
                IsUnique = false,
                IsValidByDefault = true
            },
            new CustomerProperty
            {
                Name = "Name",
                IsRequired = false,
                IsUnique = false,
                IsValidByDefault = true
            },
            new CustomerProperty
            {
                Name = "Gender",
                IsRequired = true,
                IsUnique = false,
                IsValidByDefault = false
            },
            new CustomerProperty
            {
                Name = "Height",
                IsRequired = true,
                IsUnique = true,
                IsValidByDefault = true
            }
        ];

        return dummyCustomerProperties;
    }
}
